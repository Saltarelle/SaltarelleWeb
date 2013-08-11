using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using Generator.AstNodes;
using Generator.ExtensionMethods;
using Generator.Meta;

#warning TODO: Handle EventTarget<TSelf> somehow
#warning TODO: Event string names

namespace Generator {
	public class Converter {
		private class ParsedExtendedAttributes {
			public enum TreatUndefinedAsOptions {
				Default,
				EmptyString,
				Null,
				Missing,
			}

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
			public TreatUndefinedAsOptions TreatUndefinedAs { get; private set; }
			public IReadOnlyList<IReadOnlyList<Argument>> Constructors { get; private set; }
			public IReadOnlyList<Tuple<string, IReadOnlyList<Argument>>> NamedConstructors { get; private set; }

			private ParsedExtendedAttributes() {
			}

			private static string GetString(Value value) {
				return value.DecomposeWithResult(
					@int => null,
					@double => null,
					@string => @string,
					special => null
				);
			}

			public static ParsedExtendedAttributes Parse(IEnumerable<ExtendedAttribute> attributes, string scopeName, List<string> errors) {
				var result = new ParsedExtendedAttributes();
				var constructors = new List<IReadOnlyList<Argument>>();
				var namedConstructors = new List<Tuple<string, IReadOnlyList<Argument>>>();

				foreach (var attr in attributes) {
					attr.Decompose(
						noArgs => {
							switch (noArgs.AttributeName) {
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
								default:
									errors.Add(string.Format("Unknown ExtendedAttributeNoArgs `{0}' on `{1}'", noArgs.AttributeName, scopeName));
									break;
							}
						},
						argList => {
							switch (argList.AttributeName) {
								case "Constructor":
									constructors.Add(argList.Arguments);
									break;
								default:
									errors.Add(string.Format("Unknown ExtendedAttributeArgList `{0}' on `{1}'", argList.AttributeName, scopeName));
									break;
							}
						},
						namedArgList => {
							switch (namedArgList.AttributeName) {
								case "NamedConstructor":
									namedConstructors.Add(Tuple.Create(namedArgList.ArgListName, namedArgList.Arguments));
									break;
								default:
									errors.Add(string.Format("Unknown ExtendedAttributeNamedArgList `{0}' on `{1}'", namedArgList.AttributeName, scopeName));
									break;
							}
						},
						ident => {
							switch (ident.AttributeName) {
								case "NamedConstructor":
									namedConstructors.Add(Tuple.Create(ident.Ident, (IReadOnlyList<Argument>)new Argument[0]));
									break;
								case "TreatNullAs":
									if (ident.Ident != "EmptyString")
										errors.Add(string.Format("Expecting `EmptyString' as the value for the attribute TreatNullAs on  `{0}' (value was `{1}')", scopeName, ident.Ident));
									result.TreatNullAsEmptyString = true;
									break;
								case "TreatUndefinedAs":
									switch (ident.Ident) {
										case "EmptyString": result.TreatUndefinedAs = TreatUndefinedAsOptions.EmptyString; break;
										case "Null":        result.TreatUndefinedAs = TreatUndefinedAsOptions.Null;        break;
										case "Missing":     result.TreatUndefinedAs = TreatUndefinedAsOptions.Missing;     break;
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
						value => {
							switch (value.AttributeName) {
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

				return result;
			}
		}

		private readonly Dictionary<string, ResolvedDefinition> _types;
		private readonly Metadata _metadata;
		private readonly List<string> _errors = new List<string>();
		private readonly List<CSharp.TypeDefinition> _result = new List<CSharp.TypeDefinition>();

		private Converter(Dictionary<string, ResolvedDefinition> types, Metadata metadata) {
			_types = types;
			_metadata = metadata;
		}

		private static readonly CSharp.Attribute IntrinsicPropertyAttribute = CSharp.Attribute.Create("IntrinsicProperty", "System.Runtime.CompilerServices", new string[0], new Tuple<string, string>[0]);

		private static readonly CSharp.Attribute EnumerateAsArrayAttribute = CSharp.Attribute.Create("EnumerateAsArray", "System.Runtime.CompilerServices", new string[0], new Tuple<string, string>[0]);

		private static readonly CSharp.Attribute IgnoreNamespaceAttribute = CSharp.Attribute.Create("IgnoreNamespace", "System.Runtime.CompilerServices", new string[0], new Tuple<string, string>[0]);

		private static readonly CSharp.Attribute NamedValuesAttribute = CSharp.Attribute.Create("NamedValues", "System.Runtime.CompilerServices", new string[0], new Tuple<string, string>[0]);

		private static readonly CSharp.Attribute SerializableAttribute = CSharp.Attribute.Create("Serializable", "System.Runtime.CompilerServices", new string[0], new Tuple<string, string>[0]);

		private static readonly CSharp.Attribute GlobalMethodsAttribute = CSharp.Attribute.Create("GlobalMethods", "System.Runtime.CompilerServices", new string[0], new Tuple<string, string>[0]);

		private static readonly CSharp.Attribute FlagsAttribute = CSharp.Attribute.Create("Flags", "System", new string[0], new Tuple<string, string>[0]);

		private static CSharp.Attribute InlineCodeAttribute(string code) {
			return CSharp.Attribute.Create("InlineCode", "System.Runtime.CompilerServices", new[] { "\"" + code + "\"" }, new Tuple<string, string>[0]);
		}

		private CSharp.Attribute ScriptNameAttribute(string name) {
			return CSharp.Attribute.Create("ScriptName", "System.Runtime.CompilerServices", new[] { "\"" + name + "\"" }, new Tuple<string, string>[0]);
		}

		private IEnumerable<CSharp.Attribute> ScriptNameAttributeIfRequired(string csharpName, string name) {
			if (name.MakeCSharpName().MakeCamelCase() != name)
				yield return ScriptNameAttribute(name);
		}

		private IEnumerable<CSharp.Attribute> ExpandParamsIfRequired(IEnumerable<CSharp.Parameter> parameters) {
			if (parameters.Any(p => p.IsParams))
				return new[] { CSharp.Attribute.Create("ExpandParams", "System.Runtime.CompilerServices", new string[0], new Tuple<string, string>[0]) };
			else
				return new CSharp.Attribute[0];
		}

		private static CSharp.Attribute ImportedAttribute(bool obeysTypeSystem, string typeCheckCode = null) {
			var namedArgs = new List<Tuple<string, string>>();
			if (obeysTypeSystem)
				namedArgs.Add(Tuple.Create("ObeysTypeSystem", "true"));
			if (typeCheckCode != null)
				namedArgs.Add(Tuple.Create("TypeCheckCode", "\"" + typeCheckCode + "\""));
			return CSharp.Attribute.Create("Imported", "System.Runtime.CompilerServices", new string[0], namedArgs);
		}

		private static CSharp.Attribute IndexerNameAttribute(string name) {
			return CSharp.Attribute.Create("IndexerName", "System.Runtime.CompilerServices", new[] { "\"" + name + "\"" }, new Tuple<string, string>[0]);
		}

		private static TValue GetOrDefault<TKey, TValue>(IReadOnlyDictionary<TKey, TValue> dict, TKey key, TValue def) {
			TValue result;
			if (!dict.TryGetValue(key, out result))
				result = def;
			return result;
		}

		private static CSharp.TypeReference GetOrDefault(IReadOnlyDictionary<string, CSharp.TypeReference> dict, string name, InterfaceMember member, CSharp.TypeReference def) {
			CSharp.TypeReference result;
			if (name != null && dict.TryGetValue(name, out result))
				return result;
			if (dict.TryGetValue(WebIDLFormatter.FormatSignature(member), out result))
				return result;
			return def;
		}

		private CSharp.TypeReference ConvertType(WebIDLType type) {
			return type.DecomposeWithResult(
				builtin => {
					switch (builtin.BuiltinType) {
						case BuiltinType.Any:                return CSharp.TypeReference.Keyword("object");
						case BuiltinType.DOMString:          return CSharp.TypeReference.Keyword("string");
						case BuiltinType.Object:             return CSharp.TypeReference.Keyword("object");
						case BuiltinType.Date:               return CSharp.TypeReference.NamedType("DateTime", "System");
						case BuiltinType.Boolean:            return CSharp.TypeReference.Keyword("bool");
						case BuiltinType.Byte:               return CSharp.TypeReference.Keyword("sbyte");
						case BuiltinType.Octet:              return CSharp.TypeReference.Keyword("byte");
						case BuiltinType.Float:              return CSharp.TypeReference.Keyword("float");
						case BuiltinType.UnrestrictedFloat:  return CSharp.TypeReference.Keyword("float");
						case BuiltinType.Double:             return CSharp.TypeReference.Keyword("double");
						case BuiltinType.UnrestrictedDouble: return CSharp.TypeReference.Keyword("double");
						case BuiltinType.Short:              return CSharp.TypeReference.Keyword("short");
						case BuiltinType.UnsignedShort:      return CSharp.TypeReference.Keyword("ushort");
						case BuiltinType.Long:               return CSharp.TypeReference.Keyword("int");
						case BuiltinType.UnsignedLong:       return CSharp.TypeReference.Keyword("uint");
						case BuiltinType.LongLong:           return CSharp.TypeReference.Keyword("long");
						case BuiltinType.UnsignedLongLong:   return CSharp.TypeReference.Keyword("ulong");
						default: throw new ArgumentException("Invalid builtin type " + builtin.BuiltinType);
					}
				},
				@void => CSharp.TypeReference.Keyword("void"),
				@union => CSharp.TypeReference.GenericNamedType("TypeOption", "System", @union.Members.Select(ConvertType)),
				typeReference => {
					var meta = _metadata.Types[typeReference.Target];
					return meta.AliasFor ?? CSharp.TypeReference.NamedType(meta.CSharpName, meta.Namespace);
				},
				array => CSharp.TypeReference.Array(ConvertType(array.ElementType)),
				sequence => CSharp.TypeReference.Array(ConvertType(sequence.ElementType)),
				nullable => {
					bool underlyingIsNullable = nullable.UnderlyingType.DecomposeWithResult(
						builtin => {
							switch (builtin.BuiltinType) {
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
						typeReference => {
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
						result = CSharp.TypeReference.Nullable(result);
					return result;
				}
			);
		}

		private string ConvertValue(Value value) {
			return value.DecomposeWithResult(
				@int => @int.ToString(CultureInfo.InvariantCulture),
				@float => @float.ToString(CultureInfo.InvariantCulture),
				@string => "\"" + @string + "\"",
				special => {
					switch (special) {
						case SpecialValue.True:             return "true";
						case SpecialValue.False:            return "false";
						case SpecialValue.Null:             return "null";
						case SpecialValue.PositiveInfinity: return "double.PositiveInfinity";
						case SpecialValue.NegativeInfinity: return "double.NegativeInfinity";
						case SpecialValue.NaN:              return "double.NaN";
						default: throw new ArgumentException("Invalid special value " + special);
					}
				}
			);
		}

		private IList<IReadOnlyList<CSharp.Parameter>> GetParameterLists(IEnumerable<Argument> arguments, Dictionary<string, CSharp.TypeReference> typeOverrides, bool includePartialSignatures) {
			var result = new List<IReadOnlyList<CSharp.Parameter>>();
			var current = new List<CSharp.Parameter>();

			foreach (var arg in arguments) {
				string name = arg.Name.RemoveLeadingUnderscore();
				var type = GetOrDefault(typeOverrides, name, ConvertType(arg.Type));

				arg.Decompose(
					required => {
						current.Add(CSharp.Parameter.Create(name, type));
					},
					optional => {
						if (includePartialSignatures)
							result.Add(new List<CSharp.Parameter>(current));
						current.Add(CSharp.Parameter.Create(name, type));
					},
					ellipsis => {
						current.Add(CSharp.Parameter.Create(name, CSharp.TypeReference.Array(type), isParams: true));
					}
				);
			}
			result.Add(current);

			return result;
		}

		private string GetClosestInterfaceObjectName(ResolvedDefinition interfaceDef) {
			return interfaceDef.DecomposeWithResult(
				@interface => {
					var ea = ParsedExtendedAttributes.Parse(@interface.ExtendedAttributes, @interface.Name, _errors);
					if (ea.NoInterfaceObject) {
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

		private bool ShouldBeIncluded(string name, string typeName, ParsedExtendedAttributes memberAttributes) {
			if (name != null) {
				if (name.StartsWith("Moz", StringComparison.OrdinalIgnoreCase) || name.StartsWith("onMoz", StringComparison.OrdinalIgnoreCase))
					return false;
				if (typeName != null && typeName.EndsWith("Event") && name == "init" + typeName)
					return false;	// Mozilla-specific deprecated UIEvent.initUIEvent
			}
			if (memberAttributes != null && memberAttributes.ChromeOnly)
				return false;
			return true;
		}

		private class IndexedPropertyData {
			public CSharp.TypeReference IndexParameterType;
			public List<string> IndexParameterNames = new List<string>();
			public List<CSharp.TypeReference> PropertyTypes = new List<CSharp.TypeReference>();
			public bool CanRead;
			public bool CanWrite;
		}

		private bool IsIntegerType(CSharp.TypeReference type) {
			return type.DecomposeWithResult(
				keyword => {
					switch (keyword.Keyword) {
						case "sbyte":
						case "byte":
						case "short":
						case "ushort":
						case "int":
						case "uint":
						case "long":
						case "ulong":
							return true;
						default:
							return false;
					}
				},
				namedType => false,
				array     => false,
				nullable  => IsIntegerType(nullable.UnderlyingType)
			);
		}

		private bool HasIntegerLength(IEnumerable<CSharp.ClassMember> members) {
			return members.Any(m => m.DecomposeWithResult(
			                            constructor => false,
			                            property    => property.Name == "Length" && property.CanRead && IsIntegerType(property.Type),
			                            method      => false,
			                            field       => false,
			                            indexer     => false));
		}

		private void AddConstructors(ParsedExtendedAttributes attributes, Dictionary<string, CSharp.TypeReference> typeOverrides, List<CSharp.ClassMember> members) {
			bool hasParameterlessCtor = false;
			foreach (var c in attributes.Constructors) {
				foreach (var sig in GetParameterLists(c, typeOverrides, includePartialSignatures: true)) {
					if (sig.Count == 0)
						hasParameterlessCtor = true;
					members.Add(CSharp.ClassMember.Constructor(CSharp.Accessibility.Public, sig, ExpandParamsIfRequired(sig)));
				}
			}
			foreach (var c in attributes.NamedConstructors) {
				foreach (var sig in GetParameterLists(c.Item2, typeOverrides, includePartialSignatures: true)) {
					if (sig.Count == 0)
						hasParameterlessCtor = true;
					members.Add(CSharp.ClassMember.Constructor(CSharp.Accessibility.Public, sig, new[] { InlineCodeAttribute("new " + c.Item1 + MakeInlineCodeParameterList(sig)) }));
				}
			}
			if (!hasParameterlessCtor)
				members.Add(CSharp.ClassMember.Constructor(CSharp.Accessibility.Internal, new CSharp.Parameter[0], new CSharp.Attribute[0]));
		}

		private string MakeInlineCodeParameterList(IReadOnlyList<CSharp.Parameter> parameters) {
			var result = new StringBuilder("(");
			bool first = true;
			foreach (var p in parameters) {
				if (!first)
					result.Append(", ");
				result.Append("{" + (p.IsParams ? "*" : "") + p.Name + "}");
				first = false;
			}
			result.Append(")");
			return result.ToString();
		}

		private ParsedExtendedAttributes ParseExtendedAttributes(ResolvedDefinition type) {
			var t = type.DecomposeWithResult(
				@interface        => Tuple.Create(@interface.Name, @interface.ExtendedAttributes),
				callbackInterface => Tuple.Create(callbackInterface.Name, callbackInterface.ExtendedAttributes),
				dictionary        => Tuple.Create(dictionary.Name, dictionary.ExtendedAttributes),
				callback          => Tuple.Create(callback.Name, callback.ExtendedAttributes),
				exception         => Tuple.Create(exception.Name, exception.ExtendedAttributes),
				@enum             => Tuple.Create(@enum.Name, @enum.ExtendedAttributes),
				declaredInterface => Tuple.Create(declaredInterface.Name, (IReadOnlyList<ExtendedAttribute>)new ExtendedAttribute[0])
			);
			return ParsedExtendedAttributes.Parse(t.Item2, t.Item1, _errors);
		}

		private CSharp.TypeReference MakeTypeOptionIfRequired(IReadOnlyList<CSharp.TypeReference> options) {
			return options.Count > 1 ? CSharp.TypeReference.GenericNamedType("TypeOption", "System", options) : options[0];
		}

		private void AddMembers(IEnumerable<InterfaceMember> source, Dictionary<string, CSharp.TypeReference> typeOverrides, string interfaceName, bool noInterfaceObject, IReadOnlyDictionary<string, string> renames, TypeKind typeKind, IReadOnlyList<string> removes, List<CSharp.ClassMember> members) {
			var indexedProperties = new Dictionary<string, IndexedPropertyData>();
			var enumerateAsArrayCandidates = new List<CSharp.TypeReference>();

			foreach (var sourceMember in source) {
				if (removes.Contains(WebIDLFormatter.FormatSignature(sourceMember)))
					continue;

				sourceMember.Decompose(
					@const => {
						if (typeKind != TypeKind.Interface) {
							var memberAttributes = ParsedExtendedAttributes.Parse(@const.ExtendedAttributes, interfaceName + "." + @const.Name, _errors);
							string name = @const.Name.RemoveLeadingUnderscore();
							if (ShouldBeIncluded(name, interfaceName, memberAttributes) && !removes.Contains(name)) {
								string csharpName = GetOrDefault(renames, name, name.MakeCSharpName());
								if (noInterfaceObject)
									members.Add(CSharp.ClassMember.Property(CSharp.Accessibility.Public, csharpName, ConvertType(@const.Type), CSharp.MemberModifiers.None, canRead: true, canWrite: false, attributes: new[] { IntrinsicPropertyAttribute }.Concat(ScriptNameAttributeIfRequired(csharpName, name))));
								else
									members.Add(CSharp.ClassMember.Field(CSharp.Accessibility.Public, csharpName, ConvertType(@const.Type), CSharp.MemberModifiers.Const, ConvertValue(@const.Value), ScriptNameAttributeIfRequired(csharpName, name)));
							}
						}
					},
					operation => {
						string operationName = interfaceName + "." + (operation.Name ?? "()");
						var memberAttributes = ParsedExtendedAttributes.Parse(operation.ExtendedAttributes, operationName, _errors);
						foreach (var a in operation.Arguments)
							ParsedExtendedAttributes.Parse(a.ExtendedAttributes, operationName + "(" + a.Name + ")", _errors);
						string name = operation.Name.RemoveLeadingUnderscore();
						if (ShouldBeIncluded(name, interfaceName, memberAttributes) && !removes.Contains(name)) {
							if (name != null) {
								var type = GetOrDefault(typeOverrides, name, sourceMember, ConvertType(operation.ReturnType));
								string csharpName = GetOrDefault(renames, name, name.MakeCSharpName());
								foreach (var sig in GetParameterLists(operation.Arguments, typeOverrides, includePartialSignatures: true))
									members.Add(CSharp.ClassMember.Method(CSharp.Accessibility.Public, csharpName, type, (operation.Qualifiers & OperationQualifiers.Static) != 0 ? CSharp.MemberModifiers.Static : CSharp.MemberModifiers.None, sig, ScriptNameAttributeIfRequired(csharpName, name).Concat(ExpandParamsIfRequired(sig))));
							}
							else {
								var type = ConvertType(operation.ReturnType);
								if ((operation.Qualifiers & OperationQualifiers.LegacyCaller) != 0) {
									foreach (var sig in GetParameterLists(operation.Arguments, typeOverrides, includePartialSignatures: true))
										members.Add(CSharp.ClassMember.Method(CSharp.Accessibility.Public, "Call", type, (operation.Qualifiers & OperationQualifiers.Static) != 0 ? CSharp.MemberModifiers.Static : CSharp.MemberModifiers.None, sig, new[] { InlineCodeAttribute("{this}" + MakeInlineCodeParameterList(sig)) }));
								}
								else if ((operation.Qualifiers & (OperationQualifiers.Accessor | OperationQualifiers.Stringifier)) == 0) {
									_errors.Add("Unnamed operation `" + interfaceName + ".()' is not supported");
								}
							}

							int accessorCount = 0;
							if ((operation.Qualifiers & (OperationQualifiers.Creator | OperationQualifiers.Setter)) != 0) {
								if (operation.Arguments.Count != 2) {
									_errors.Add("Indexed creator or setter `" + operationName + "' must have exactly 2 arguments");
									return;
								}
								string indexName = operation.Arguments[0].Name.RemoveLeadingUnderscore();
								var indexType = GetOrDefault(typeOverrides, indexName, ConvertType(operation.Arguments[0].Type));
								string key = CSharp.CodeFormatter.Format(indexType);
								var argumentName = operation.Arguments[1].Name.RemoveLeadingUnderscore();
								var argumentType = GetOrDefault(typeOverrides, argumentName, ConvertType(operation.Arguments[1].Type));

								IndexedPropertyData data;
								if (indexedProperties.TryGetValue(key, out data)) {
									if (!data.IndexParameterNames.Contains(indexName))
										data.IndexParameterNames.Add(indexName);
									if (!data.PropertyTypes.Any(t => CSharp.CodeFormatter.Format(t) == CSharp.CodeFormatter.Format(argumentType)))
										data.PropertyTypes.Add(argumentType);
								}
								else
									data = indexedProperties[key] = new IndexedPropertyData { IndexParameterNames = { indexName }, IndexParameterType = indexType, PropertyTypes = { argumentType } };
								data.CanWrite = true;
								accessorCount++;
							}
							if ((operation.Qualifiers & OperationQualifiers.Getter) != 0) {
								if (operation.Arguments.Count != 1) {
									_errors.Add("Indexed getter `" + operationName + "' must have exactly 1 argument");
									return;
								}
								string indexName = operation.Arguments[0].Name.RemoveLeadingUnderscore();
								var indexType = GetOrDefault(typeOverrides, indexName, ConvertType(operation.Arguments[0].Type));
								string key = CSharp.CodeFormatter.Format(indexType);
								var returnType = GetOrDefault(typeOverrides, name, sourceMember, ConvertType(operation.ReturnType));

								IndexedPropertyData data;
								if (indexedProperties.TryGetValue(key, out data)) {
									if (!data.IndexParameterNames.Contains(indexName))
										data.IndexParameterNames.Add(indexName);
									if (!data.PropertyTypes.Any(t => CSharp.CodeFormatter.Format(t) == CSharp.CodeFormatter.Format(returnType)))
										data.PropertyTypes.Add(returnType);
								}
								else
									data = indexedProperties[key] = new IndexedPropertyData() { IndexParameterNames = { indexName }, IndexParameterType = indexType, PropertyTypes = { returnType } };
								data.CanRead = true;

								if (IsIntegerType(indexType) && !enumerateAsArrayCandidates.Any(t => CSharp.CodeFormatter.Format(t) == CSharp.CodeFormatter.Format(returnType)))
									enumerateAsArrayCandidates.Add(returnType);

								accessorCount++;
							}
							if ((operation.Qualifiers & OperationQualifiers.Deleter) != 0) {
								if (operation.Arguments.Count != 1) {
									_errors.Add("Indexed deleter `" + operationName + "' must have exactly 1 argument");
									return;
								}

								if (name == null) {
									string indexName = operation.Arguments[0].Name.RemoveLeadingUnderscore();
									var indexType = GetOrDefault(typeOverrides, indexName, ConvertType(operation.Arguments[0].Type));
									members.Add(CSharp.ClassMember.Method(CSharp.Accessibility.Public, "Delete", CSharp.TypeReference.Keyword("void"), CSharp.MemberModifiers.None, new[] { CSharp.Parameter.Create(indexName, indexType) }, new[] { InlineCodeAttribute("delete {this}[{" + indexName + "}]") }));
								}

								accessorCount++;
							}

							if (accessorCount > 1)
								_errors.Add("Invalid accessor combination on `" + operationName + "'");
						}
					},
					attribute => {
						var memberAttributes = ParsedExtendedAttributes.Parse(attribute.ExtendedAttributes, interfaceName + "." + attribute.Name, _errors);
						string name = attribute.Name.RemoveLeadingUnderscore();
						if (ShouldBeIncluded(name, interfaceName, memberAttributes) && !removes.Contains(name)) {
							string csharpName = GetOrDefault(renames, name, name.MakeCSharpName());
							var attrType = GetOrDefault(typeOverrides, name, ConvertType(attribute.Type));
							members.Add(CSharp.ClassMember.Property(CSharp.Accessibility.Public, csharpName, attrType, (attribute.Qualifiers & AttributeQualifiers.Static) != 0 ? CSharp.MemberModifiers.Static : CSharp.MemberModifiers.None, true, (attribute.Qualifiers & AttributeQualifiers.ReadOnly) == 0, ScriptNameAttributeIfRequired(csharpName, name).Concat(new[] { IntrinsicPropertyAttribute })));
						}
					},
					jsonifier => {
						ParsedExtendedAttributes.Parse(jsonifier.ExtendedAttributes, interfaceName + ".jsonifier", _errors);
					}
				);
			}

			foreach (var p in indexedProperties.Values) {
				if (p.IndexParameterNames.Count > 1)
					_errors.Add("Ambiguous parameter name in indexer `" + interfaceName + "[" + CSharp.CodeFormatter.Format(p.IndexParameterType) + "] (candidate names are " + string.Join(", ", p.IndexParameterNames.Select(n => "`" + n + "'")) + ")");
				members.Add(CSharp.ClassMember.Indexer(CSharp.Accessibility.Public, MakeTypeOptionIfRequired(p.PropertyTypes), CSharp.MemberModifiers.None, new[] { CSharp.Parameter.Create(p.IndexParameterNames[0], p.IndexParameterType) }, canRead: p.CanRead, canWrite: p.CanWrite, attributes: new[] { IntrinsicPropertyAttribute, IndexerNameAttribute("__Item") }));
			}

			if (enumerateAsArrayCandidates.Count > 0 && HasIntegerLength(members)) {
				var arrayType = MakeTypeOptionIfRequired(enumerateAsArrayCandidates);
				members.Add(CSharp.ClassMember.Method(CSharp.Accessibility.Public, "GetEnumerator", CSharp.TypeReference.GenericNamedType("IEnumerator", "System.Collections.Generic", new[] { arrayType }), CSharp.MemberModifiers.None, new CSharp.Parameter[0], new[] { EnumerateAsArrayAttribute, InlineCodeAttribute("new {$System.ArrayEnumerator}({this})") }));
			}
		}

		private void AddMembers(IEnumerable<DictionaryMember> source, Dictionary<string, CSharp.TypeReference> typeOverrides, string dictionaryName, IReadOnlyDictionary<string, string> renames, IReadOnlyList<string> removes, List<CSharp.ClassMember> members) {
			foreach (var sourceMember in source) {
				var memberAttributes = ParsedExtendedAttributes.Parse(sourceMember.ExtendedAttributes, dictionaryName + "." + sourceMember.Name, _errors);
				string name = sourceMember.Name.RemoveLeadingUnderscore();
				if (ShouldBeIncluded(name, dictionaryName, memberAttributes) && !removes.Contains(name)) {
					string csharpName = GetOrDefault(renames, name, name.MakeCSharpName());
					var type = GetOrDefault(typeOverrides, name, ConvertType(sourceMember.Type));
					members.Add(CSharp.ClassMember.Property(CSharp.Accessibility.Public, csharpName, type, CSharp.MemberModifiers.None, true, true, ScriptNameAttributeIfRequired(csharpName, name)));
				}
			}
		}

		private CSharp.TypeDefinition ConvertTypeDefinition(ResolvedDefinition type, bool returnNonGenerated) {
			CSharp.TypeDefinition result = null;
			type.Decompose(
				@interface => {
					var parsedAttributes = ParsedExtendedAttributes.Parse(@interface.ExtendedAttributes, @interface.Name, _errors);
					if (!parsedAttributes.ChromeOnly) {
						// Attributes to handle: Constructors, NamedConstructors, NoInterfaceObject
						var meta = _metadata.Types[@interface.Name];
						if (!meta.Generate && !returnNonGenerated)
							return;
						var typeOverrides = meta.TypeOverrides.ToDictionary(t => t.Identifier, t => t.NewType);

						var members = new List<CSharp.ClassMember>();
						if (meta.IncludeConstructors && meta.TypeKind != TypeKind.Interface)
							AddConstructors(parsedAttributes, typeOverrides, members);
						AddMembers(@interface.Members, typeOverrides, @interface.Name, parsedAttributes.NoInterfaceObject, meta.Renames, meta.TypeKind, meta.Removes, members);

						string scriptName;
						var attributes = new List<CSharp.Attribute> { IgnoreNamespaceAttribute };
						if (meta.TagNames.Count > 0) {
							string typeCheckCode = "{$System.Script}.isInstanceOfType({this}, Element) && " + (meta.TagNames.Count > 1 ? "(" : "") + string.Join(" || ", meta.TagNames.Select(t => "{this}.tagName === '" + t.ToUpperInvariant() + "'")) + (meta.TagNames.Count > 1 ? ")" : "");
							attributes.Add(ImportedAttribute(false, typeCheckCode));
							scriptName = "Element";
						}
						else {
							attributes.Add(ImportedAttribute(meta.TypeKind != TypeKind.Interface));
							scriptName = GetClosestInterfaceObjectName(type);
						}

						var baseTypes = (@interface.Base != null ? new[] { @interface.Base } : new string[0]).Concat(@interface.Implements).Select(
							b => {
								var baseMeta = _metadata.Types[b];
								if (!baseMeta.Inherit)
									return null;
								if (!ParseExtendedAttributes(_types[b]).ChromeOnly) {
									if (b != @interface.Base || baseMeta.TypeKind == TypeKind.Mixin) {
										if (baseMeta.TypeKind == TypeKind.Default)
											_errors.Add("The type `" + b + "' cannot be implemented by the type `" + @interface.Name + "' because the implemented type is not a C# interface");
										_types[b].Decompose(
											@interface2 => AddMembers(@interface2.Members, baseMeta.TypeOverrides.ToDictionary(o => o.Identifier, o => o.NewType), b, parsedAttributes.NoInterfaceObject, baseMeta.Renames, baseMeta.TypeKind, meta.Removes, members),
											callbackInterface => { _errors.Add("Base type `" + b + "' of type `" + @interface.Name + " was a callback interface, not an interface"); },
											dictionary => { _errors.Add("Base type `" + b + "' of type `" + @interface.Name + " was a dictionary, not an interface"); },
											@callback => { _errors.Add("Base type `" + b + "' of type `" + @interface.Name + " was a callback, not an interface"); },
											@exception => { _errors.Add("Base type `" + b + "' of type `" + @interface.Name + " was an exception, not an interface"); },
											@enum => { _errors.Add("Base type `" + b + "' of type `" + @interface.Name + " was an enum, not an interface"); },
											declaredInterface => _errors.Add("The type `" + b + "' cannot be implemented by the type `" + @interface.Name + "' because the implemented type is not defined")
										);
									}
									if (baseMeta.TypeKind == TypeKind.Mixin)
										return null;

									return baseMeta.AliasFor ?? CSharp.TypeReference.NamedType(baseMeta.CSharpName, baseMeta.Namespace);
								}
								else
									return null;
							})
							.Where(x => x != null);

						if (meta.TypeKind == TypeKind.Default && meta.CSharpName != scriptName)
							attributes.Add(ScriptNameAttribute(scriptName));
						if (parsedAttributes.Global)
							attributes.Add(GlobalMethodsAttribute);

						result = CSharp.TypeDefinition.Class(meta.TypeKind == TypeKind.Interface ? CSharp.ClassType.Interface : CSharp.ClassType.Class, CSharp.ClassModifiers.Partial | (parsedAttributes.Global ? CSharp.ClassModifiers.Static : 0), meta.CSharpName, meta.Namespace, baseTypes, members, attributes);
					}
				},
				callbackInterface => {
					var parsedAttributes = ParsedExtendedAttributes.Parse(callbackInterface.ExtendedAttributes, callbackInterface.Name, _errors);
					if (!parsedAttributes.ChromeOnly) {
						var meta = _metadata.Types[callbackInterface.Name];
						if (!meta.Generate && !returnNonGenerated)
							return;
						var typeOverrides = meta.TypeOverrides.ToDictionary(t => t.Identifier, t => t.NewType);

						var members = new List<CSharp.ClassMember>();
						AddMembers(callbackInterface.Members, typeOverrides, callbackInterface.Name, true, meta.Renames, TypeKind.Interface, meta.Removes, members);

						var baseTypes = new CSharp.TypeReference[0];
						if (callbackInterface.Base != null) {
							var baseMeta = _metadata.Types[callbackInterface.Base];
							if (baseMeta.Inherit)
								baseTypes = new[] { baseMeta.AliasFor ?? CSharp.TypeReference.NamedType(baseMeta.CSharpName, baseMeta.Namespace) };
						}

						result = CSharp.TypeDefinition.Class(CSharp.ClassType.Interface, CSharp.ClassModifiers.Partial, meta.CSharpName, meta.Namespace, baseTypes, members, new[] { ImportedAttribute(false) });
					}
				},
				dictionary => {
					var parsedAttributes = ParsedExtendedAttributes.Parse(dictionary.ExtendedAttributes, dictionary.Name, _errors);
					if (!parsedAttributes.ChromeOnly) {
						var meta = _metadata.Types[dictionary.Name];
						if (!meta.Generate && !returnNonGenerated)
							return;
						var typeOverrides = meta.TypeOverrides.ToDictionary(t => t.Identifier, t => t.NewType);

						var members = new List<CSharp.ClassMember>();
						AddMembers(dictionary.Members, typeOverrides, dictionary.Name, meta.Renames, meta.Removes, members);

						var baseTypes = new CSharp.TypeReference[0];
						if (dictionary.Base != null) {
							var baseMeta = _metadata.Types[dictionary.Base];
							if (baseMeta.Inherit)
								baseTypes = new[] { baseMeta.AliasFor ?? CSharp.TypeReference.NamedType(baseMeta.CSharpName, baseMeta.Namespace) };
						}

						result = CSharp.TypeDefinition.Class(CSharp.ClassType.Class, CSharp.ClassModifiers.Partial, meta.CSharpName, meta.Namespace, baseTypes, members, new[] { ImportedAttribute(false), SerializableAttribute });
					}
				},
				callback => {
					var parsedAttributes = ParsedExtendedAttributes.Parse(callback.ExtendedAttributes, callback.Name, _errors);
					if (!ShouldBeIncluded(callback.Name, null, parsedAttributes))
						return;
					var meta = _metadata.Types[callback.Name];
					if (!meta.Generate && !returnNonGenerated)
						return;
					var typeOverrides = meta.TypeOverrides.ToDictionary(t => t.Identifier, t => t.NewType);

					foreach (var a in callback.Arguments) {
						ParsedExtendedAttributes.Parse(a.ExtendedAttributes, callback.Name + "(" + a.Name + ")", _errors);
					}
					var sig = GetParameterLists(callback.Arguments, typeOverrides, includePartialSignatures: false).SingleOrDefault();
					if (sig != null)
						result = CSharp.TypeDefinition.Delegate(meta.CSharpName, meta.Namespace, ConvertType(callback.ReturnType), sig, ExpandParamsIfRequired(sig));
					else
						_errors.Add("No signature could be generated for the callback `" + callback.Name + "'");
				},
				exception => {
					ParsedExtendedAttributes.Parse(exception.ExtendedAttributes, exception.Name, _errors);
					foreach (var member in exception.Members) {
						member.Decompose(
							@const => {
								ParsedExtendedAttributes.Parse(@const.ExtendedAttributes, exception.Name + "." + @const.Name, _errors);
							},
							field => {
								ParsedExtendedAttributes.Parse(field.ExtendedAttributes, exception.Name + "." + field.Name, _errors);
							}
						);
					}
					_errors.Add("Exception `" + exception.Name + "' not yet supported");
				},
				@enum => {
					ParsedExtendedAttributes.Parse(@enum.ExtendedAttributes, @enum.Name, _errors);
					var meta = _metadata.Types[@enum.Name];
					if (!meta.Generate && !returnNonGenerated)
						return;
					result = CSharp.TypeDefinition.Enum(meta.CSharpName,
					                                    meta.Namespace,
					                                    @enum.Values
					                                         .Where(v => ShouldBeIncluded(v, @enum.Name, null))
					                                         .Select(v => { string csharpName = GetOrDefault(meta.Renames, v, v.MakeCSharpName()); return CSharp.EnumMember.Create(csharpName, null, ScriptNameAttributeIfRequired(csharpName, v)); }),
					                                    new[] { ImportedAttribute(false), NamedValuesAttribute });
				},
				declaredInterface => {
					var meta = _metadata.Types[declaredInterface.Name];
					if (meta.Generate || returnNonGenerated)
						_errors.Add("Undefined interface `" + declaredInterface.Name + "'");
				}
			);
			return result;
		}

		private void BuildCSharpModel() {
			foreach (var type in _types.Values) {
				var t = ConvertTypeDefinition(type, returnNonGenerated: false);
				if (t != null)
					_result.Add(t);
			}
		}

		private void GenerateEnumFromConstants(EnumFromConstants meta, IEnumerable<InterfaceMember> members) {
			string qualifiedName = meta.EnumNamespace + "." + meta.EnumName;
			var constants = new List<Tuple<string, int>>();
			bool noErrorIfNoConstants = false;
			foreach (var m in members) {
				m.Decompose(
					@const => {
						var match = meta.ConstantsRegex.Match(@const.Name);
						if (match.Success) {
							if (match.Groups.Count != 2) {
								_errors.Add("The regular expression used to generate the enum `" + qualifiedName + "' is not an integer does not have one capture group");
								noErrorIfNoConstants = true;
								return;
							}
							string raw = match.Groups[1].Value;
							string name = GetOrDefault(meta.Names, raw, raw.ConstantCaseToPascalCase());

							@const.Value.Decompose(
								@int    => constants.Add(Tuple.Create(name, @int)),
								@double => _errors.Add("The constant `" + @const.Name + "', required by the enum `" + qualifiedName + "' is not an integer"),
								@string => _errors.Add("The constant `" + @const.Name + "', required by the enum `" + qualifiedName + "' is not an integer"),
								special => _errors.Add("The constant `" + @const.Name + "', required by the enum `" + qualifiedName + "' is not an integer")
							);
						}
					},
					operation: null,
					attribute: null,
					jsonifier: null
				);
			}
			if (constants.Count == 0 && !noErrorIfNoConstants)
				_errors.Add("No constants found for the enum `" + qualifiedName + "'");

			var attributes = new List<CSharp.Attribute> { ImportedAttribute(false) };
			if (meta.Flags)
				attributes.Add(FlagsAttribute);

			_result.Add(CSharp.TypeDefinition.Enum(meta.EnumName, meta.EnumNamespace, constants.Select(c => CSharp.EnumMember.Create(c.Item1, c.Item2, new CSharp.Attribute[0])), attributes));
		}

		private void GenerateEnumsFromConstants() {
			foreach (var meta in _metadata.EnumsFromConstants) {
				string qualifiedName = meta.EnumNamespace + "." + meta.EnumName;
				ResolvedDefinition def;
				if (!_types.TryGetValue(meta.Container, out def)) {
					_errors.Add("Could not find the container `" + meta.Container + "' for the constants to generate the enum `" + qualifiedName + "'");
					continue;
				}
				def.Decompose(
					@interface        => GenerateEnumFromConstants(meta, @interface.Members),
					callbackInterface => GenerateEnumFromConstants(meta, callbackInterface.Members),
					dictionary        => _errors.Add("The container `" + meta.Container + "' for the constants to generate the enum `" + qualifiedName + "' is not an interface"),
					callback          => _errors.Add("The container `" + meta.Container + "' for the constants to generate the enum `" + qualifiedName + "' is not an interface"),
					exception         => _errors.Add("The container `" + meta.Container + "' for the constants to generate the enum `" + qualifiedName + "' is not an interface"),
					@enum             => _errors.Add("The container `" + meta.Container + "' for the constants to generate the enum `" + qualifiedName + "' is not an interface"),
					declaredInterface => _errors.Add("The container `" + meta.Container + "' for the constants to generate the enum `" + qualifiedName + "' does not have a definition")
				);
			}
		}

		public void GenerateStaticInstances() {
			foreach (var meta in _metadata.StaticInstances) {
				string qualifiedName = meta.ClassNamespace + "." + meta.ClassName;
				bool continueLoop = false;
				string currentName = meta.TypeName;

				var members = new List<CSharp.ClassMember>();

				do {
					ResolvedDefinition def;
					if (!_types.TryGetValue(currentName, out def)) {
						_errors.Add("Could not find the type (or base type) `" + currentName + "' for the static instance `" + qualifiedName + "'");
						break;
					}

					def.Decompose(
						@interface => {
							var interfaceMeta = _metadata.Types[@interface.Name];
							var csType = _result.FirstOrDefault(d => d.Namespace == interfaceMeta.Namespace && d.Name == interfaceMeta.CSharpName);
							if (csType == null) {
								csType = ConvertTypeDefinition(_types[@interface.Name], returnNonGenerated: true);
								if (csType == null) {
									_errors.Add("The type (or base type) `" + currentName + "' for the static instance `" + qualifiedName + "' was not generated");
									return;
								}
							}
							csType.Decompose(
								@class => {
									members.AddRange(
										@class.Members.Select(
											m => m.DecomposeWithResult(
												constructor => null,
												property => CSharp.ClassMember.Property(property.Accessibility, property.Name, property.Type, property.Modifiers | CSharp.MemberModifiers.Static, property.CanRead, property.CanWrite, property.Attributes),
												method   => CSharp.ClassMember.Method(method.Accessibility, method.Name, method.ReturnType, method.Modifiers | CSharp.MemberModifiers.Static, method.Parameters, method.Attributes),
												field    => CSharp.ClassMember.Field(field.Accessibility, field.Name, field.Type, field.Modifiers | ((field.Modifiers & CSharp.MemberModifiers.Const) == 0 ? CSharp.MemberModifiers.Static : 0), field.ConstValue, field.Attributes),
												indexer  => null
											))
											.Where(m => m != null)
										);
								},
								@delegate => _errors.Add("The type `" + currentName + "' for the static instance `" + qualifiedName + "' was generated as a delegate"),
								@enum     => _errors.Add("The type `" + currentName + "' for the static instance `" + qualifiedName + "' was generated as an enum")
							);

							currentName = @interface.Base;
							continueLoop = currentName != null;
						},
						callbackInterface => _errors.Add("The type (or base type) `" + currentName + "' for the static instance `" + qualifiedName + "' is not an interface"),
						dictionary        => _errors.Add("The type (or base type) `" + currentName + "' for the static instance `" + qualifiedName + "' is not an interface"),
						callback          => _errors.Add("The type (or base type) `" + currentName + "' for the static instance `" + qualifiedName + "' is not an interface"),
						exception         => _errors.Add("The type (or base type) `" + currentName + "' for the static instance `" + qualifiedName + "' is not an interface"),
						@enum             => _errors.Add("The type (or base type) `" + currentName + "' for the static instance `" + qualifiedName + "' is not an interface"),
						declaredInterface => _errors.Add("The type (or base type) `" + currentName + "' for the static instance `" + qualifiedName + "' does not have a definition")
					);
				} while (continueLoop);

				CSharp.Attribute[] attributes;
				if (meta.GlobalMethods)
					attributes = new[] { ImportedAttribute(false), GlobalMethodsAttribute };
				else
					attributes = new[] { ImportedAttribute(false), IgnoreNamespaceAttribute, ScriptNameAttribute(meta.InstanceName) };

				_result.Add(CSharp.TypeDefinition.Class(CSharp.ClassType.Class, CSharp.ClassModifiers.Static | CSharp.ClassModifiers.Partial, meta.ClassName, meta.ClassNamespace, new CSharp.TypeReference[0], members, attributes));
			}
		}

		private void MatchMetadataAndTypes() {
			_errors.AddRange(_types.Keys.Except(_metadata.Types.Keys).Select(missing => string.Format("Missing metadata for the type `{0}", missing)));
			_errors.AddRange(_metadata.Types.Keys.Except(_types.Keys).Select(extra => string.Format("Metadata for non-existent type `{0}", extra)));
		}

		public static Tuple<IReadOnlyList<CSharp.TypeDefinition>, IReadOnlyList<string>> BuildCSharpModel(Dictionary<string, ResolvedDefinition> types, Metadata metadata) {
			var c = new Converter(types, metadata);
			c.MatchMetadataAndTypes();
			if (c._errors.Count == 0) {
				c.BuildCSharpModel();
				c.GenerateEnumsFromConstants();
				c.GenerateStaticInstances();
			}
			return Tuple.Create<IReadOnlyList<CSharp.TypeDefinition>, IReadOnlyList<string>>(c._result, c._errors);
		}
	}
}
