using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Generator.AstNodes;

namespace Generator {
	public class WebIDLFormatter {
		private StringBuilder _sb = new StringBuilder();

		private enum ExtendedAttributeMode {
			Type,
			Member,
			Argument
		}

		private void Visit(IEnumerable<ExtendedAttribute> attributes, ExtendedAttributeMode mode) {
			bool any = false;
			foreach (var attr in attributes) {
				_sb.Append(any ? ", " : "[");
				any = true;
				Visit(attr);
			}
			if (any) {
				_sb.Append("]");
				if (mode != ExtendedAttributeMode.Argument)
					_sb.AppendLine();
				if (mode == ExtendedAttributeMode.Member)
					_sb.Append("\t");
				else if (mode == ExtendedAttributeMode.Argument)
					_sb.Append(" ");
			}
		}

		private void Visit(IEnumerable<Argument> arguments) {
			bool any = false;
			_sb.Append("(");
			foreach (var arg in arguments) {
				if (any)
					_sb.Append(", ");
				any = true;
				Visit(arg);
			}
			_sb.Append(")");
		}

		private void Visit(IEnumerable<InterfaceMember> members) {
			_sb.AppendLine("{");
			foreach (var m in members) {
				_sb.Append("\t");
				Visit(m);
				_sb.AppendLine();
			}
			_sb.Append("}");
		}

		private void Visit(IEnumerable<DictionaryMember> members) {
			_sb.AppendLine("{");
			foreach (var m in members) {
				_sb.Append("\t");
				Visit(m);
				_sb.AppendLine();
			}
			_sb.Append("}");
		}

		private void Visit(IEnumerable<ExceptionMember> members) {
			_sb.AppendLine("{");
			foreach (var m in members) {
				_sb.Append("\t");
				Visit(m);
				_sb.AppendLine();
			}
			_sb.AppendLine(";");
		}

		private void Visit(ExtendedAttribute attribute) {
			attribute.Decompose(
				noArgs => {
					_sb.Append(noArgs.AttributeName);
				},
				argList => {
					_sb.Append(argList.AttributeName);
					Visit(argList.Arguments);
				},
				namedArgList => {
					_sb.Append(namedArgList.AttributeName + "=" + namedArgList.ArgListName);
					Visit(namedArgList.Arguments);
				},
				ident => {
					_sb.Append(ident.AttributeName + "=" + ident.Ident);
				},
				value => {
					_sb.Append(value.AttributeName + "=");
					Visit(value.Value);
				}
			);
		}

		private void Visit(InterfaceMember member) {
			member.Decompose(
				@const => {
					Visit(@const.ExtendedAttributes, ExtendedAttributeMode.Member);
					_sb.Append("const ");
					Visit(@const.Type);
					_sb.Append(" " + @const.Name + " = ");
					Visit(@const.Value);
				},
				namedOperation => {
					Visit(namedOperation.ExtendedAttributes, ExtendedAttributeMode.Member);
					Visit(namedOperation.Qualifiers);
					Visit(namedOperation.ReturnType);
					_sb.Append(" " + namedOperation.Name);
					Visit(namedOperation.Arguments);
				},
				unnamedOperation => {
					Visit(unnamedOperation.ExtendedAttributes, ExtendedAttributeMode.Member);
					Visit(unnamedOperation.Qualifiers);
					Visit(unnamedOperation.ReturnType);
					Visit(unnamedOperation.Arguments);
				},
				attribute => {
					Visit(attribute.ExtendedAttributes, ExtendedAttributeMode.Member);
					Visit(attribute.Qualifiers);
					_sb.Append("attribute ");
					Visit(attribute.Type);
					_sb.Append(" " + attribute.Name);
				},
				jsonifier => {
					Visit(jsonifier.ExtendedAttributes, ExtendedAttributeMode.Member);
					_sb.Append("jsonifier");
				}
			);
			_sb.AppendLine(";");
		}

		private void Visit(DictionaryMember member) {
			Visit(member.ExtendedAttributes, ExtendedAttributeMode.Member);
			Visit(member.Type);
			_sb.Append(" " + member.Name);
			if (member.Default != null) {
				_sb.Append(" = ");
				Visit(member.Default);
			}
			_sb.AppendLine(";");
		}

