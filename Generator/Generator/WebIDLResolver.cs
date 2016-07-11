using System;
using System.Collections.Generic;
using System.Linq;
using Generator.AstNodes;
using Generator.ExtensionMethods;

namespace Generator
{
    public class WebIDLResolver
    {
        public abstract class DataBase
        {
            public string Name;
            public abstract string DefinitionType { get; }
        }

        private class CallbackInterfaceData : DataBase
        {
            public string Base;
            public IReadOnlyList<InterfaceMember> Members;
            public IReadOnlyList<ExtendedAttribute> ExtendedAttributes;

            public override string DefinitionType { get { return "callback interface"; } }
        }

        private class InterfaceData : DataBase
        {
            public enum DefinitionStateEnum
            {
                DeclaredOnly,
                OnlyPartials,
                FullyDefined,
            }

            public string Base;
            public readonly List<string> Implements = new List<string>();
            public readonly List<InterfaceMember> Members = new List<InterfaceMember>();
            public readonly List<ExtendedAttribute> ExtendedAttributes = new List<ExtendedAttribute>();
            public DefinitionStateEnum DefinitionState;
            public bool IsUsed;

            public override string DefinitionType { get { return "interface"; } }
        }

        private class DictionaryData : DataBase
        {
            public string Base;
            public readonly List<DictionaryMember> Members = new List<DictionaryMember>();
            public readonly List<ExtendedAttribute> ExtendedAttributes = new List<ExtendedAttribute>();
            public bool FoundDefinition;

            public override string DefinitionType { get { return "dictionary"; } }
        }

        private class ExceptionData : DataBase
        {
            public string Base;
            public IReadOnlyList<ExceptionMember> Members;
            public IReadOnlyList<ExtendedAttribute> ExtendedAttributes;

            public override string DefinitionType { get { return "exception"; } }
        }

        public class CallbackData : DataBase
        {
            public WebIDLType ReturnType;
            public IReadOnlyList<Argument> Arguments;
            public IReadOnlyList<ExtendedAttribute> ExtendedAttributes;

            public override string DefinitionType { get { return "callback"; } }
        }

        public class TypedefData : DataBase
        {
            public WebIDLType ReferencedType;
            public IReadOnlyList<ExtendedAttribute> TypeExtendedAttributes;

            public override string DefinitionType { get { return "typedef"; } }
        }

        public class EnumData : DataBase
        {
            public IReadOnlyList<string> Values;
            public IReadOnlyList<ExtendedAttribute> ExtendedAttributes;

            public override string DefinitionType { get { return "enum"; } }
        }

        private Dictionary<string, DataBase> _entities = new Dictionary<string, DataBase>();
        private Dictionary<string, ResolvedDefinition> _resolved = new Dictionary<string, ResolvedDefinition>();
        private List<string> _errors = new List<string>();

        private TDefinition GetDefinition<TDefinition>(string name, bool allowDuplicate) where TDefinition : DataBase, new()
        {
            DataBase v;
            if (_entities.TryGetValue(name, out v))
            {
                var t = v as TDefinition;
                if (t != null)
                {
                    if (allowDuplicate)
                        return t;
                    var result = new TDefinition() { Name = name };
                    _errors.Add("Redefinition of " + result.DefinitionType + " `" + name + "'");
                    return result;
                }
                else
                {
                    var result = new TDefinition() { Name = name };
                    _errors.Add("Type `" + name + "' was defined as " + v.DefinitionType + " but redefined as " + result.DefinitionType);
                    return result;
                }
            }
            else
            {
                var d = new TDefinition() { Name = name };
                _entities[name] = d;
                return d;
            }
        }

