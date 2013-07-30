using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Generator.ExtensionMethods;

namespace Generator.AstNodes {
	public class ExceptionMember {
		public class ConstData {
			public string Name { get; private set; }
			public WebIDLType Type { get; private set; }
			public Value Value { get; private set; }
			public IReadOnlyList<ExtendedAttribute> ExtendedAttributes { get; private set; }

			public ConstData(string name, WebIDLType type, Value value, IReadOnlyList<ExtendedAttribute> extendedAttributes) {
				Name = name;
				Type = type;
				Value = value;
				ExtendedAttributes = extendedAttributes;
			}
		}

		public class FieldData {
			public string Name { get; private set; }
			public WebIDLType Type { get; private set; }
			public IReadOnlyList<ExtendedAttribute> ExtendedAttributes { get; private set; }

			public FieldData(string name, WebIDLType type, IReadOnlyList<ExtendedAttribute> extendedAttributes) {
				Name = name;
				Type = type;
				ExtendedAttributes = extendedAttributes;
			}
		}

		private ConstData _const;
		private FieldData _field;

		public static ExceptionMember Const(string name, WebIDLType type, Value value, IEnumerable<ExtendedAttribute> extendedAttributes) {
			return new ExceptionMember { _const = new ConstData(name, type, value, extendedAttributes.AsReadOnlySafe()) };
		}

		public static ExceptionMember Field(string name, WebIDLType type, IEnumerable<ExtendedAttribute> extendedAttributes) {
			return new ExceptionMember { _field = new FieldData(name, type, extendedAttributes.AsReadOnlySafe()) };
		}

		public void Decompose(Action<ConstData> @const, Action<FieldData> field) {
			if (_const != null) {
				if (@const != null) @const(_const);
			}
			else if (_field != null) {
				if (field != null) field(_field);
			}
			else {
				throw new InvalidOperationException("Invalid state");
			}
		}

		public T Decompose<T>(Func<ConstData, T> @const, Func<FieldData, T> field) {
			if (_const != null) {
				if (@const != null)
					return @const(_const);
				else
					throw new InvalidOperationException("Case 'Const' not handled");
			}
			else if (_field != null) {
				if (field != null)
					return field(_field);
				else
					throw new InvalidOperationException("Case 'Field' not handled");
			}
			else {
				throw new InvalidOperationException("Invalid state");
			}
		}
	}
}