		private void Visit(ExceptionMember member) {
			member.Decompose(
				@const => {
					Visit(@const.ExtendedAttributes, ExtendedAttributeMode.Member);
					_sb.Append("const ");
					Visit(@const.Type);
					_sb.Append(" " + @const.Name + " = ");
					Visit(@const.Value);
				},
				field => {
					Visit(field.ExtendedAttributes, ExtendedAttributeMode.Member);
					Visit(field.Type);
					_sb.Append(" " + field.Name);
				}
			);
			_sb.Append(";");
		}

		private void Visit(WebIDLType type) {
			type.Decompose(
				builtin => {
					switch (builtin.BuiltinType) {
						case BuiltinType.Any:                _sb.Append("any");                 break;
						case BuiltinType.DOMString:          _sb.Append("DOMString");           break;
						case BuiltinType.Object:             _sb.Append("Object");              break;
						case BuiltinType.Date:               _sb.Append("Date");                break;
						case BuiltinType.Boolean:            _sb.Append("boolean");             break;
						case BuiltinType.Byte:               _sb.Append("byte");                break;
						case BuiltinType.Octet:              _sb.Append("octet");               break;
						case BuiltinType.Float:              _sb.Append("float");               break;
						case BuiltinType.UnrestrictedFloat:  _sb.Append("unrestricted float");  break;
						case BuiltinType.Double:             _sb.Append("double");              break;
						case BuiltinType.UnrestrictedDouble: _sb.Append("unrestricted double"); break;
						case BuiltinType.Short:              _sb.Append("short");               break;
						case BuiltinType.UnsignedShort:      _sb.Append("unsigned short");      break;
						case BuiltinType.Long:               _sb.Append("long");                break;
						case BuiltinType.UnsignedLong:       _sb.Append("unsigned long");       break;
						case BuiltinType.LongLong:           _sb.Append("long long");           break;
						case BuiltinType.UnsignedLongLong:   _sb.Append("unsigned long long"); break;
						default: throw new ArgumentException("Invalid builtin type " + builtin.BuiltinType);
					}
				},
				@void => {
					_sb.Append("void");
				},
				union => {
					_sb.Append("(");
					for (int i = 0; i < union.Members.Count; i++) {
						if (i > 0)
							_sb.Append(" or ");
						Visit(union.Members[i]);
					}
					_sb.Append(")");
				},
				typeReference => {
					_sb.Append(typeReference.Target);
				},
				array => {
					Visit(array.ElementType);
					_sb.Append("[]");
				},
				sequence => {
					_sb.Append("sequence<");
					Visit(sequence.ElementType);
					_sb.Append(">");
				},
				nullable => {
					Visit(nullable.UnderlyingType);
					_sb.Append("?");
				}
			);
		}

		private void Visit(Argument argument) {
			argument.Decompose(
				required => {
					Visit(required.ExtendedAttributes, ExtendedAttributeMode.Argument);
					Visit(required.Type);
					_sb.Append(" " + required.Name);
				},
				optional => {
					Visit(optional.ExtendedAttributes, ExtendedAttributeMode.Argument);
					_sb.Append("optional ");
					Visit(optional.Type);
					_sb.Append(" " + optional.Name);
					if (optional.DefaultValue != null) {
						_sb.Append(" = ");
						Visit(optional.DefaultValue);
					}
				},
				ellipsis => {
					Visit(ellipsis.ExtendedAttributes, ExtendedAttributeMode.Argument);
					Visit(ellipsis.Type);
					_sb.Append("... " + ellipsis.Name);
				}
			);
		}

		private void Visit(Value value) {
			value.Decompose(
				@int => {
					_sb.Append(@int.ToString(CultureInfo.InvariantCulture));
				},
				@float => {
					_sb.Append(@float.ToString(CultureInfo.InvariantCulture));
				},
				@string => {
					_sb.Append("\"" + @string + "\"");
				},
				special => {
					switch (special.Value) {
						case SpecialValue.True:             _sb.Append("true");      break;
						case SpecialValue.False:            _sb.Append("false");     break;
						case SpecialValue.Null:             _sb.Append("null");      break;
						case SpecialValue.PositiveInfinity: _sb.Append("Infinity");  break;
						case SpecialValue.NegativeInfinity: _sb.Append("-Infinity"); break;
						case SpecialValue.NaN:              _sb.Append("NaN");       break;
						default: throw new ArgumentException("Invalid special value " + special.Value);
					}
				}
			);
		}

