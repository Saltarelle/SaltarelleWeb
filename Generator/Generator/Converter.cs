using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using Generator.AstNodes;
using Generator.ExtensionMethods;
using Generator.Meta;
using ICSharpCode.NRefactory.CSharp;
using ICSharpCode.NRefactory.TypeSystem;
using Attribute = ICSharpCode.NRefactory.CSharp.Attribute;
using TypeKind = Generator.Meta.TypeKind;

namespace Generator
{
    public class Converter
    {
        private class ParsedExtendedAttributes
        {
            public enum TreatUndefinedAsOptions
            {
                Default,
                EmptyString,
                Null,
                Missing,
            }

            public bool ArrayClass { get; private set; }
            public bool PrefControlled { get; private set; }
            public bool NoInterfaceObject { get; private set; }
            public bool ChromeOnly { get; private set; }
            public bool OverrideBuiltins { get; private set; }
            public bool NeedNewResolve { get; private set; }
            public string Pref { get; private set; }
            public string HeaderFile { get; private set; }
            public string JSImplementation { get; private set; }
            public string NavigatorProperty { get; private set; }
            public bool Throws { get; private set; }
            public bool TreatNullAsEmptyString { get; private set; }
            public bool GetterThrows { get; private set; }
            public bool SetterThrows { get; private set; }
            public bool Pure { get; private set; }
            public bool Creator { get; private set; }
            public bool LenientFloat { get; private set; }
            public bool WebGLHandlesContextLoss { get; private set; }
            public bool Unforgeable { get; private set; }
            public bool LenientThis { get; private set; }
            public bool Constant { get; private set; }
            public bool TreatNonCallableAsNull { get; private set; }
            public string PutForwards { get; private set; }
            public string Func { get; private set; }
            public bool EnforceRange { get; private set; }
            public bool Clamp { get; private set; }
            public bool Global { get; private set; }
            public bool SameObject { get; private set; }
            public bool NewObject { get; private set; }
            public bool Replaceable { get; private set; }
            public bool StoreInSlot { get; private set; }
            public bool CrossOriginReadable { get; private set; }
            public bool CrossOriginWritable { get; private set; }
            public bool CrossOriginCallable { get; private set; }
            public bool ChromeConstructor { get; private set; }
            public bool TreatNonObjectAsNull { get; private set; }
            public TreatUndefinedAsOptions TreatUndefinedAs { get; private set; }
            public IReadOnlyList<IReadOnlyList<Argument>> Constructors { get; private set; }
            public IReadOnlyList<IReadOnlyList<Argument>> ChromeConstructors { get; private set; }
            public IReadOnlyList<Tuple<string, IReadOnlyList<Argument>>> NamedConstructors { get; private set; }

            private ParsedExtendedAttributes()
            {
            }

            private static string GetString(Value value)
            {
                return value.DecomposeWithResult(
                    @int => null,
                    @double => null,
                    @string => @string,
                    special => null
                );
            }

            public static ParsedExtendedAttributes Parse(IEnumerable<ExtendedAttribute> attributes, string scopeName, List<string> errors)
            {
                var result = new ParsedExtendedAttributes();
                var constructors = new List<IReadOnlyList<Argument>>();
                var chromeConstructors = new List<IReadOnlyList<Argument>>();
                var namedConstructors = new List<Tuple<string, IReadOnlyList<Argument>>>();

                foreach (var attr in attributes)
                {
                    attr.Decompose(
                        noArgs =>
                        {
                            switch (noArgs.AttributeName)
                            {
                                case "ArrayClass":
                                    result.ArrayClass = true;
                                    break;
                                case "PrefControlled":
                                    result.PrefControlled = true;
                                    break;
                                case "NoInterfaceObject":
                                    result.NoInterfaceObject = true;
                                    break;
                                case "ChromeOnly":
                                    result.ChromeOnly = true;
                                    break;
                                case "Constructor":
                                    constructors.Add(new Argument[0]);
                                    break;
                                case "OverrideBuiltins":
                                    result.OverrideBuiltins = true;
                                    break;
                                case "NeedNewResolve":
                                    result.NeedNewResolve = true;
                                    break;
                                case "Throws":
                                    result.Throws = true;
                                    break;
                                case "GetterThrows":
                                    result.GetterThrows = true;
                                    break;
                                case "SetterThrows":
                                    result.SetterThrows = true;
                                    break;
                                case "Pure":
                                    result.Pure = true;
                                    break;
                                case "Creator":
                                    result.Creator = true;
                                    break;
                                case "LenientFloat":
                                    result.LenientFloat = true;
                                    break;
                                case "WebGLHandlesContextLoss":
                                    result.WebGLHandlesContextLoss = true;
                                    break;
                                case "Unforgeable":
                                    result.Unforgeable = true;
                                    break;
                                case "LenientThis":
                                    result.LenientThis = true;
                                    break;
                                case "Constant":
                                    result.Constant = true;
                                    break;
                                case "TreatNonCallableAsNull":
                                    result.TreatNonCallableAsNull = true;
                                    break;
                                case "EnforceRange":
                                    result.EnforceRange = true;
                                    break;
                                case "Clamp":
                                    result.Clamp = true;
                                    break;
                                case "Global":
                                    result.Global = true;
                                    break;
                                case "SameObject":
                                    result.SameObject = true;
                                    break;
                                case "NewObject":
                                    result.NewObject = true;
                                    break;
                                case "Replaceable":
                                    result.Replaceable = true;
                                    break;
                                case "StoreInSlot":
                                    result.StoreInSlot = true;
                                    break;
                                case "CrossOriginReadable":
                                    result.CrossOriginReadable = true;
                                    break;
                                case "CrossOriginWritable":
                                    result.CrossOriginWritable = true;
                                    break;
                                case "CrossOriginCallable":
                                    result.CrossOriginCallable = true;
                                    break;
                                case "TreatNonObjectAsNull":
                                    result.TreatNonObjectAsNull = true;
                                    break;
                                default:
                                    errors.Add(string.Format("Unknown ExtendedAttributeNoArgs `{0}' on `{1}'", noArgs.AttributeName, scopeName));
                                    break;
                            }
                        },
                        argList =>
                        {
                            switch (argList.AttributeName)
                            {
                                case "Constructor":
                                    constructors.Add(argList.Arguments);
                                    break;
                                case "ChromeConstructor":
                                    chromeConstructors.Add(argList.Arguments);
                                    break;
                                default:
                                    errors.Add(string.Format("Unknown ExtendedAttributeArgList `{0}' on `{1}'", argList.AttributeName, scopeName));
                                    break;
                            }
                        },
                        namedArgList =>
                        {
                            switch (namedArgList.AttributeName)
                            {
                                case "NamedConstructor":
                                    namedConstructors.Add(Tuple.Create(namedArgList.ArgListName, namedArgList.Arguments));
                                    break;
                                default:
                                    errors.Add(string.Format("Unknown ExtendedAttributeNamedArgList `{0}' on `{1}'", namedArgList.AttributeName, scopeName));
                                    break;
                            }
                        },
                        ident =>
                        {
                            switch (ident.AttributeName)
                            {
                                case "NamedConstructor":
                                    namedConstructors.Add(Tuple.Create(ident.Ident, (IReadOnlyList<Argument>)new Argument[0]));
                                    break;
                                case "TreatNullAs":
                                    if (ident.Ident != "EmptyString")
                                        errors.Add(string.Format("Expecting `EmptyString' as the value for the attribute TreatNullAs on  `{0}' (value was `{1}')", scopeName, ident.Ident));
                                    result.TreatNullAsEmptyString = true;
                                    break;
                                case "TreatUndefinedAs":
                                    switch (ident.Ident)
                                    {
                                        case "EmptyString": result.TreatUndefinedAs = TreatUndefinedAsOptions.EmptyString; break;
                                        case "Null": result.TreatUndefinedAs = TreatUndefinedAsOptions.Null; break;
                                        case "Missing": result.TreatUndefinedAs = TreatUndefinedAsOptions.Missing; break;
                                        default: errors.Add(string.Format("Expecting `EmptyString', `Null' or `Missing' as the value for the attribute TreatUndefinedAs on  `{0}' (value was `{1}')", scopeName, ident.Ident)); break;
                                    }
                                    break;
                                case "PutForwards":
                                    result.PutForwards = ident.Ident;
                                    break;
                                case "GetterThrows":
                                    result.GetterThrows = true;
                                    break;
                                case "SetterThrows":
                                    result.GetterThrows = true;
                                    break;
                                case "Throws":
                                    result.GetterThrows = true;
                                    break;
                                default:
                                    errors.Add(string.Format("Unknown ExtendedAttributeIdent `{0}' on `{1}'", ident.AttributeName, scopeName));
                                    break;
                            }
                        },
                        value =>
                        {
                            switch (value.AttributeName)
                            {
                                case "Pref":
                                    result.Pref = GetString(value.Value);
                                    if (result.Pref == null)
                                        errors.Add(string.Format("Expected string value for the attribute `Pref' on `{1}'", value.AttributeName, scopeName));
                                    break;
                                case "HeaderFile":
                                    result.HeaderFile = GetString(value.Value);
                                    if (result.HeaderFile == null)
                                        errors.Add(string.Format("Expected string value for the attribute `HeaderFile' on `{1}'", value.AttributeName, scopeName));
                                    break;
                                case "JSImplementation":
                                    result.JSImplementation = GetString(value.Value);
                                    if (result.JSImplementation == null)
                                        errors.Add(string.Format("Expected string value for the attribute `JSImplementation' on `{1}'", value.AttributeName, scopeName));
                                    break;
                                case "NavigatorProperty":
                                    result.NavigatorProperty = GetString(value.Value);
                                    if (result.NavigatorProperty == null)
                                        errors.Add(string.Format("Expected string value for the attribute `NavigatorProperty' on `{1}'", value.AttributeName, scopeName));
                                    break;
                                case "Func":
                                    result.Func = GetString(value.Value);
                                    if (result.Func == null)
                                        errors.Add(string.Format("Expected string value for the attribute `Func' on `{1}'", value.AttributeName, scopeName));
                                    break;
                                default:
                                    errors.Add(string.Format("Unknown ExtendedAttributeValue `{0}' on `{1}'", value.AttributeName, scopeName));
                                    break;
                            }
                        }
                    );
                }

                result.Constructors = constructors.AsReadOnlySafe();
                result.NamedConstructors = namedConstructors.AsReadOnlySafe();
                result.ChromeConstructors = chromeConstructors.AsReadOnlySafe();

                return result;
            }
        }

