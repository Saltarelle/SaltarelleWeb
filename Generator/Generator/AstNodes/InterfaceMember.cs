using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Generator.ExtensionMethods;

namespace Generator.AstNodes {
	public class InterfaceMember {
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

		public class NamedOperationData {
			public string Name { get; private set; }
			public WebIDLType ReturnType { get; private set; }
			public OperationQualifiers Qualifiers { get; private set; }
			public IReadOnlyList<Argument> Arguments { get; private set; }
			public IReadOnlyList<ExtendedAttribute> ExtendedAttributes { get; private set; }

			public NamedOperationData(string name, WebIDLType returnType, OperationQualifiers qualifiers, IReadOnlyList<Argument> arguments, IReadOnlyList<ExtendedAttribute> extendedAttributes) {
				Name = name;
				ReturnType = returnType;
				Qualifiers = qualifiers;
				Arguments = arguments;
				ExtendedAttributes = extendedAttributes;
			}
		}

		public class UnnamedOperationData {
			public WebIDLType ReturnType { get; private set; }
			public OperationQualifiers Qualifiers { get; private set; }
			public IReadOnlyList<Argument> Arguments { get; private set; }
			public IReadOnlyList<ExtendedAttribute> ExtendedAttributes { get; private set; }

			public UnnamedOperationData(WebIDLType returnType, OperationQualifiers qualifiers, IReadOnlyList<Argument> arguments, IReadOnlyList<ExtendedAttribute> extendedAttributes) {
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
		private NamedOperationData _namedOperation;
		private UnnamedOperationData _unnamedOperation;
		private AttributeData _attribute;
		private JsonifierData _jsonifier;

		public static InterfaceMember Const(string name, WebIDLType type, Value value, IEnumerable<ExtendedAttribute> extendedAttributes) {
			return new InterfaceMember { _const = new ConstData(name, type, value, extendedAttributes.AsReadOnlySafe()) };
		}

		public static InterfaceMember NamedOperation(string name, WebIDLType returnType, IEnumerable<Argument> arguments, OperationQualifiers qualifiers, IEnumerable<ExtendedAttribute> extendedAttributes) {
			return new InterfaceMember { _namedOperation = new NamedOperationData(name, returnType, qualifiers, arguments.AsReadOnlySafe(), extendedAttributes.AsReadOnlySafe()) };
		}

		public static InterfaceMember UnnamedOperation(WebIDLType returnType, IEnumerable<Argument> arguments, OperationQualifiers qualifiers, IEnumerable<ExtendedAttribute> extendedAttributes) {
			return new InterfaceMember { _unnamedOperation = new UnnamedOperationData(returnType, qualifiers, arguments.AsReadOnlySafe(), extendedAttributes.AsReadOnlySafe()) };
		}

		public static InterfaceMember Attribute(string name, WebIDLType type, AttributeQualifiers qualifiers, IEnumerable<ExtendedAttribute> extendedAttributes) {
			return new InterfaceMember { _attribute = new AttributeData(name, type, qualifiers, extendedAttributes.AsReadOnlySafe()) };
		}

		public static InterfaceMember Jsonifier(IEnumerable<ExtendedAttribute> extendedAttributes) {
			return new InterfaceMember { _jsonifier = new JsonifierData(extendedAttributes.AsReadOnlySafe()) };
		}

		public void Decompose(Action<ConstData> @const, Action<NamedOperationData> namedOperation, Action<UnnamedOperationData> unnamedOperation, Action<AttributeData> attribute, Action<JsonifierData> jsonifier) {
			if (_const != null) {
				if (@const != null) @const(_const);
			}
			else if (_namedOperation != null) {
				if (namedOperation != null) namedOperation(_namedOperation);
			}
			else if (_unnamedOperation != null) {
				if (unnamedOperation != null) unnamedOperation(_unnamedOperation);
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

		public T DecomposeWithResult<T>(Func<ConstData, T> @const, Func<NamedOperationData, T> namedOperation, Func<UnnamedOperationData, T> unnamedOperation, Func<AttributeData, T> attribute, Func<JsonifierData, T> jsonifier) {
			if (_const != null) {
				if (@const != null)
					return @const(_const);
				else
					throw new InvalidOperationException("Case 'Const' not handled");
			}
			else if (_namedOperation != null) {
				if (namedOperation != null)
					return namedOperation(_namedOperation);
				else
					throw new InvalidOperationException("Case 'NamedOperation' not handled");
			}
			else if (_unnamedOperation != null) {
				if (unnamedOperation != null)
					return unnamedOperation(_unnamedOperation);
				else
					throw new InvalidOperationException("Case 'UnnamedOperation' not handled");
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