        private void Prepare(Definition def)
        {
            def.Decompose(
                @interface =>
                {
                    var data = GetDefinition<InterfaceData>(@interface.Name, true);
                    if (data.DefinitionState == InterfaceData.DefinitionStateEnum.FullyDefined)
                        _errors.Add("Duplicate definition of interface `" + @interface.Name + "'");
                    data.Base = @interface.Base;
                    data.ExtendedAttributes.AddRange(@interface.ExtendedAttributes);
                    data.Members.AddRange(@interface.Members);
                    data.DefinitionState = InterfaceData.DefinitionStateEnum.FullyDefined;
                },
                callbackInterface =>
                {
                    var data = GetDefinition<CallbackInterfaceData>(callbackInterface.Name, false);
                    data.Base = callbackInterface.Base;
                    data.ExtendedAttributes = callbackInterface.ExtendedAttributes;
                    data.Members = callbackInterface.Members;
                },
                partialInterface =>
                {
                    var data = GetDefinition<InterfaceData>(partialInterface.Name, true);
                    data.ExtendedAttributes.AddRange(partialInterface.ExtendedAttributes);
                    data.Members.AddRange(partialInterface.Members);
                    if (data.DefinitionState == InterfaceData.DefinitionStateEnum.DeclaredOnly)
                        data.DefinitionState = InterfaceData.DefinitionStateEnum.OnlyPartials;
                },
                dictionary =>
                {
                    var data = GetDefinition<DictionaryData>(dictionary.Name, true);
                    if (data.FoundDefinition)
                        _errors.Add("Duplicate definition of dictionary `" + dictionary.Name + "'");
                    data.Base = dictionary.Base;
                    data.ExtendedAttributes.AddRange(dictionary.ExtendedAttributes);
                    data.Members.AddRange(dictionary.Members);
                    data.FoundDefinition = true;
                },
                partialDictionary =>
                {
                    var data = GetDefinition<DictionaryData>(partialDictionary.Name, true);
                    data.ExtendedAttributes.AddRange(partialDictionary.ExtendedAttributes);
                    data.Members.AddRange(partialDictionary.Members);
                },
                callback =>
                {
                    var data = GetDefinition<CallbackData>(callback.Name, false);
                    data.ReturnType = callback.ReturnType;
                    data.Arguments = callback.Arguments;
                    data.ExtendedAttributes = callback.ExtendedAttributes;
                },
                implements =>
                {   // Handled in the next step
                },
                exception =>
                {
                    var data = GetDefinition<ExceptionData>(exception.Name, false);
                    data.Base = exception.Base;
                    data.Members = exception.Members;
                    data.ExtendedAttributes = exception.ExtendedAttributes;
                },
                typedef =>
                {
                    var data = GetDefinition<TypedefData>(typedef.Name, false);
                    data.ReferencedType = typedef.ReferencedType;
                    data.TypeExtendedAttributes = typedef.TypeExtendedAttributes;
                },
                @enum =>
                {
                    var data = GetDefinition<EnumData>(@enum.Name, false);
                    data.Values = @enum.Values;
                    data.ExtendedAttributes = @enum.ExtendedAttributes;
                },
                interfaceDeclaration =>
                {
                    GetDefinition<InterfaceData>(interfaceDeclaration.Name, true);
                }
            );
        }

        private void ProcessImplementsStatements(List<Definition> unresolved)
        {
            foreach (var def in unresolved)
            {
                def.Decompose(implements:
                    implements =>
                    {
                        string error = null;
                        InterfaceData implementing = null;
                        DataBase d;
                        if (_entities.TryGetValue(implements.ImplementingType, out d))
                        {
                            implementing = d as InterfaceData;
                            if (implementing == null)
                                error = "The type `" + implements.ImplementingType + "' cannot implement `" + implements.ImplementedType + "' because the type `" + implements.ImplementingType + "' is a " + d.DefinitionType + ", not an interface";
                        }
                        else
                            error = "The interface `" + implements.ImplementingType + "', supposed to implement `" + implements.ImplementedType + "', does not exist";

                        if (error == null)
                        {
                            if (_entities.TryGetValue(implements.ImplementedType, out d))
                            {
                                var id = d as InterfaceData;
                                if (id != null)
                                    id.IsUsed = true;
                                else
                                    error = "The interface `" + implements.ImplementingType + "' cannot implement `" + implements.ImplementedType + "' because the type `" + implements.ImplementedType + "' is a " + d.DefinitionType + ", not an interface";
                            }
                            else
                                error = "The interface `" + implements.ImplementedType + "', supposed to be implemented by `" + implements.ImplementingType + "', does not exist";
                        }

                        if (error == null)
                            implementing.Implements.Add(implements.ImplementedType);
                        else
                            _errors.Add(error);
                    },
                    @interface: null, callbackInterface: null, partialInterface: null, dictionary: null, partialDictionary: null, callback: null, exception: null, typedef: null, @enum: null, interfaceDeclaration: null
                );
            }

            // handle transitivity (I1 implements I2; I2 implements I3;)
            var interfaces = _entities.Values.OfType<InterfaceData>().ToList();
            foreach (var component in TopologicalSorter.FindAndTopologicallySortStronglyConnectedComponents(interfaces, interfaces.SelectMany(iface => iface.Implements.Select(imp => Tuple.Create(iface, (InterfaceData)_entities[imp])))))
            {
                if (component.Count > 1)
                {
                    _errors.Add("Circular implementation involving the interfaces " + string.Join(", ", component.Select(c => "`" + c.Name + "'")));
                }
                else
                {
                    var item = component[0];
                    var all = item.Implements.Concat(item.Implements.SelectMany(imp => ((InterfaceData)_entities[imp]).Implements)).Distinct().ToList();
                    item.Implements.Clear();
                    item.Implements.AddRange(all);
                }
            }
        }