        private readonly Dictionary<string, ResolvedDefinition> _types;
        private readonly Metadata _metadata;
        private readonly List<string> _errors = new List<string>();
        private readonly List<NamespacedEntityDeclaration> _result = new List<NamespacedEntityDeclaration>();

        private Converter(Dictionary<string, ResolvedDefinition> types, Metadata metadata)
        {
            _types = types;
            _metadata = metadata;
        }

        private static Attribute FieldPropertyAttribute { get { return new Attribute { Type = MakeType("Bridge.FieldProperty") }; } }

        private static Attribute EnumerateAsArrayAttribute { get { return new Attribute { Type = MakeType("Bridge.EnumerateAsArray") }; } }

        private static Attribute IgnoreNamespaceAttribute { get { return new Attribute { Type = MakeType("Bridge.Namespace"), Arguments = { new PrimitiveExpression("false") } }; } }

        private static Attribute NamedValuesAttribute
        {
            get { return new Attribute { Type = MakeType("Bridge.Enum"), Arguments = { new MemberReferenceExpression(new IdentifierExpression("Emit"), "StringNamePreserveCase") } }; }
        }

        private static Attribute SerializableAttribute { get { return new Attribute { Type = MakeType("Bridge.Serializable") }; } }

        private static Attribute GlobalMethodsAttribute { get { return new Attribute { Type = MakeType("Bridge.GlobalMethods") }; } }

        private static Attribute FlagsAttribute { get { return new Attribute { Type = MakeType("Bridge.Flags") }; } }

        private static Attribute ExpandParamsAttribute { get { return new Attribute { Type = MakeType("Bridge.ExpandParams") }; } }

        private static Attribute TemplateAttribute(string code)
        {
            return new Attribute { Type = MakeType("Bridge.Template"), Arguments = { new PrimitiveExpression("\"" + code + "\"", "\"" + code + "\"") } };
        }

        private Attribute NameAttribute(string name)
        {
            return new Attribute { Type = MakeType("Bridge.Name"), Arguments = { new PrimitiveExpression("\"" + name + "\"", "\"" + name + "\"") } };
        }

        private IEnumerable<Attribute> NameAttributeIfRequired(string csharpName, string name)
        {
            if (csharpName.MakeCamelCase() != name)
                yield return NameAttribute(name);
        }

        private IEnumerable<Attribute> ExpandParamsIfRequired(IEnumerable<ParameterDeclaration> parameters)
        {
            if (parameters.Any(p => p.ParameterModifier == ParameterModifier.Params))
                yield return ExpandParamsAttribute;
        }

        private static Attribute ExternalAttribute(bool obeysTypeSystem, string typeCheckCode = null)
        {
            var result = new Attribute { Type = MakeType("Bridge.External") };
            if (obeysTypeSystem)
                result.Arguments.Add(new NamedExpression("ObeysTypeSystem", new PrimitiveExpression(true, "true")));
            if (typeCheckCode != null)
                result.Arguments.Add(new NamedExpression("TypeCheckCode", new PrimitiveExpression("\"" + typeCheckCode + "\"", "\"" + typeCheckCode + "\"")));
            return result;
        }

        private static Attribute IndexerNameAttribute(string name)
        {
            return new Attribute { Type = MakeType("Bridge.IndexerName"), Arguments = { new PrimitiveExpression("\"" + name + "\"", "\"" + name + "\"") } };
        }

        private static string GetUnqualifiedTypeName(AstType type)
        {
            if (type is SimpleType)
            {
                return ((SimpleType)type).Identifier;
            }
            else if (type is PrimitiveType)
            {
                return ((PrimitiveType)type).Keyword;
            }
            else if (type is ComposedType)
            {
                var ct = (ComposedType)type;
                return GetUnqualifiedTypeName(ct.BaseType) + (ct.HasNullableSpecifier ? "?" : "") + (ct.ArraySpecifiers.Count > 0 ? "[]" : "");
            }
            else if (type is MemberType)
            {
                return ((MemberType)type).MemberName;
            }
            else
                throw new ArgumentException("type was of type " + type.GetType(), "type");
        }

        private static Tuple<int, string, string> MemberOrderer(EntityDeclaration member)
        {
            if (member is ConstructorDeclaration)
                return Tuple.Create(0, (string)null, string.Join(",", ((ConstructorDeclaration)member).Parameters.Select(p => GetUnqualifiedTypeName(p.Type))));
            if (member is PropertyDeclaration)
                return Tuple.Create(2, member.Name, "");
            if (member is MethodDeclaration)
                return Tuple.Create(2, member.Name, string.Join(",", ((MethodDeclaration)member).Parameters.Select(p => GetUnqualifiedTypeName(p.Type))));
            if (member is FieldDeclaration)
                return Tuple.Create(2, ((FieldDeclaration)member).Variables.First().Name, "");
            if (member is IndexerDeclaration)
                return Tuple.Create(1, "", string.Join(",", ((IndexerDeclaration)member).Parameters.Select(p => p.Type.ToString())));
            throw new ArgumentException("member");
        }

        private static AstType GetOrDefaultAstType<TKey>(IReadOnlyDictionary<TKey, AstType> dict, TKey key, AstType def)
        {
            AstType result;
            if (!dict.TryGetValue(key, out result))
                result = def;
            return result.Clone();
        }

        private static string GetOrDefaultString<TKey>(IReadOnlyDictionary<TKey, string> dict, TKey key, string def)
        {
            string result;
            if (!dict.TryGetValue(key, out result))
                result = def;
            return result;
        }

        private static AstType GetOrDefaultAstType(IReadOnlyDictionary<string, AstType> dict, string name, InterfaceMember member, AstType def)
        {
            AstType result;
            if (name != null && dict.TryGetValue(name, out result))
                return result.Clone();
            if (dict.TryGetValue(WebIDLFormatter.FormatSignature(member), out result))
                return result.Clone();
            return def.Clone();
        }

        private static AstType MakeType(string fullName, IEnumerable<AstType> typeArguments = null)
        {
            typeArguments = typeArguments != null ? typeArguments.Select(a => a.Clone()) : null;
            var parts = fullName.Split('.');
            AstType result = new SimpleType(parts[0], (parts.Length == 1 ? typeArguments : null) ?? new AstType[0]);
            for (int i = 1; i < parts.Length; i++)
                result = new MemberType(result, parts[i], (i == parts.Length - 1 ? typeArguments : null) ?? new AstType[0]);
            return result;
        }

