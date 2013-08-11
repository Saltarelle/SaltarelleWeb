using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generator.CSharp {
	public class CodeFormatter {
		private static readonly HashSet<string> Keywords = new HashSet<string> { "abstract", "as", "base", "bool", "break", "byte", "case", "catch", "char", "checked", "class", "const", "continue", "decimal", "default", "delegate", "do", "double", "else", "enum", "event", "explicit", "extern", "false", "finally", "fixed", "float", "for", "foreach", "goto", "if", "implicit", "in", "int", "interface", "internal", "is", "lock", "long", "namespace", "new", "null", "object", "operator", "out", "override", "params", "private", "protected", "public", "readonly", "ref", "return", "sbyte", "sealed", "short", "sizeof", "stackalloc", "static", "string", "struct", "switch", "this", "throw", "true", "try", "typeof", "uint", "ulong", "unchecked", "unsafe", "ushort", "using", "virtual", "void", "volatile", "while" };

		private readonly HashSet<string> _namespaces = new HashSet<string>();
		private readonly StringBuilder _sb = new StringBuilder();

		private string Escape(string identifier) {
			return Keywords.Contains(identifier) ? "@" + identifier : identifier;
		}

		private void AppendAttributeString(IEnumerable<Attribute> attributes, string prefix) {
			bool anyAttr = false;
			foreach (var attr in attributes.OrderBy(a => a.AttributeTypeName)) {
				_sb.Append(anyAttr ? ", " : (prefix + "["));
				anyAttr = true;
				_namespaces.Add(attr.AttributeTypeNamespace);
				_sb.Append(attr.AttributeTypeName);
				bool anyArg = false;
				foreach (var arg in attr.PositionalArguments) {
					_sb.Append(anyArg ? ", " : "(");
					anyArg = true;
					_sb.Append(arg);
				}
				foreach (var arg in attr.NamedArguments) {
					_sb.Append(anyArg ? ", " : "(");
					anyArg = true;
					_sb.Append(arg.Item1 + " = " + arg.Item2);
				}
				if (anyArg)
					_sb.Append(")");
			}
			if (anyAttr)
				_sb.AppendLine("]");
		}

		private string GetTypeString(TypeReference type, bool allowImports) {
			return type.DecomposeWithResult(
				keyword => keyword.Keyword,
				namedType => {
					string name = namedType.Name;
					if (!string.IsNullOrEmpty(namedType.Namespace)) {
						if (allowImports)
							_namespaces.Add(namedType.Namespace);
						else
							name = namedType.Namespace + "." + name;
					}
					if (namedType.TypeArguments.Count > 0)
						return name + "<" + string.Join(", ", namedType.TypeArguments.Select(t => GetTypeString(t, allowImports))) + ">";
					else
						return name;
				},
				array => GetTypeString(array.ElementType, allowImports) + "[]",
				nullable => GetTypeString(nullable.UnderlyingType, allowImports) + "?"
			);
		}

		private static string GetAccessString(Accessibility accessibility) {
			switch (accessibility) {
				case Accessibility.Public: return "public";
				case Accessibility.Protected: return "protected";
				case Accessibility.Private: return "private";
				case Accessibility.Internal: return "internal";
				case Accessibility.ProtectedInternal: return "protected internal";
				default: throw new ArgumentException("accessibility");
			}
		}

		private static string GetModifierString(MemberModifiers modifiers) {
			string s = null;
			if ((modifiers & MemberModifiers.Static) != 0)
				s = "static";
			if ((modifiers & MemberModifiers.Const) != 0)
				s += (s != null ? " " : "") + "const";
			if ((modifiers & MemberModifiers.New) != 0)
				s += (s != null ? " " : "") + "new";
			return s;
		}

		private static string GetModifierString(ClassModifiers modifiers) {
			string s = null;
			if ((modifiers & ClassModifiers.Static) != 0)
				s = "static";
			if ((modifiers & ClassModifiers.Partial) != 0)
				s += (s != null ? " " : "") + "partial";
			return s;
		}

		private string GetDefaultValue(TypeReference type) {
			return type.DecomposeWithResult(
				keyword => {
					switch (keyword.Keyword) {
						case "void":
							return null;
						case "string":
						case "object":
							return "null";
						case "char":
							return "'\0'";
						case "bool":
							return "false";
						default:
							return "0";
					}
				},
				namedType => "default(" + GetTypeString(type, allowImports: true) + ")",
				array => "null",
				nullable => "null"
			);
		}

		private void AppendParameterList(IEnumerable<Parameter> parameters, bool parenthesize = true) {
			bool any = false;
			if (parenthesize)
				_sb.Append("(");
			foreach (var p in parameters) {
				if (any)
					_sb.Append(", ");
				any = true;
				if (p.IsParams)
					_sb.Append("params ");
				_sb.Append(GetTypeString(p.Type, allowImports: true) + " " + Escape(p.Name));
			}
			if (parenthesize)
				_sb.Append(")");
		}

		private Tuple<int, string, string> ClassMemberOrderer(ClassMember member) {
			return member.DecomposeWithResult(
				constructor => Tuple.Create(0, (string)null, string.Join(",", constructor.Parameters.Select(p => GetTypeString(p.Type, allowImports: true)))),
				property    => Tuple.Create(2, property.Name, ""),
				method      => Tuple.Create(2, method.Name, string.Join(",", method.Parameters.Select(p => GetTypeString(p.Type, allowImports: true)))),
				field       => Tuple.Create(2, field.Name, ""),
				indexer     => Tuple.Create(1, "", string.Join(",", indexer.Parameters.Select(p => GetTypeString(p.Type, allowImports: true))))
			);
		}


		private void GenerateCode(TypeDefinition type) {
			_sb.AppendLine("namespace " + type.Namespace + " {");
			AppendAttributeString(type.Attributes, "\t");

			type.Decompose(
				@class => {
					_sb.Append("\tpublic " + GetModifierString(@class.Modifiers) + " ");
					switch (@class.ClassType) {
						case ClassType.Class: _sb.Append("class"); break;
						case ClassType.Struct: _sb.Append("struct"); break;
						case ClassType.Interface: _sb.Append("interface"); break;
						default: throw new InvalidOperationException("Invalid ClassType " + @class.ClassType);
					}
					_sb.Append(" " + type.Name);
					if (@class.BaseTypes.Count > 0)
						_sb.Append(" : " + string.Join(", ", @class.BaseTypes.Select(t => GetTypeString(t, allowImports: true))));
					_sb.AppendLine(" {");
					bool any = false;
					foreach (var m in @class.Members.OrderBy(ClassMemberOrderer)) {
						if (any)
							_sb.AppendLine();
						any = true;

						m.Decompose(
							constructor => {
								AppendAttributeString(constructor.Attributes, "\t\t");
								_sb.Append("\t\t" + GetAccessString(constructor.Accessibility) + " " + type.Name);
								AppendParameterList(constructor.Parameters);
								_sb.AppendLine(" {")
								   .AppendLine("\t\t}");
							},
							property => {
								AppendAttributeString(property.Attributes, "\t\t");
								_sb.Append("\t\t");
								if (@class.ClassType != ClassType.Interface)
									_sb.Append(GetAccessString(property.Accessibility) + " ");
								var mods = GetModifierString(property.Modifiers);
								if (mods != null)
									_sb.Append(mods + " ");
								_sb.Append(GetTypeString(property.Type, allowImports: true) + " " + property.Name + " {");
								if (@class.ClassType == ClassType.Interface) {
									if (property.CanRead)
										_sb.Append(" get;");
									if (property.CanWrite)
										_sb.Append(" set;");
									_sb.AppendLine(" }");
								}
								else {
									_sb.AppendLine();
									if (property.CanRead)
										_sb.AppendLine("\t\t\tget { return " + GetDefaultValue(property.Type) + "; }");
									if (property.CanWrite)
										_sb.AppendLine("\t\t\tset { }");
									_sb.AppendLine("\t\t}");
								}
							},
							method => {
								AppendAttributeString(method.Attributes, "\t\t");
								_sb.Append("\t\t");
								if (@class.ClassType != ClassType.Interface)
									_sb.Append(GetAccessString(method.Accessibility) + " ");
								var mods = GetModifierString(method.Modifiers);
								if (mods != null)
									_sb.Append(mods + " ");
								_sb.Append(GetTypeString(method.ReturnType, allowImports: true) + " " + method.Name);
								AppendParameterList(method.Parameters);
								if (@class.ClassType == ClassType.Interface) {
									_sb.AppendLine(";");
								}
								else {
									_sb.AppendLine(" {");
									var def = GetDefaultValue(method.ReturnType);
									if (def != null)
										_sb.AppendLine("\t\t\treturn " + def + ";");
									_sb.AppendLine("\t\t}");
								}
							},
							field => {
								AppendAttributeString(field.Attributes, "\t\t");
								_sb.Append("\t\t" + GetAccessString(field.Accessibility) + " ");
								var mods = GetModifierString(field.Modifiers);
								if (mods != null)
									_sb.Append(mods + " ");
								_sb.Append(GetTypeString(field.Type, allowImports: true) + " " + field.Name);
								if (field.ConstValue != null)
									_sb.Append(" = " + field.ConstValue);
								_sb.AppendLine(";");
							},
							indexer => {
								AppendAttributeString(indexer.Attributes, "\t\t");
								_sb.Append("\t\t");
								if (@class.ClassType != ClassType.Interface)
									_sb.Append(GetAccessString(indexer.Accessibility) + " ");
								var mods = GetModifierString(indexer.Modifiers);
								if (mods != null)
									_sb.Append(mods + " ");
								_sb.Append(GetTypeString(indexer.Type, allowImports: true) + " this[");
								AppendParameterList(indexer.Parameters, parenthesize: false);
								_sb.AppendLine("] {");
								if (indexer.CanRead)
									_sb.AppendLine("\t\t\tget { return " + GetDefaultValue(indexer.Type) + "; }");
								if (indexer.CanWrite)
									_sb.AppendLine("\t\t\tset { }");
								_sb.AppendLine("\t\t}");
							}
						);
					}
					_sb.AppendLine("\t}");
				},
				@delegate => {
					_sb.Append("\tpublic delegate " + GetTypeString(@delegate.ReturnType, allowImports: true) + " " + @delegate.Name);
					AppendParameterList(@delegate.Parameters);
					_sb.AppendLine(";");
				},
				@enum => {
					_sb.AppendLine("\tpublic enum " + @enum.Name + " {");
					foreach (var member in @enum.Members) {
						AppendAttributeString(member.Attributes, "\t\t");
						_sb.Append("\t\t" + member.Name);
						if (member.Value != null)
							_sb.Append(" = " + member.Value);
						_sb.AppendLine(",");
					}
					_sb.AppendLine("\t}");
				}
			);

			_sb.AppendLine("}");

			string content = _sb.ToString();
			_sb.Clear();

			if (_namespaces.Count > 0) {
				foreach (var ns in _namespaces.Where(ns => ns != type.Namespace && !type.Namespace.StartsWith(ns + ".")).OrderBy(ns => ns))
					_sb.AppendLine("using " + ns + ";");
				_sb.AppendLine();
			}

			_sb.Append(content);
		}

		public static string Format(TypeDefinition type) {
			var o = new CodeFormatter();
			o.GenerateCode(type);
			return o._sb.ToString();
		}

		public static string Format(TypeReference type) {
			var o = new CodeFormatter();
			return o.GetTypeString(type, allowImports: false);
		}
	}
}