        private TDefinition CheckInheritance<TDefinition>(TDefinition inheritor, string baseName) where TDefinition : DataBase
        {
            if (baseName != null)
            {
                DataBase d;
                if (_entities.TryGetValue(baseName, out d))
                {
                    if (!(d is TDefinition))
                    {
                        _errors.Add("The " + inheritor.DefinitionType + " `" + inheritor.Name + "' cannot inherit from the " + d.DefinitionType + " `" + d.Name + "'");
                        return null;
                    }
                    return (TDefinition)d;
                }
                else
                {
                    _errors.Add("The base type `" + baseName + "' for the " + inheritor.DefinitionType + " `" + inheritor.Name + "' does not exist");
                    return null;
                }
            }
            return null;
        }

        private void BuildResolvedModel()
        {
            foreach (var e in _entities.Values.ToList())
            {   // Necessary to copy collection since Resolve() might declare interfaces for all undeclared symbols
                var @interface = e as InterfaceData;
                if (@interface != null)
                {
                    if (@interface.DefinitionState == InterfaceData.DefinitionStateEnum.OnlyPartials)
                        _errors.Add("There was no non-partial definition of the interface `" + e.Name + "'");
                    var b = CheckInheritance(@interface, @interface.Base);
                    if (b != null)
                        b.IsUsed = true;
                    else
                        @interface.Base = null;
                    if (@interface.DefinitionState != InterfaceData.DefinitionStateEnum.DeclaredOnly)
                        _resolved[e.Name] = ResolvedDefinition.Interface(e.Name, @interface.Base, @interface.Implements, @interface.Members.Select(Resolve), @interface.ExtendedAttributes.Select(Resolve));
                }
                var dictionary = e as DictionaryData;
                if (dictionary != null)
                {
                    if (!dictionary.FoundDefinition)
                        _errors.Add("There was no non-partial definition of the dictionary `" + e.Name + "'");
                    if (CheckInheritance(dictionary, dictionary.Base) == null)
                        dictionary.Base = null;
                    _resolved[e.Name] = ResolvedDefinition.Dictionary(e.Name, dictionary.Base, dictionary.Members.Select(Resolve), dictionary.ExtendedAttributes.Select(Resolve));
                }
                var cinterface = e as CallbackInterfaceData;
                if (cinterface != null)
                {
                    if (CheckInheritance(cinterface, cinterface.Base) == null)
                        cinterface.Base = null;
                    _resolved[e.Name] = ResolvedDefinition.CallbackInterface(e.Name, cinterface.Base, cinterface.Members.Select(Resolve), cinterface.ExtendedAttributes.Select(Resolve));
                }
                var cb = e as CallbackData;
                if (cb != null)
                {
                    var t = Resolve(cb.ReturnType, cb.ExtendedAttributes);
                    _resolved[e.Name] = ResolvedDefinition.Callback(e.Name, t.Item1, cb.Arguments.Select(Resolve), t.Item2.Select(Resolve));
                }
                var ex = e as ExceptionData;
                if (ex != null)
                {
                    if (CheckInheritance(ex, ex.Base) == null)
                        ex.Base = null;
                    _resolved[e.Name] = ResolvedDefinition.Exception(e.Name, ex.Base, ex.Members.Select(Resolve), ex.ExtendedAttributes.Select(Resolve));
                }
                var enm = e as EnumData;
                if (enm != null)
                {
                    _resolved[e.Name] = ResolvedDefinition.Enum(e.Name, enm.Values, enm.ExtendedAttributes.Select(Resolve));
                }
            }

            foreach (var declared in _entities.Values.OfType<InterfaceData>().Where(d => d.DefinitionState == InterfaceData.DefinitionStateEnum.DeclaredOnly && d.IsUsed))
            {
                _resolved[declared.Name] = ResolvedDefinition.DeclaredInterface(declared.Name);
            }
        }