        private AstType ConvertType(WebIDLType type)
        {
            return type.DecomposeWithResult(
                builtin =>
                {
                    switch (builtin.BuiltinType)
                    {
                        case BuiltinType.Any: return new PrimitiveType("object");
                        case BuiltinType.DOMString: return new PrimitiveType("string");
                        case BuiltinType.Object: return new PrimitiveType("object");
                        case BuiltinType.Date: return MakeType("System.DateTime");
                        case BuiltinType.Boolean: return new PrimitiveType("bool");
                        case BuiltinType.Byte: return new PrimitiveType("sbyte");
                        case BuiltinType.Octet: return new PrimitiveType("byte");
                        case BuiltinType.Float: return new PrimitiveType("double");
                        case BuiltinType.UnrestrictedFloat: return new PrimitiveType("double");
                        case BuiltinType.Double: return new PrimitiveType("double");
                        case BuiltinType.UnrestrictedDouble: return new PrimitiveType("double");
                        case BuiltinType.Short: return new PrimitiveType("short");
                        case BuiltinType.UnsignedShort: return new PrimitiveType("ushort");
                        case BuiltinType.Long: return new PrimitiveType("int");
                        case BuiltinType.UnsignedLong: return new PrimitiveType("int");
                        case BuiltinType.LongLong: return new PrimitiveType("long");
                        case BuiltinType.UnsignedLongLong: return new PrimitiveType("ulong");
                        default: throw new ArgumentException("Invalid builtin type " + builtin.BuiltinType);
                    }
                },
                @void => new PrimitiveType("void"),
                @union => MakeType("System.TypeOption", @union.Members.Select(ConvertType)),
                typeReference =>
                {
                    var meta = _metadata.Types[typeReference.Target];
                    return meta.AliasFor ?? MakeType((!string.IsNullOrEmpty(meta.Namespace) ? meta.Namespace + "." : "") + meta.CSharpName);
                },
                array => ConvertType(array.ElementType).MakeArrayType(),
                sequence => ConvertType(sequence.ElementType).MakeArrayType(),
                nullable =>
                {
                    bool underlyingIsNullable = nullable.UnderlyingType.DecomposeWithResult(
                        builtin =>
                        {
                            switch (builtin.BuiltinType)
                            {
                                case BuiltinType.Any:
                                case BuiltinType.DOMString:
                                case BuiltinType.Object:
                                    return true;
                                default:
                                    return false;
                            }
                        },
                        @void => true,
                        union => true,
                        typeReference =>
                        {
                            var t = _types[typeReference.Target];
                            return t.DecomposeWithResult(
                                @interface => true,
                                callbackInterface => true,
                                dictionary => true,
                                callback => true,
                                exception => true,
                                @enum => false,
                                declaredInterface => true
                            );
                        },
                        array => true,
                        sequence => true,
                        nullable2 => true
                    );
                    var result = ConvertType(nullable.UnderlyingType);
                    if (!underlyingIsNullable)
                        result = result.MakeNullableType();
                    return result;
                }
            );
        }

        private Expression ConvertValue(Value value)
        {
            return value.DecomposeWithResult<Expression>(
                @int => new PrimitiveExpression(@int, @int.ToString(CultureInfo.InvariantCulture)),
                @float => new PrimitiveExpression(@float, @float.ToString(CultureInfo.InvariantCulture)),
                @string => new PrimitiveExpression("\"" + @string + "\"", "\"" + @string + "\""),
                special =>
                {
                    switch (special)
                    {
                        case SpecialValue.True: return new PrimitiveExpression(true, "true");
                        case SpecialValue.False: return new PrimitiveExpression(false, "false");
                        case SpecialValue.Null: return new NullReferenceExpression();
                        case SpecialValue.PositiveInfinity: return new MemberReferenceExpression(new IdentifierExpression("double"), "PositiveInfinity");
                        case SpecialValue.NegativeInfinity: return new MemberReferenceExpression(new IdentifierExpression("double"), "NegativeInfinity");
                        case SpecialValue.NaN: return new MemberReferenceExpression(new IdentifierExpression("double"), "NaN");
                        default: throw new ArgumentException("Invalid special value " + special);
                    }
                }
            );
        }

        //private static BlockStatement GenerateBody(AstType returnType)
        //{
        //    Expression returnExpr;
        //    var pt = returnType as PrimitiveType;
        //    if (pt != null)
        //    {
        //        if (pt.KnownTypeCode == KnownTypeCode.Void)
        //            return new BlockStatement();

        //        switch (pt.KnownTypeCode)
        //        {
        //            case KnownTypeCode.String:
        //            case KnownTypeCode.Object:
        //                returnExpr = new NullReferenceExpression();
        //                break;
        //            case KnownTypeCode.Char:
        //                returnExpr = new PrimitiveExpression('\0', "\\0");
        //                break;
        //            case KnownTypeCode.Boolean:
        //                returnExpr = new PrimitiveExpression(false, "false");
        //                break;
        //            default:
        //                returnExpr = new PrimitiveExpression(0, "0");
        //                break;
        //        }
        //    }
        //    else if (returnType is ComposedType)
        //    {
        //        returnExpr = new NullReferenceExpression();
        //    }
        //    else
        //    {
        //        returnExpr = new DefaultValueExpression(returnType.Clone());
        //    }

        //    return new BlockStatement { Statements = { new ReturnStatement(returnExpr) } };
        //}

        private IList<IReadOnlyList<ParameterDeclaration>> GetParameterLists(IEnumerable<Argument> arguments, Dictionary<string, AstType> typeOverrides, bool includePartialSignatures)
        {
            var result = new List<IReadOnlyList<ParameterDeclaration>>();
            var current = new List<ParameterDeclaration>();

            foreach (var arg in arguments)
            {
                string name = arg.Name.RemoveLeadingUnderscore();
                var type = GetOrDefaultAstType(typeOverrides, name, ConvertType(arg.Type));

                arg.Decompose(
                    required =>
                    {
                        current.Add(new ParameterDeclaration(type, name));
                    },
                    optional =>
                    {
                        if (includePartialSignatures)
                            result.Add(new List<ParameterDeclaration>(current.Select(p => (ParameterDeclaration)p.Clone())));
                        current.Add(new ParameterDeclaration(type, name));
                    },
                    ellipsis =>
                    {
                        current.Add(new ParameterDeclaration(type.MakeArrayType(), name, ParameterModifier.Params));
                    }
                );
            }
            result.Add(current);

            return result;
        }

        private string GetClosestInterfaceObjectName(ResolvedDefinition interfaceDef)
        {
            return interfaceDef.DecomposeWithResult(
                @interface =>
                {
                    var ea = ParsedExtendedAttributes.Parse(@interface.ExtendedAttributes, @interface.Name, _errors);
                    if (ea.NoInterfaceObject)
                    {
                        if (@interface.Base == null)
                            return "Object";
                        else
                            return GetClosestInterfaceObjectName(_types[@interface.Base]);
                    }
                    return _metadata.Types[@interface.Name].ScriptName;
                },
                callbackInterface: null,
                dictionary: null,
                callback: null,
                exception: null,
                @enum: null,
                declaredInterface: null
            );
        }

        private bool ShouldBeIncluded(string name, string typeName, ParsedExtendedAttributes memberAttributes)
        {
            if (name != null)
            {
                if (name.StartsWith("Moz", StringComparison.OrdinalIgnoreCase) || name.StartsWith("onMoz", StringComparison.OrdinalIgnoreCase))
                    return false;
            }
            if (memberAttributes != null && memberAttributes.ChromeOnly)
                return false;
            return true;
        }

        private class IndexedPropertyData
        {
            public AstType IndexParameterType;
            public List<string> IndexParameterNames = new List<string>();
            public List<AstType> PropertyTypes = new List<AstType>();
            public bool CanRead;
            public bool CanWrite;
        }

        private bool IsIntegerType(AstType type)
        {
            var pt = type as PrimitiveType;
            if (pt != null)
            {
                switch (pt.KnownTypeCode)
                {
                    case KnownTypeCode.SByte:
                    case KnownTypeCode.Byte:
                    case KnownTypeCode.Int16:
                    case KnownTypeCode.UInt16:
                    case KnownTypeCode.Int32:
                    case KnownTypeCode.UInt32:
                    case KnownTypeCode.Int64:
                    case KnownTypeCode.UInt64:
                        return true;
                }
            }
            return false;
        }

