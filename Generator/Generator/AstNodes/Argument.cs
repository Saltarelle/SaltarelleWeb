using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Generator.ExtensionMethods;

namespace Generator.AstNodes {
	public class Argument {
		public class RequiredData {
			public string Name { get; private set; }
			public WebIDLType Type { get; private set; }
			public IReadOnlyList<ExtendedAttribute> ExtendedAttributes { get; private set; }

			public RequiredData(string name, WebIDLType type, IReadOnlyList<ExtendedAttribute> extendedAttributes) {
				Name = name;
				Type = type;
				ExtendedAttributes = extendedAttributes;
			}
		}

		public class OptionalData {
			public string Name { get; private set; }
			public WebIDLType Type { get; private set; }
			public Value DefaultValue { get; private set; }
			public IReadOnlyList<ExtendedAttribute> ExtendedAttributes { get; private set; }

			public OptionalData(string name, WebIDLType type, Value defaultValue, IReadOnlyList<ExtendedAttribute> extendedAttributes) {
				Name = name;
				Type = type;
				DefaultValue = defaultValue;
				ExtendedAttributes = extendedAttributes;
			}
		}

		public class EllipsisData {
			public string Name { get; private set; }
			public WebIDLType Type { get; private set; }
			public IReadOnlyList<ExtendedAttribute> ExtendedAttributes { get; private set; }

			public EllipsisData(string name, WebIDLType type, IReadOnlyList<ExtendedAttribute> extendedAttributes) {
				Name = name;
				Type = type;
				ExtendedAttributes = extendedAttributes;
			}
		}

		private RequiredData _required;
		private OptionalData _optional;
		private EllipsisData _ellipsis;

		public static Argument Required(string name, WebIDLType type, IEnumerable<ExtendedAttribute> extendedAttributes) {
			return new Argument { _required = new RequiredData(name, type, extendedAttributes.AsReadOnlySafe()) };
		}

		public static Argument Optional(string name, WebIDLType type, Value defaultValue, IEnumerable<ExtendedAttribute> extendedAttributes) {
			return new Argument { _optional = new OptionalData(name, type, defaultValue, extendedAttributes.AsReadOnlySafe()) };
		}

		public static Argument Ellipsis(string name, WebIDLType type, IEnumerable<ExtendedAttribute> extendedAttributes) {
			return new Argument { _ellipsis = new EllipsisData(name, type, extendedAttributes.AsReadOnlySafe()) };
		}

		public void Decompose(Action<RequiredData> required, Action<OptionalData> optional, Action<EllipsisData> ellipsis) {
			if (_required != null) {
				if (required != null) required(_required);
			}
			else if (_optional != null) {
				if (optional != null) optional(_optional);
			}
			else if (_ellipsis != null) {
				if (ellipsis != null) ellipsis(_ellipsis);
			}
		}

		public T DecomposeWithResult<T>(Func<RequiredData, T> required, Func<OptionalData, T> optional, Func<EllipsisData, T> ellipsis) {
			if (_required != null) {
				if (required != null)
					return required(_required);
				else
					throw new InvalidOperationException("Case 'Required' not handled");
			}
			else if (_optional != null) {
				if (optional != null)
					return optional(_optional);
				else
					throw new InvalidOperationException("Case 'Optional' not handled");
			}
			else if (_ellipsis != null) {
				if (ellipsis != null)
					return ellipsis(_ellipsis);
				else
					throw new InvalidOperationException("Case 'Ellipsis' not handled");
			}
			else {
				throw new InvalidOperationException("Invalid state");
			}
		}
	}
}