        private WebIDLResolver(List<Definition> unresolved)
        {
            foreach (var def in unresolved)
                Prepare(def);
            ProcessImplementsStatements(unresolved);
            BuildResolvedModel();
        }

        private InterfaceMember Resolve(InterfaceMember member)
        {
            return member.DecomposeWithResult(
                @const => { var t = Resolve(@const.Type, @const.ExtendedAttributes); return InterfaceMember.Const(@const.Name, t.Item1, @const.Value, t.Item2.Select(Resolve)); },
                operation => { var t = Resolve(operation.ReturnType, operation.ExtendedAttributes); return InterfaceMember.Operation(operation.Name, t.Item1, operation.Arguments.Select(Resolve), operation.Qualifiers, t.Item2.Select(Resolve)); },
                attribute => { var t = Resolve(attribute.Type, attribute.ExtendedAttributes); return InterfaceMember.Attribute(attribute.Name, t.Item1, attribute.Qualifiers, t.Item2.Select(Resolve)); },
                jsonifier => InterfaceMember.Jsonifier(jsonifier.ExtendedAttributes.Select(Resolve))
            );
        }

        private DictionaryMember Resolve(DictionaryMember member)
        {
            var t = Resolve(member.Type, member.ExtendedAttributes);
            return DictionaryMember.Create(t.Item1, member.Name, member.Default, t.Item2.Select(Resolve));
        }

        private ExceptionMember Resolve(ExceptionMember member)
        {
            return member.DecomposeWithResult(
                @const => { var t = Resolve(@const.Type, @const.ExtendedAttributes); return ExceptionMember.Const(@const.Name, t.Item1, @const.Value, t.Item2.Select(Resolve)); },
                field => { var t = Resolve(field.Type, field.ExtendedAttributes); return ExceptionMember.Field(field.Name, t.Item1, t.Item2.Select(Resolve)); }
            );
        }

        private ExtendedAttribute Resolve(ExtendedAttribute attribute)
        {
            return attribute.DecomposeWithResult(
                noArgs => ExtendedAttribute.NoArgs(noArgs.AttributeName),
                argList => ExtendedAttribute.ArgList(argList.AttributeName, argList.Arguments.Select(Resolve)),
                namedArgList => ExtendedAttribute.NamedArgList(namedArgList.AttributeName, namedArgList.ArgListName, namedArgList.Arguments.Select(Resolve)),
                ident => ExtendedAttribute.Ident(ident.AttributeName, ident.Ident),
                value => ExtendedAttribute.Value(value.AttributeName, value.Value)
            );
        }

        private Argument Resolve(Argument argument)
        {
            return argument.DecomposeWithResult(
                required => { var t = Resolve(required.Type, required.ExtendedAttributes); return Argument.Required(required.Name, t.Item1, t.Item2.Select(Resolve)); },
                optional => { var t = Resolve(optional.Type, optional.ExtendedAttributes); return Argument.Optional(optional.Name, t.Item1, optional.DefaultValue, t.Item2.Select(Resolve)); },
                ellipsis => { var t = Resolve(ellipsis.Type, ellipsis.ExtendedAttributes); return Argument.Ellipsis(ellipsis.Name, t.Item1, t.Item2.Select(Resolve)); }
            );
        }