        private bool HasIntegerLength(IEnumerable<EntityDeclaration> members)
        {
            return members.Any(m => m.Name == "Length" && IsIntegerType(m.ReturnType) && ((m is PropertyDeclaration && !((PropertyDeclaration)m).Getter.IsNull) || m is FieldDeclaration));
        }

        private void AddAttributes(AstNodeCollection<AttributeSection> attributes, IEnumerable<Attribute> newAttributes)
        {
            AttributeSection section = null;
            foreach (var attr in newAttributes)
            {
                if (attributes.Count == 0)
                {
                    section = new AttributeSection();
                    attributes.Add(section);
                }
                else if (section == null)
                    section = attributes.First();
                section.Attributes.Add(attr);
            }
        }

        private void AddAttribute(AstNodeCollection<AttributeSection> attributes, Attribute newAttribute)
        {
            if (attributes.Count == 0)
                attributes.Add(new AttributeSection());
            attributes.First().Attributes.Add(newAttribute);
        }

        private void AddConstructors(ParsedExtendedAttributes attributes, Dictionary<string, AstType> typeOverrides, List<EntityDeclaration> members)
        {
            bool hasParameterlessCtor = false;
            foreach (var c in attributes.Constructors)
            {
                foreach (var sig in GetParameterLists(c, typeOverrides, includePartialSignatures: true))
                {
                    if (sig.Count == 0)
                        hasParameterlessCtor = true;
                    var ctor = new ConstructorDeclaration { Modifiers = Modifiers.Public | Modifiers.Extern };
                    ctor.Parameters.AddRange(sig);
                    AddAttributes(ctor.Attributes, ExpandParamsIfRequired(sig));
                    members.Add(ctor);
                }
            }
            foreach (var c in attributes.NamedConstructors)
            {
                foreach (var sig in GetParameterLists(c.Item2, typeOverrides, includePartialSignatures: true))
                {
                    if (sig.Count == 0)
                        hasParameterlessCtor = true;
                    var ctor = new ConstructorDeclaration { Modifiers = Modifiers.Public | Modifiers.Extern };
                    ctor.Parameters.AddRange(sig);
                    AddAttribute(ctor.Attributes, TemplateAttribute("new " + c.Item1 + MakeInlineCodeParameterList(sig)));
                    members.Add(ctor);
                }
            }
            if (!hasParameterlessCtor)
            {
                members.Add(new ConstructorDeclaration { Modifiers = Modifiers.Internal | Modifiers.Extern });
            }
        }

        private string MakeInlineCodeParameterList(IReadOnlyList<ParameterDeclaration> parameters)
        {
            var result = new StringBuilder("(");
            bool first = true;
            foreach (var p in parameters)
            {
                if (!first)
                    result.Append(", ");
                result.Append("{" + (p.ParameterModifier == ParameterModifier.Params ? "*" : "") + p.Name + "}");
                first = false;
            }
            result.Append(")");
            return result.ToString();
        }

        private ParsedExtendedAttributes ParseExtendedAttributes(ResolvedDefinition type)
        {
            var t = type.DecomposeWithResult(
                @interface => Tuple.Create(@interface.Name, @interface.ExtendedAttributes),
                callbackInterface => Tuple.Create(callbackInterface.Name, callbackInterface.ExtendedAttributes),
                dictionary => Tuple.Create(dictionary.Name, dictionary.ExtendedAttributes),
                callback => Tuple.Create(callback.Name, callback.ExtendedAttributes),
                exception => Tuple.Create(exception.Name, exception.ExtendedAttributes),
                @enum => Tuple.Create(@enum.Name, @enum.ExtendedAttributes),
                declaredInterface => Tuple.Create(declaredInterface.Name, (IReadOnlyList<ExtendedAttribute>)new ExtendedAttribute[0])
            );
            return ParsedExtendedAttributes.Parse(t.Item2, t.Item1, _errors);
        }

        private AstType MakeTypeOptionIfRequired(IReadOnlyList<AstType> options)
        {
            return options.Count > 1 ? MakeType("System.TypeOption", options) : options[0];
        }

