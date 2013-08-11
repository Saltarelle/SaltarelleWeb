using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Generator.ExtensionMethods;

namespace Generator.AstNodes {
	public class InterfaceMember {
		private InterfaceMember() {}

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

		public class OperationData {
			public string Name { get; private set; }
			public WebIDLType ReturnType { get; private set; }
			public OperationQualifiers Qualifiers { get; private set; }
			public IReadOnlyList<Argument> Arguments { get; private set; }
			public IReadOnlyList<ExtendedAttribute> ExtendedAttributes { get; private set; }

			public OperationData(string name, WebIDLType returnType, OperationQualifiers qualifiers, IReadOnlyList<Argument> arguments, IReadOnlyList<ExtendedAttribute> extendedAttributes) {
				Name = name;
				ReturnType = returnType;
				Qualifiers = qualifiers;
				Arguments = arguments;
				ExtendedAttributes = extendedAttributes;
			}
		}

		public class AttributeData {
			public string Name { get; private set; }
			public WebIDLType Type { get; private set; }
			public AttributeQualifiers Qualifiers { get; private set; }
			public IReadOnlyList<ExtendedAttribute> ExtendedAttributes { get; private set; }

			public AttributeData(string name, WebIDLType type, AttributeQualifiers qualifiers, IReadOnlyList<ExtendedAttribute> extendedAttributes) {
				Name = name;
				Type = type;
				Qualifiers = qualifiers;
				ExtendedAttributes = extendedAttributes;
			}
		}

		public class JsonifierData {
			public IReadOnlyList<ExtendedAttribute> ExtendedAttributes { get; private set; }

			public JsonifierData(IReadOnlyList<ExtendedAttribute> extendedAttributes) {
				ExtendedAttributes = extendedAttributes;
			}
		}

		private ConstData _const;
		private OperationData _operation;
		private AttributeData _attribute;
		private JsonifierData _jsonifier;

		public static InterfaceMember Const(string name, WebIDLType type, Value value, IEnumerable<ExtendedAttribute> extendedAttributes) {
			return new InterfaceMember { _const = new ConstData(name, type, value, extendedAttributes.AsReadOnlySafe()) };
		}

		public static InterfaceMember Operation(string name, WebIDLType returnType, IEnumerable<Argument> arguments, OperationQualifiers qualifiers, IEnumerable<ExtendedAttribute> extendedAttributes) {
			return new InterfaceMember { _operation = new OperationData(name, returnType, qualifiers, arguments.AsReadOnlySafe(), extendedAttributes.AsReadOnlySafe()) };
		}

		public static InterfaceMember Attribute(string name, WebIDLType type, AttributeQualifiers qualifiers, IEnumerable<ExtendedAttribute> extendedAttributes) {
			return new InterfaceMember { _attribute = new AttributeData(name, type, qualifiers, extendedAttributes.AsReadOnlySafe()) };
		}

		public static InterfaceMember Jsonifier(IEnumerable<ExtendedAttribute> extendedAttributes) {
			return new InterfaceMember { _jsonifier = new JsonifierData(extendedAttributes.AsReadOnlySafe()) };
		}

		public void Decompose(Action<ConstData> @const, Action<OperationData> operation, Action<AttributeData> attribute, Action<JsonifierData> jsonifier) {
			if (_const != null) {
				if (@const != null) @const(_const);
			}
			else if (_operation != null) {
				if (operation != null) operation(_operation);
			}
			else if (_attribute != null) {
				if (attribute != null) attribute(_attribute);
			}
			else if (_jsonifier != null) {
				if (jsonifier != null) jsonifier(_jsonifier);
			}
			else {
				throw new InvalidOperationException("Invalid state");
			}
		}

		public T DecomposeWithResult<T>(Func<ConstData, T> @const, Func<OperationData, T> operation, Func<AttributeData, T> attribute, Func<JsonifierData, T> jsonifier) {
			if (_const != null) {
				if (@const != null)
					return @const(_const);
				else
					throw new InvalidOperationException("Case 'Const' not handled");
			}
			else if (_operation != null) {
				if (operation != null)
					return operation(_operation);
				else
					throw new InvalidOperationException("Case 'Operation' not handled");
			}
			else if (_attribute != null) {
				if (attribute != null)
					return attribute(_attribute);
				else
					throw new InvalidOperationException("Case 'Attribute' not handled");
			}
			else if (_jsonifier != null) {
				if (jsonifier != null)
					return jsonifier(_jsonifier);
				else
					throw new InvalidOperationException("Case 'Jsonifier' not handled");
			}
			else {
				throw new InvalidOperationException("Invalid state");
			}
		}
	}
}