		private void Visit(AttributeQualifiers qualifiers) {
			if ((qualifiers & AttributeQualifiers.Stringifier) != 0)
				_sb.Append("stringifier ");
			if ((qualifiers & AttributeQualifiers.Static) != 0)
				_sb.Append("static ");
			if ((qualifiers & AttributeQualifiers.Inherit) != 0)
				_sb.Append("inherit ");
			if ((qualifiers & AttributeQualifiers.ReadOnly) != 0)
				_sb.Append("readonly ");
		}

		private void Visit(OperationQualifiers qualifiers) {
			if ((qualifiers & OperationQualifiers.Stringifier) != 0)
				_sb.Append("stringifier ");
			if ((qualifiers & OperationQualifiers.Static) != 0)
				_sb.Append("static ");

			if ((qualifiers & OperationQualifiers.Getter) != 0)
				_sb.Append("getter ");
			if ((qualifiers & OperationQualifiers.Setter) != 0)
				_sb.Append("setter ");
			if ((qualifiers & OperationQualifiers.Creator) != 0)
				_sb.Append("creator ");
			if ((qualifiers & OperationQualifiers.Deleter) != 0)
				_sb.Append("deleter ");
			if ((qualifiers & OperationQualifiers.LegacyCaller) != 0)
				_sb.Append("legacycaller ");
		}

		private void Visit(Definition def) {
			def.Decompose(
				@interface => {
					Visit(@interface.ExtendedAttributes, ExtendedAttributeMode.Type);
					_sb.Append("interface " + @interface.Name + " ");
					if (@interface.Base != null)
						_sb.Append(": " + @interface.Base + " ");
					Visit(@interface.Members);
				},
				callbackInterface => {
					Visit(callbackInterface.ExtendedAttributes, ExtendedAttributeMode.Type);
					_sb.Append("callback interface " + callbackInterface.Name + " ");
					if (callbackInterface.Base != null)
						_sb.Append(": " + callbackInterface.Base + " ");
					Visit(callbackInterface.Members);
				},
				partialInterface => {
					Visit(partialInterface.ExtendedAttributes, ExtendedAttributeMode.Type);
					_sb.Append("partial interface " + partialInterface.Name + " ");
					Visit(partialInterface.Members);
				},
				dictionary => {
					Visit(dictionary.ExtendedAttributes, ExtendedAttributeMode.Type);
					_sb.Append("dictionary " + dictionary.Name + " ");
					if (dictionary.Base != null)
						_sb.Append(": " + dictionary.Base + " ");
					Visit(dictionary.Members);
				},
				partialDictionary => {
					Visit(partialDictionary.ExtendedAttributes, ExtendedAttributeMode.Type);
					_sb.AppendLine("partial dictionary " + partialDictionary.Name + " ");
					Visit(partialDictionary.Members);
				},
				callback => {
					Visit(callback.ExtendedAttributes, ExtendedAttributeMode.Type);
					_sb.Append("callback " + callback.Name + " = ");
					Visit(callback.ReturnType);
					_sb.Append(" ");
					Visit(callback.Arguments);
				},
				implements => {
					_sb.Append(implements.ImplementingType + " implements " + implements.ImplementedType);
				},
				exception => {
					Visit(exception.ExtendedAttributes, ExtendedAttributeMode.Type);
					_sb.Append("exception " + exception.Name + " ");
					if (exception.Base != null)
						_sb.Append(": " + exception.Base + " ");
					Visit(exception.Members);
				},
				typedef => {
					_sb.Append("typedef ");
					Visit(typedef.TypeExtendedAttributes, ExtendedAttributeMode.Type);
					Visit(typedef.ReferencedType);
					_sb.Append(" " + typedef.Name);
				},
				@enum => {
					Visit(@enum.ExtendedAttributes, ExtendedAttributeMode.Type);
					_sb.AppendLine("enum " + @enum.Name + " {");
					for (int i = 0 ; i < @enum.Values.Count; i++) {
						_sb.Append("\t\"" + @enum.Values[i] + "\"");
						if (i < @enum.Values.Count - 1)
							_sb.Append(",");
						_sb.AppendLine();
					}
					_sb.Append("}");
				},
				interfaceDeclaration => {
					_sb.Append("interface " + interfaceDeclaration.Name);
				}
			);
			_sb.Append(";");
		}
		
		private void Visit(Definitions definitions) {
			foreach (var def in definitions.Items) {
				Visit(def);
				_sb.AppendLine().AppendLine();
			}
		}

		public static string Format(Definitions definitions) {
			var f = new WebIDLFormatter(); 
			f.Visit(definitions);
			return f._sb.ToString();
		}
	}
}