        private void AddMembers(IEnumerable<InterfaceMember> source, Dictionary<string, AstType> typeOverrides, string interfaceName, bool noInterfaceObject, IReadOnlyDictionary<string, string> renames, TypeKind typeKind, IReadOnlyList<string> removes, bool addAsInterfaceMembers, List<EntityDeclaration> members)
        {
            Modifiers @public = addAsInterfaceMembers ? Modifiers.None : Modifiers.Public;
            var indexedProperties = new Dictionary<string, IndexedPropertyData>();
            var enumerateAsArrayCandidates = new List<AstType>();

            foreach (var sourceMember in source)
            {
                if (removes.Contains(WebIDLFormatter.FormatSignature(sourceMember)))
                    continue;

                sourceMember.Decompose(
                    @const =>
                    {
                        if (typeKind != TypeKind.Interface)
                        {
                            var memberAttributes = ParsedExtendedAttributes.Parse(@const.ExtendedAttributes, interfaceName + "." + @const.Name, _errors);
                            string name = @const.Name.RemoveLeadingUnderscore();
                            if (ShouldBeIncluded(name, interfaceName, memberAttributes) && !removes.Contains(name))
                            {
                                string csharpName = GetOrDefaultString(renames, name, name.MakeCSharpName());
                                var returnType = ConvertType(@const.Type);
                                if (noInterfaceObject)
                                {
                                    var p = new PropertyDeclaration
                                    {
                                        Modifiers = @public | Modifiers.Extern,
                                        Name = csharpName,
                                        ReturnType = returnType,
                                        Getter = new Accessor() { Body = null }
                                    };
                                    AddAttribute(p.Attributes, FieldPropertyAttribute);
                                    AddAttributes(p.Attributes, NameAttributeIfRequired(csharpName, name));
                                    members.Add(p);
                                }
                                else
                                {
                                    var f = new FieldDeclaration
                                    {
                                        Modifiers = @public | Modifiers.Const,
                                        Variables = { new VariableInitializer { Name = csharpName, Initializer = ConvertValue(@const.Value) } },
                                        ReturnType = returnType
                                    };
                                    AddAttributes(f.Attributes, NameAttributeIfRequired(csharpName, name));
                                    members.Add(f);
                                }
                            }
                        }
                    },
                    operation =>
                    {
                        string operationName = interfaceName + "." + (operation.Name ?? "()");
                        var memberAttributes = ParsedExtendedAttributes.Parse(operation.ExtendedAttributes, operationName, _errors);
                        foreach (var a in operation.Arguments)
                            ParsedExtendedAttributes.Parse(a.ExtendedAttributes, operationName + "(" + a.Name + ")", _errors);
                        string name = operation.Name.RemoveLeadingUnderscore();
                        if (ShouldBeIncluded(name, interfaceName, memberAttributes) && !removes.Contains(name))
                        {
                            if (name != null)
                            {
                                var type = GetOrDefaultAstType(typeOverrides, name, sourceMember, ConvertType(operation.ReturnType));
                                string csharpName = GetOrDefaultString(renames, name, name.MakeCSharpName());
                                foreach (var sig in GetParameterLists(operation.Arguments, typeOverrides, includePartialSignatures: true))
                                {
                                    var returnType = type.Clone();
                                    var m = new MethodDeclaration
                                    {
                                        Modifiers = @public
                                                    | ((operation.Qualifiers & OperationQualifiers.Static) != 0 ? Modifiers.Static : 0)
                                                    | Modifiers.Extern,
                                        Name = csharpName,
                                        ReturnType = returnType,
                                        Body = null
                                    };
                                    AddAttributes(m.Attributes, NameAttributeIfRequired(csharpName, name));
                                    AddAttributes(m.Attributes, ExpandParamsIfRequired(sig));
                                    m.Parameters.AddRange(sig);
                                    members.Add(m);
                                }
                            }
                            else
                            {
                                var type = ConvertType(operation.ReturnType);
                                if ((operation.Qualifiers & OperationQualifiers.LegacyCaller) != 0)
                                {
                                    foreach (var sig in GetParameterLists(operation.Arguments, typeOverrides, includePartialSignatures: true))
                                    {
                                        var returnType = type.Clone();
                                        var m = new MethodDeclaration
                                        {
                                            Modifiers = @public
                                                        | ((operation.Qualifiers & OperationQualifiers.Static) != 0 ? Modifiers.Static : 0)
                                                        | Modifiers.Extern,
                                            Name = "Call",
                                            ReturnType = returnType,
                                            Body = null
                                        };
                                        AddAttribute(m.Attributes, TemplateAttribute("{this}" + MakeInlineCodeParameterList(sig)));
                                        m.Parameters.AddRange(sig);
                                        members.Add(m);
                                    }
                                }
                                else if ((operation.Qualifiers & (OperationQualifiers.Accessor | OperationQualifiers.Stringifier)) == 0)
                                {
                                    _errors.Add("Unnamed operation `" + interfaceName + ".()' is not supported");
                                }
                            }

                            int accessorCount = 0;
                            if ((operation.Qualifiers & (OperationQualifiers.Creator | OperationQualifiers.Setter)) != 0)
                            {
                                if (operation.Arguments.Count != 2)
                                {
                                    _errors.Add("Indexed creator or setter `" + operationName + "' must have exactly 2 arguments");
                                    return;
                                }
                                string indexName = operation.Arguments[0].Name.RemoveLeadingUnderscore();
                                var indexType = GetOrDefaultAstType(typeOverrides, indexName, ConvertType(operation.Arguments[0].Type));
                                string key = indexType.ToString(Formatter.FormattingOptions);
                                var argumentName = operation.Arguments[1].Name.RemoveLeadingUnderscore();
                                var argumentType = GetOrDefaultAstType(typeOverrides, argumentName, ConvertType(operation.Arguments[1].Type));

                                IndexedPropertyData data;
                                if (indexedProperties.TryGetValue(key, out data))
                                {
                                    if (!data.IndexParameterNames.Contains(indexName))
                                        data.IndexParameterNames.Add(indexName);
                                    if (!data.PropertyTypes.Any(t => t.ToString(Formatter.FormattingOptions) == argumentType.ToString(Formatter.FormattingOptions)))
                                        data.PropertyTypes.Add(argumentType);
                                }
                                else
                                    data = indexedProperties[key] = new IndexedPropertyData { IndexParameterNames = { indexName }, IndexParameterType = indexType, PropertyTypes = { argumentType } };
                                data.CanWrite = true;
                                accessorCount++;
                            }
                            if ((operation.Qualifiers & OperationQualifiers.Getter) != 0)
                            {
                                if (operation.Arguments.Count != 1)
                                {
                                    _errors.Add("Indexed getter `" + operationName + "' must have exactly 1 argument");
                                    return;
                                }
                                string indexName = operation.Arguments[0].Name.RemoveLeadingUnderscore();
                                var indexType = GetOrDefaultAstType(typeOverrides, indexName, ConvertType(operation.Arguments[0].Type));
                                string key = indexType.ToString(Formatter.FormattingOptions);
                                var returnType = GetOrDefaultAstType(typeOverrides, name, sourceMember, ConvertType(operation.ReturnType));

                                IndexedPropertyData data;
                                if (indexedProperties.TryGetValue(key, out data))
                                {
                                    if (!data.IndexParameterNames.Contains(indexName))
                                        data.IndexParameterNames.Add(indexName);
                                    if (!data.PropertyTypes.Any(t => t.ToString(Formatter.FormattingOptions) == returnType.ToString(Formatter.FormattingOptions)))
                                        data.PropertyTypes.Add(returnType);
                                }
                                else
                                    data = indexedProperties[key] = new IndexedPropertyData { IndexParameterNames = { indexName }, IndexParameterType = indexType, PropertyTypes = { returnType } };
                                data.CanRead = true;

                                if (IsIntegerType(indexType) && !enumerateAsArrayCandidates.Any(t => t.ToString(Formatter.FormattingOptions) == returnType.ToString(Formatter.FormattingOptions)))
                                    enumerateAsArrayCandidates.Add(returnType);

                                accessorCount++;
                            }
                            if ((operation.Qualifiers & OperationQualifiers.Deleter) != 0)
                            {
                                if (operation.Arguments.Count != 1)
                                {
                                    _errors.Add("Indexed deleter `" + operationName + "' must have exactly 1 argument");
                                    return;
                                }

                                if (name == null)
                                {
                                    string indexName = operation.Arguments[0].Name.RemoveLeadingUnderscore();
                                    var indexType = GetOrDefaultAstType(typeOverrides, indexName, ConvertType(operation.Arguments[0].Type));
                                    var m = new MethodDeclaration
                                    {
                                        Modifiers = @public | Modifiers.Extern,
                                        Name = "Delete",
                                        ReturnType = new PrimitiveType("void"),
                                        Parameters = { new ParameterDeclaration(indexType, indexName) },
                                        Body = null
                                    };
                                    AddAttribute(m.Attributes, TemplateAttribute("delete {this}[{" + indexName + "}]"));
                                    members.Add(m);
                                }

                                accessorCount++;
                            }

                            if (accessorCount > 1)
                                _errors.Add("Invalid accessor combination on `" + operationName + "'");
                        }
                    },
                    attribute =>
                    {
                        var memberAttributes = ParsedExtendedAttributes.Parse(attribute.ExtendedAttributes, interfaceName + "." + attribute.Name, _errors);
                        string name = attribute.Name.RemoveLeadingUnderscore();
                        if (ShouldBeIncluded(name, interfaceName, memberAttributes) && !removes.Contains(name))
                        {
                            string csharpName = GetOrDefaultString(renames, name, name.MakeCSharpName());
                            var attrType = GetOrDefaultAstType(typeOverrides, name, ConvertType(attribute.Type));
                            var p = new PropertyDeclaration
                            {
                                Modifiers = @public
                                        | ((attribute.Qualifiers & AttributeQualifiers.Static) != 0 ? Modifiers.Static : 0)
                                        | Modifiers.Extern,
                                Name = csharpName,
                                ReturnType = attrType,
                                Getter = new Accessor { Body = null },
                                Setter = (attribute.Qualifiers & AttributeQualifiers.ReadOnly) != 0 ? Accessor.Null : new Accessor { Body = null },
                            };

                            AddAttribute(p.Attributes, FieldPropertyAttribute);
                            AddAttributes(p.Attributes, NameAttributeIfRequired(csharpName, name));
                            members.Add(p);
                        }
                    },
                    jsonifier =>
                    {
                        ParsedExtendedAttributes.Parse(jsonifier.ExtendedAttributes, interfaceName + ".jsonifier", _errors);
                    }
                );
            }

            foreach (var p in indexedProperties.Values)
            {
                if (p.IndexParameterNames.Count > 1)
                    _errors.Add("Ambiguous parameter name in indexer `" + interfaceName + "[" + p.IndexParameterType.ToString(Formatter.FormattingOptions) + "] (candidate names are " + string.Join(", ", p.IndexParameterNames.Select(n => "`" + n + "'")) + ")");
                var propertyType = MakeTypeOptionIfRequired(p.PropertyTypes);
                var i = new IndexerDeclaration
                {
                    Modifiers = Modifiers.Public,
                    ReturnType = propertyType,
                    Parameters = { new ParameterDeclaration(p.IndexParameterType, p.IndexParameterNames[0]) },
                    Getter = p.CanRead ? new Accessor { Body = null } : null,
                    Setter = p.CanWrite ? new Accessor { Body = null } : null,
                };
                AddAttribute(i.Attributes, IndexerNameAttribute("__Item"));
                AddAttribute(i.Attributes, FieldPropertyAttribute);
                members.Add(i);
            }

            if (enumerateAsArrayCandidates.Count > 0 && HasIntegerLength(members))
            {
                var arrayType = MakeTypeOptionIfRequired(enumerateAsArrayCandidates);
                var m = new MethodDeclaration
                {
                    Modifiers = Modifiers.Public | Modifiers.Extern,
                    Name = "GetEnumerator",
                    ReturnType = MakeType("System.Collections.Generic.IEnumerator", new[] { arrayType.Clone() }),
                    //Body = new BlockStatement { Statements = { new ReturnStatement(new NullReferenceExpression()) } }
                };
                AddAttribute(m.Attributes, EnumerateAsArrayAttribute);
                AddAttribute(m.Attributes, TemplateAttribute("new {$System.ArrayEnumerator}({this})"));
                members.Add(m);
            }
        }