        private Tuple<List<WebIDLType>, bool> FlattenAndResolveUnionMembers(IEnumerable<WebIDLType> unionMembers)
        {
            var result = new List<WebIDLType>();
            bool hasNullable = false;
            foreach (var t in unionMembers)
            {
                var underlying = this.Resolve(t, null).Item1;

                underlying = underlying.DecomposeWithResult(
                    builtin => underlying,
                    @void => underlying,
                    union => underlying,
                    typeReference => underlying,
                    array => underlying,
                    sequence => underlying,
                    nullable => { hasNullable = true; return nullable.UnderlyingType; }
                );

                underlying.Decompose(
                    builtin => result.Add(underlying),
                    @void => result.Add(underlying),
                    union => { var nested = FlattenAndResolveUnionMembers(union.Members); hasNullable |= nested.Item2; result.AddRange(nested.Item1); },
                    typeReference => result.Add(underlying),
                    array => result.Add(underlying),
                    sequence => result.Add(underlying),
                    nullable => result.Add(underlying)
                );
            }

            return Tuple.Create(result, hasNullable);
        }

        private Tuple<WebIDLType, IReadOnlyList<ExtendedAttribute>> Resolve(WebIDLType type, IEnumerable<ExtendedAttribute> extendedAttributes)
        {
            return type.DecomposeWithResult(
                builtin => Tuple.Create(WebIDLType.Builtin(builtin.BuiltinType), extendedAttributes.AsReadOnlySafe()),
                @void => Tuple.Create(WebIDLType.Void(), extendedAttributes.AsReadOnlySafe()),
                @union =>
                {
                    var flat = FlattenAndResolveUnionMembers(@union.Members);
                    var t = WebIDLType.Union(flat.Item1);
                    if (flat.Item2)
                        t = WebIDLType.Nullable(t);
                    return Tuple.Create(t, extendedAttributes.AsReadOnlySafe());
                },
                typeReference =>
                {
                    DataBase d;
                    if (!_entities.TryGetValue(typeReference.Target, out d))
                    {
                        _errors.Add("The type `" + typeReference.Target + "' does not exist.");
                        d = _entities[typeReference.Target] = new InterfaceData { Name = typeReference.Target };
                    }
                    if (d is TypedefData)
                    {
                        var td = (TypedefData)d;
                        return Resolve(td.ReferencedType, (extendedAttributes ?? new ExtendedAttribute[0]).Concat(td.TypeExtendedAttributes));
                    }
                    else if (d is InterfaceData)
                    {
                        ((InterfaceData)d).IsUsed = true;
                    }
                    return Tuple.Create(WebIDLType.TypeReference(typeReference.Target), extendedAttributes.AsReadOnlySafe());
                },
                array => Tuple.Create(WebIDLType.Array(Resolve(array.ElementType, new ExtendedAttribute[0]).Item1), extendedAttributes.AsReadOnlySafe()),
                sequence => Tuple.Create(WebIDLType.Sequence(Resolve(sequence.ElementType, new ExtendedAttribute[0]).Item1), extendedAttributes.AsReadOnlySafe()),
                nullable =>
                {
                    // Attributes flow through nullables (I suppose)
                    var res = Resolve(nullable.UnderlyingType, extendedAttributes);
                    bool isNullable = res.Item1.DecomposeWithResult(
                        builtin: _ => false,
                        @void: _ => false,
                        union: _ => false,
                        typeReference: _ => false,
                        array: _ => false,
                        sequence: _ => false,
                        nullable: _ => true
                    );
                    return Tuple.Create(isNullable ? res.Item1 : WebIDLType.Nullable(res.Item1), res.Item2);
                }
            );
        }

        public static Tuple<Dictionary<string, ResolvedDefinition>, List<string>> Resolve(IEnumerable<Definitions> definitions)
        {
            var r = new WebIDLResolver(definitions.SelectMany(d => d.Items).ToList());
            return Tuple.Create(r._resolved, r._errors);
        }
    }
}