        private void AddMembers(IEnumerable<DictionaryMember> source, Dictionary<string, AstType> typeOverrides, string dictionaryName, IReadOnlyDictionary<string, string> renames, IReadOnlyList<string> removes, List<EntityDeclaration> members)
        {
            foreach (var sourceMember in source)
            {
                var memberAttributes = ParsedExtendedAttributes.Parse(sourceMember.ExtendedAttributes, dictionaryName + "." + sourceMember.Name, _errors);
                string name = sourceMember.Name.RemoveLeadingUnderscore();
                if (ShouldBeIncluded(name, dictionaryName, memberAttributes) && !removes.Contains(name))
                {
                    string csharpName = GetOrDefaultString(renames, name, name.MakeCSharpName());
                    var type = GetOrDefaultAstType(typeOverrides, name, ConvertType(sourceMember.Type));
                    var p = new PropertyDeclaration
                    {
                        Modifiers = Modifiers.Public | Modifiers.Extern,
                        Name = csharpName,
                        ReturnType = type,
                        Getter = new Accessor(),
                        Setter = new Accessor(),
                    };
                    AddAttributes(p.Attributes, NameAttributeIfRequired(csharpName, name));
                    members.Add(p);
                }
            }
        }

        private IEnumerable<string> GetMembersToAddFromBaseTypes(IEnumerable<string> bases)
        {
            var result = new List<string>();
            foreach (var b in bases.Where(b => b != null))
            {
                var baseMeta = _metadata.Types[b];
                foreach (var a in baseMeta.AddInDerivedTypes)
                    result.Add(a);
                var baseBases = _types[b].DecomposeWithResult(
                    @interface => new[] { @interface.Base }.Concat(@interface.Implements),
                    callbackInterface => new[] { callbackInterface.Base },
                    dictionary => new[] { dictionary.Base },
                    callback => null,
                    exception => new[] { exception.Base },
                    @enum => null,
                    declaredInterface => null
                );
                if (baseBases != null)
                    result.AddRange(GetMembersToAddFromBaseTypes(baseBases));
            }
            return result.Distinct();
        }

        private void AddMembersFromBaseTypes(string currentTypeName, IEnumerable<string> toAdd, IList<EntityDeclaration> members)
        {
            foreach (var s in toAdd)
            {
                var ast = new CSharpParser().ParseTypeMembers(s.Replace("$type$", currentTypeName)).Single();
                ast.Modifiers |= Modifiers.Public | Modifiers.Extern;
                //if (ast is MethodDeclaration)
                //{
                //    ((MethodDeclaration)ast).Body = GenerateBody(((MethodDeclaration)ast).ReturnType);
                //}
                members.Add(ast);
            }
        }

        private NamespacedEntityDeclaration ConvertTypeDefinition(ResolvedDefinition type, bool returnNonGenerated, bool addInsertedMembersFromBaseTypes)
        {
            NamespacedEntityDeclaration result = null;
            type.Decompose(
                @interface =>
                {
                    var parsedAttributes = ParsedExtendedAttributes.Parse(@interface.ExtendedAttributes, @interface.Name, _errors);
                    if (!parsedAttributes.ChromeOnly)
                    {
                        var meta = _metadata.Types[@interface.Name];
                        if (!meta.Generate && !returnNonGenerated)
                            return;
                        var typeOverrides = meta.TypeOverrides.ToDictionary(t => t.Identifier, t => t.NewType);

                        var members = new List<EntityDeclaration>();
                        if (meta.IncludeConstructors && meta.TypeKind != TypeKind.Interface)
                            AddConstructors(parsedAttributes, typeOverrides, members);
                        AddMembers(@interface.Members, typeOverrides, @interface.Name, parsedAttributes.NoInterfaceObject, meta.Renames, meta.TypeKind, meta.Removes, meta.TypeKind == TypeKind.Interface, members);

                        string scriptName;
                        var attributes = new List<Attribute> { IgnoreNamespaceAttribute };
                        if (meta.TagNames.Count > 0)
                        {
                            string typeCheckCode = "{$System.Script}.isInstanceOfType({this}, Element) && " + (meta.TagNames.Count > 1 ? "(" : "") + string.Join(" || ", meta.TagNames.Select(t => "{this}.tagName === '" + t.ToUpperInvariant() + "'")) + (meta.TagNames.Count > 1 ? ")" : "");
                            attributes.Add(ExternalAttribute(false, typeCheckCode));
                            scriptName = "Element";
                        }
                        else
                        {
                            attributes.Add(ExternalAttribute(meta.TypeKind != TypeKind.Interface));
                            scriptName = GetClosestInterfaceObjectName(type);
                        }

                        var baseTypes = (@interface.Base != null ? new[] { @interface.Base } : new string[0]).Concat(@interface.Implements).Select(
                            b =>
                            {
                                var baseMeta = _metadata.Types[b];
                                if (!baseMeta.Inherit)
                                    return null;
                                if (!ParseExtendedAttributes(_types[b]).ChromeOnly)
                                {
                                    if ((b != @interface.Base || baseMeta.TypeKind == TypeKind.Mixin) && baseMeta.TypeKind != TypeKind.Skip)
                                    {
                                        if (baseMeta.TypeKind == TypeKind.Default)
                                            _errors.Add("The type `" + b + "' cannot be implemented by the type `" + @interface.Name + "' because the implemented type is not a C# interface");
                                        _types[b].Decompose(
                                            @interface2 => AddMembers(@interface2.Members, baseMeta.TypeOverrides.ToDictionary(o => o.Identifier, o => o.NewType), b, parsedAttributes.NoInterfaceObject, baseMeta.Renames, baseMeta.TypeKind, baseMeta.Removes, false, members),
                                            callbackInterface => { _errors.Add("Base type `" + b + "' of type `" + @interface.Name + " was a callback interface, not an interface"); },
                                            dictionary => { _errors.Add("Base type `" + b + "' of type `" + @interface.Name + " was a dictionary, not an interface"); },
                                            @callback => { _errors.Add("Base type `" + b + "' of type `" + @interface.Name + " was a callback, not an interface"); },
                                            @exception => { _errors.Add("Base type `" + b + "' of type `" + @interface.Name + " was an exception, not an interface"); },
                                            @enum => { _errors.Add("Base type `" + b + "' of type `" + @interface.Name + " was an enum, not an interface"); },
                                            declaredInterface => _errors.Add("The type `" + b + "' cannot be implemented by the type `" + @interface.Name + "' because the implemented type is not defined")
                                        );
                                    }
                                    if (baseMeta.TypeKind == TypeKind.Mixin || baseMeta.TypeKind == TypeKind.Skip)
                                        return null;
                                    AstType alias = baseMeta.AliasFor ?? MakeType((!string.IsNullOrEmpty(baseMeta.Namespace) ? baseMeta.Namespace + "." : "") + baseMeta.CSharpName);
                                    if (b == @interface.Base)
                                        alias = GetOrDefaultAstType(typeOverrides, "base", alias);

                                    return alias;
                                }
                                else
                                    return null;
                            })
                            .Where(x => x != null);

                        if (meta.TypeKind == TypeKind.Default && meta.CSharpName != scriptName)
                            attributes.Add(NameAttribute(scriptName));
                        if (addInsertedMembersFromBaseTypes)
                            AddMembersFromBaseTypes(meta.Namespace + "." + meta.CSharpName, GetMembersToAddFromBaseTypes(new[] { @interface.Base }.Concat(@interface.Implements)), members);

                        var resultType = new TypeDeclaration
                        {
                            ClassType = meta.TypeKind == TypeKind.Interface ? ClassType.Interface : ClassType.Class,
                            Modifiers = Modifiers.Public | Modifiers.Partial,
                            Name = meta.CSharpName,
                        };
                        resultType.BaseTypes.AddRange(baseTypes.Select(t => t.Clone()));
                        resultType.Members.AddRange(members.OrderBy(MemberOrderer));
                        AddAttributes(resultType.Attributes, attributes);
                        result = new NamespacedEntityDeclaration(meta.Namespace, resultType);
                    }
                },
                callbackInterface =>
                {
                    var parsedAttributes = ParsedExtendedAttributes.Parse(callbackInterface.ExtendedAttributes, callbackInterface.Name, _errors);
                    if (!parsedAttributes.ChromeOnly)
                    {
                        var meta = _metadata.Types[callbackInterface.Name];
                        if (!meta.Generate && !returnNonGenerated)
                            return;
                        var typeOverrides = meta.TypeOverrides.ToDictionary(t => t.Identifier, t => t.NewType);

                        var members = new List<EntityDeclaration>();
                        AddMembers(callbackInterface.Members, typeOverrides, callbackInterface.Name, true, meta.Renames, TypeKind.Interface, meta.Removes, true, members);

                        var baseTypes = new AstType[0];
                        if (callbackInterface.Base != null)
                        {
                            var baseMeta = _metadata.Types[callbackInterface.Base];
                            if (baseMeta.Inherit)
                                baseTypes = new[] { baseMeta.AliasFor ?? MakeType((!string.IsNullOrEmpty(baseMeta.Namespace) ? baseMeta.Namespace + "." : "") + baseMeta.CSharpName) };
                        }
                        if (addInsertedMembersFromBaseTypes)
                            AddMembersFromBaseTypes(meta.Namespace + "." + meta.CSharpName, GetMembersToAddFromBaseTypes(new[] { callbackInterface.Base }), members);

                        var resultType = new TypeDeclaration
                        {
                            ClassType = ClassType.Interface,
                            Modifiers = Modifiers.Public | Modifiers.Partial,
                            Name = meta.CSharpName,
                        };
                        resultType.BaseTypes.AddRange(baseTypes);
                        resultType.Members.AddRange(members.OrderBy(MemberOrderer));
                        AddAttribute(resultType.Attributes, ExternalAttribute(false));
                        result = new NamespacedEntityDeclaration(meta.Namespace, resultType);
                    }
                },
                dictionary =>
                {
                    var parsedAttributes = ParsedExtendedAttributes.Parse(dictionary.ExtendedAttributes, dictionary.Name, _errors);
                    if (!parsedAttributes.ChromeOnly)
                    {
                        var meta = _metadata.Types[dictionary.Name];
                        if (!meta.Generate && !returnNonGenerated)
                            return;
                        var typeOverrides = meta.TypeOverrides.ToDictionary(t => t.Identifier, t => t.NewType);

                        var members = new List<EntityDeclaration>();
                        AddMembers(dictionary.Members, typeOverrides, dictionary.Name, meta.Renames, meta.Removes, members);

                        var baseTypes = new AstType[0];
                        if (dictionary.Base != null)
                        {
                            var baseMeta = _metadata.Types[dictionary.Base];
                            if (baseMeta.Inherit)
                                baseTypes = new[] { baseMeta.AliasFor ?? MakeType((!string.IsNullOrEmpty(baseMeta.Namespace) ? baseMeta.Namespace + "." : "") + baseMeta.CSharpName) };
                        }
                        if (addInsertedMembersFromBaseTypes)
                            AddMembersFromBaseTypes(meta.Namespace + "." + meta.CSharpName, GetMembersToAddFromBaseTypes(new[] { dictionary.Base }), members);

                        var resultType = new TypeDeclaration
                        {
                            ClassType = ClassType.Class,
                            Modifiers = Modifiers.Public | Modifiers.Partial,
                            Name = meta.CSharpName,
                        };
                        resultType.BaseTypes.AddRange(baseTypes);
                        resultType.Members.AddRange(members.OrderBy(MemberOrderer));
                        AddAttribute(resultType.Attributes, ExternalAttribute(false));
                        AddAttribute(resultType.Attributes, SerializableAttribute);
                        result = new NamespacedEntityDeclaration(meta.Namespace, resultType);
                    }
                },
                callback =>
                {
                    var parsedAttributes = ParsedExtendedAttributes.Parse(callback.ExtendedAttributes, callback.Name, _errors);
                    if (!ShouldBeIncluded(callback.Name, null, parsedAttributes))
                        return;
                    var meta = _metadata.Types[callback.Name];
                    if (!meta.Generate && !returnNonGenerated)
                        return;
                    var typeOverrides = meta.TypeOverrides.ToDictionary(t => t.Identifier, t => t.NewType);

                    foreach (var a in callback.Arguments)
                    {
                        ParsedExtendedAttributes.Parse(a.ExtendedAttributes, callback.Name + "(" + a.Name + ")", _errors);
                    }
                    var sig = GetParameterLists(callback.Arguments, typeOverrides, includePartialSignatures: false).SingleOrDefault();
                    if (sig != null)
                    {
                        var d = new DelegateDeclaration
                        {
                            Modifiers = Modifiers.Public,
                            ReturnType = ConvertType(callback.ReturnType),
                            Name = meta.CSharpName,
                        };
                        d.Parameters.AddRange(sig);
                        AddAttributes(d.Attributes, ExpandParamsIfRequired(sig));
                        result = new NamespacedEntityDeclaration(meta.Namespace, d);
                    }
                    else
                        _errors.Add("No signature could be generated for the callback `" + callback.Name + "'");
                },
                exception =>
                {
                    ParsedExtendedAttributes.Parse(exception.ExtendedAttributes, exception.Name, _errors);
                    foreach (var member in exception.Members)
                    {
                        member.Decompose(
                            @const =>
                            {
                                ParsedExtendedAttributes.Parse(@const.ExtendedAttributes, exception.Name + "." + @const.Name, _errors);
                            },
                            field =>
                            {
                                ParsedExtendedAttributes.Parse(field.ExtendedAttributes, exception.Name + "." + field.Name, _errors);
                            }
                        );
                    }
                    _errors.Add("Exception `" + exception.Name + "' not yet supported");
                },
                @enum =>
                {
                    ParsedExtendedAttributes.Parse(@enum.ExtendedAttributes, @enum.Name, _errors);
                    var meta = _metadata.Types[@enum.Name];
                    if (!meta.Generate && !returnNonGenerated)
                        return;
                    var t = new TypeDeclaration
                    {
                        Modifiers = Modifiers.Public,
                        ClassType = ClassType.Enum,
                        Name = meta.CSharpName,
                    };
                    t.Members.AddRange(@enum.Values.Where(v => ShouldBeIncluded(v, @enum.Name, null))
                                                   .Select(v =>
                                                   {
                                                       string csharpName = GetOrDefaultString(meta.Renames, v, v.MakeCSharpName());
                                                       var e = new EnumMemberDeclaration { Name = csharpName };
                                                       AddAttributes(e.Attributes, NameAttributeIfRequired(csharpName, v));
                                                       return e;
                                                   }));
                    AddAttribute(t.Attributes, ExternalAttribute(false));
                    AddAttribute(t.Attributes, NamedValuesAttribute);
                    result = new NamespacedEntityDeclaration(meta.Namespace, t);
                },
                declaredInterface =>
                {
                    var meta = _metadata.Types[declaredInterface.Name];
                    if (meta.Generate || returnNonGenerated)
                        _errors.Add("Undefined interface `" + declaredInterface.Name + "'");
                }
            );
            return result;
        }

        private void BuildCSharpModel()
        {
            foreach (var type in _types.Values)
            {
                var t = ConvertTypeDefinition(type, returnNonGenerated: false, addInsertedMembersFromBaseTypes: true);
                if (t != null)
                    _result.Add(t);
            }
        }

        private void GenerateEnum(string enumNamespace, string enumName, GeneratedEnumSourceType type, Regex membersRegex, IReadOnlyDictionary<string, string> names, bool flags, IEnumerable<InterfaceMember> members, Regex valueRegex)
        {
            string enumQualifiedName = enumNamespace + "." + enumName;
            var enumMembers = new List<EnumMemberDeclaration>();
            foreach (var m in members)
            {
                m.Decompose(
                    @const =>
                    {
                        if (type != GeneratedEnumSourceType.Constants)
                            return;

                        var match = membersRegex.Match(@const.Name);
                        if (match.Success)
                        {
                            if (match.Groups.Count != 2)
                            {
                                _errors.Add("The regular expression used to generate the enum `" + enumQualifiedName + "' does not have one capture group");
                                return;
                            }
                            string raw = match.Groups[1].Value;
                            string name = GetOrDefaultString(names, raw, raw.ConstantCaseToPascalCase());

                            @const.Value.Decompose(
                                @int => enumMembers.Add(new EnumMemberDeclaration { Name = name, Initializer = new PrimitiveExpression(@int, @int.ToString(CultureInfo.InvariantCulture)) }),
                                @double => _errors.Add("The constant `" + @const.Name + "', required by the enum `" + enumQualifiedName + "' is not an integer"),
                                @string => _errors.Add("The constant `" + @const.Name + "', required by the enum `" + enumQualifiedName + "' is not an integer"),
                                special => _errors.Add("The constant `" + @const.Name + "', required by the enum `" + enumQualifiedName + "' is not an integer")
                            );
                        }
                    },
                    operation => { },
                    attribute =>
                    {
                        if (type != GeneratedEnumSourceType.Attributes)
                            return;

                        var match = membersRegex.Match(attribute.Name);
                        if (match.Success)
                        {
                            if (match.Groups.Count != 2)
                            {
                                _errors.Add("The regular expression used to generate the enum `" + enumQualifiedName + "' does not have one capture group");
                                return;
                            }
                            string raw = match.Groups[1].Value;
                            string name = GetOrDefaultString(names, raw, raw.MakeCSharpName());

                            var value = valueRegex.Match(attribute.Name);
                            if (!match.Success)
                            {
                                _errors.Add("The regular expression used for the values of the enum `" + enumQualifiedName + "' does not match the value " + attribute.Name);
                                return;
                            }
                            if (match.Groups.Count != 2)
                            {
                                _errors.Add("The regular expression used for the values of the enum `" + enumQualifiedName + "' does not have one capture group");
                                return;
                            }

                            var enm = new EnumMemberDeclaration { Name = name };
                            AddAttributes(enm.Attributes, NameAttributeIfRequired(name, value.Groups[1].Value));
                            enumMembers.Add(enm);
                        }
                    },
                    jsonifier => { }
                );
            }

            var attributes = new List<Attribute> { ExternalAttribute(false) };
            if (flags)
                attributes.Add(FlagsAttribute);
            if (type == GeneratedEnumSourceType.Attributes)
                attributes.Add(NamedValuesAttribute);

            var t = new TypeDeclaration
            {
                ClassType = ClassType.Enum,
                Modifiers = Modifiers.Public,
                Name = enumName
            };
            AddAttributes(t.Attributes, attributes);
            t.Members.AddRange(enumMembers.OrderBy(m => m.Name));
            _result.Add(new NamespacedEntityDeclaration(enumNamespace, t));
        }

        private void GenerateEnums(string typeNamespace, string typeName, string currentType, bool isDerived, IReadOnlyList<InterfaceMember> members)
        {
            var meta = _metadata.Types[currentType];
            foreach (var ge in meta.GeneratedEnums)
            {
                if (ge.GenerateInDerivedTypes == isDerived)
                {
                    string enumNamespace = !string.IsNullOrEmpty(ge.EnumNamespace) ? ge.EnumNamespace : typeNamespace;
                    string enumName = ge.EnumName.Replace("$type$", typeName);

                    if (members != null)
                    {
                        GenerateEnum(enumNamespace, enumName, ge.SourceType, ge.MembersRegex, ge.Names, ge.Flags, members, ge.ValueRegex);
                    }
                    else
                    {
                        _errors.Add("Cannot generate an enum from the non-interface type `" + typeName + "'");
                    }
                }
            }

            var bases = _types[currentType].DecomposeWithResult(
                @interface => @interface.Base != null ? new[] { @interface.Base }.Concat(@interface.Implements) : @interface.Implements,
                callbackInterface => callbackInterface.Base != null ? new[] { callbackInterface.Base } : new string[0],
                dictionary => new string[0],
                callback => new string[0],
                exception => new string[0],
                @enum => new string[0],
                declaredInterface => new string[0]
            );

            if (isDerived || meta.Generate)
            {   // We do not want to generate enums inherited by types that are not themselves generated
                foreach (var b in bases)
                {
                    GenerateEnums(typeNamespace, typeName, b, true, members);
                }
            }
        }

        private void GenerateEnums()
        {
            foreach (var type in _types)
            {
                var meta = _metadata.Types[type.Key];

                var toProcess = new List<string> { type.Key };
                var members = new List<InterfaceMember>();
                while (toProcess.Count > 0)
                {
                    var t = toProcess[toProcess.Count - 1];
                    toProcess.RemoveAt(toProcess.Count - 1);
                    _types[t].Decompose(
                        @interface => { members.AddRange(@interface.Members); if (@interface.Base != null) toProcess.Add(@interface.Base); toProcess.AddRange(@interface.Implements); },
                        callbackInterface => { members.AddRange(callbackInterface.Members); if (callbackInterface.Base != null) toProcess.Add(callbackInterface.Base); },
                        dictionary => { },
                        callback => { },
                        exception => { },
                        @enum => { },
                        declaredInterface => { }
                    );
                }
                GenerateEnums(meta.Namespace, meta.CSharpName, type.Key, false, members);
            }
        }

        public void GenerateStaticInstances()
        {
            foreach (var meta in _metadata.StaticInstances)
            {
                string qualifiedName = meta.ClassNamespace + "." + meta.ClassName;
                bool continueLoop = false;
                string currentName = meta.TypeName;

                var members = new List<EntityDeclaration>();

                do
                {
                    ResolvedDefinition def;
                    if (!_types.TryGetValue(currentName, out def))
                    {
                        _errors.Add("Could not find the type (or base type) `" + currentName + "' for the static instance `" + qualifiedName + "'");
                        break;
                    }

                    def.Decompose(
                        @interface =>
                        {
                            var interfaceMeta = _metadata.Types[@interface.Name];
                            var namespacedDeclaration = _result.FirstOrDefault(d => d.Namespace == interfaceMeta.Namespace && d.EntityDeclaration.Name == interfaceMeta.CSharpName);
                            EntityDeclaration csType;
                            if (namespacedDeclaration != null)
                            {
                                csType = namespacedDeclaration.EntityDeclaration;
                            }
                            else
                            {
                                csType = ConvertTypeDefinition(_types[@interface.Name], returnNonGenerated: true, addInsertedMembersFromBaseTypes: false).EntityDeclaration;
                                if (csType == null)
                                {
                                    _errors.Add("The type (or base type) `" + currentName + "' for the static instance `" + qualifiedName + "' was not generated");
                                    return;
                                }
                            }

                            var typeDeclaration = csType as TypeDeclaration;
                            if (typeDeclaration != null)
                            {
                                members.AddRange(typeDeclaration.Members.Where(m => m is MethodDeclaration || m is PropertyDeclaration || m is FieldDeclaration)
                                                                        .Select(m => { var x = (EntityDeclaration)m.Clone(); if ((x.Modifiers & Modifiers.Const) == 0) x.Modifiers |= Modifiers.Static; return x; }));
                            }
                            else
                            {
                                _errors.Add("The type `" + currentName + "' for the static instance `" + qualifiedName + "' was not generated as a class");
                            }

                            currentName = @interface.Base;
                            continueLoop = currentName != null;
                        },
                        callbackInterface => _errors.Add("The type (or base type) `" + currentName + "' for the static instance `" + qualifiedName + "' is not an interface"),
                        dictionary => _errors.Add("The type (or base type) `" + currentName + "' for the static instance `" + qualifiedName + "' is not an interface"),
                        callback => _errors.Add("The type (or base type) `" + currentName + "' for the static instance `" + qualifiedName + "' is not an interface"),
                        exception => _errors.Add("The type (or base type) `" + currentName + "' for the static instance `" + qualifiedName + "' is not an interface"),
                        @enum => _errors.Add("The type (or base type) `" + currentName + "' for the static instance `" + qualifiedName + "' is not an interface"),
                        declaredInterface => _errors.Add("The type (or base type) `" + currentName + "' for the static instance `" + qualifiedName + "' does not have a definition")
                    );
                } while (continueLoop);

                var c = new TypeDeclaration
                {
                    Modifiers = Modifiers.Public | Modifiers.Static | Modifiers.Partial,
                    ClassType = ClassType.Class,
                    Name = meta.ClassName,
                };
                members.RemoveAll(m => meta.Removes.Contains(m.Name));
                c.Members.AddRange(members.OrderBy(MemberOrderer));
                if (meta.GlobalMethods)
                    AddAttributes(c.Attributes, new[] { ExternalAttribute(false), GlobalMethodsAttribute });
                else
                    AddAttributes(c.Attributes, new[] { IgnoreNamespaceAttribute, ExternalAttribute(false), NameAttribute(meta.InstanceName) });

                _result.Add(new NamespacedEntityDeclaration(meta.ClassNamespace, c));
            }
        }

        private void MatchMetadataAndTypes()
        {
            _errors.AddRange(_types.Keys.Except(_metadata.Types.Keys).Select(missing => string.Format("Missing metadata for the type `{0}", missing)));
            _errors.AddRange(_metadata.Types.Keys.Except(_types.Keys).Select(extra => string.Format("Metadata for non-existent type `{0}", extra)));
        }

        public static Tuple<IReadOnlyList<NamespacedEntityDeclaration>, IReadOnlyList<string>> BuildCSharpModel(Dictionary<string, ResolvedDefinition> types, Metadata metadata)
        {
            var c = new Converter(types, metadata);
            c.MatchMetadataAndTypes();
            if (c._errors.Count == 0)
            {
                c.BuildCSharpModel();
                c.GenerateEnums();
                c.GenerateStaticInstances();
            }
            return Tuple.Create<IReadOnlyList<NamespacedEntityDeclaration>, IReadOnlyList<string>>(c._result, c._errors);
        }
    }
}
