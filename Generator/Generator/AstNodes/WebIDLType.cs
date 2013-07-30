using System;
using System.Collections.Generic;
using Generator.ExtensionMethods;

namespace Generator.AstNodes {
	public class WebIDLType {
		public class BuiltinData {
			public BuiltinType BuiltinType { get; private set; }

			public BuiltinData(BuiltinType builtinType) {
				BuiltinType = builtinType;
			}
		}

		public class VoidData {
		}

		public class UnionData {
			public IReadOnlyList<WebIDLType> Members { get; private set; }

			public UnionData(IReadOnlyList<WebIDLType> members) {
				Members = members;
			}
		}

		public class TypeReferenceData {
			public string Target { get; private set; }

			public TypeReferenceData(string target) {
				Target = target;
			}
		}

		public class ArrayData {
			public WebIDLType ElementType { get; private set; }

			public ArrayData(WebIDLType elementType) {
				ElementType = elementType;
			}
		}

		public class SequenceData {
			public WebIDLType ElementType { get; private set; }

			public SequenceData(WebIDLType elementType) {
				ElementType = elementType;
			}
		}

		public class NullableData {
			public WebIDLType UnderlyingType { get; private set; }

			public NullableData(WebIDLType underlyingType) {
				UnderlyingType = underlyingType;
			}
		}

		private BuiltinData _builtin;
		private VoidData _void;
		private UnionData _union;
		private TypeReferenceData _typeReference;
		private ArrayData _array;
		private SequenceData _sequence;
		private NullableData _nullable;

		public static WebIDLType Any() {
			return new WebIDLType { _builtin = new BuiltinData(BuiltinType.Any) };
		}

		public static WebIDLType DOMString() {
			return new WebIDLType { _builtin = new BuiltinData(BuiltinType.DOMString) };
		}

		public static WebIDLType Object() {
			return new WebIDLType { _builtin = new BuiltinData(BuiltinType.Object) };
		}

		public static WebIDLType Date() {
			return new WebIDLType { _builtin = new BuiltinData(BuiltinType.Date) };
		}

		public static WebIDLType Boolean() {
			return new WebIDLType { _builtin = new BuiltinData(BuiltinType.Boolean) };
		}

		public static WebIDLType Byte() {
			return new WebIDLType { _builtin = new BuiltinData(BuiltinType.Byte) };
		}

		public static WebIDLType Octet() {
			return new WebIDLType { _builtin = new BuiltinData(BuiltinType.Octet) };
		}

		public static WebIDLType Float() {
			return new WebIDLType { _builtin = new BuiltinData(BuiltinType.Float) };
		}

		public static WebIDLType UnrestrictedFloat() {
			return new WebIDLType { _builtin = new BuiltinData(BuiltinType.UnrestrictedFloat) };
		}

		public static WebIDLType Double() {
			return new WebIDLType { _builtin = new BuiltinData(BuiltinType.Double) };
		}

		public static WebIDLType UnrestrictedDouble() {
			return new WebIDLType { _builtin = new BuiltinData(BuiltinType.UnrestrictedDouble) };
		}

		public static WebIDLType Short() {
			return new WebIDLType { _builtin = new BuiltinData(BuiltinType.Short) };
		}

		public static WebIDLType UnsignedShort() {
			return new WebIDLType { _builtin = new BuiltinData(BuiltinType.UnsignedShort) };
		}

		public static WebIDLType Long() {
			return new WebIDLType { _builtin = new BuiltinData(BuiltinType.Long) };
		}

		public static WebIDLType UnsignedLong() {
			return new WebIDLType { _builtin = new BuiltinData(BuiltinType.UnsignedLong) };
		}

		public static WebIDLType LongLong() {
			return new WebIDLType { _builtin = new BuiltinData(BuiltinType.LongLong) };
		}

		public static WebIDLType UnsignedLongLong() {
			return new WebIDLType { _builtin = new BuiltinData(BuiltinType.UnsignedLongLong) };
		}

		public static WebIDLType Void() {
			return new WebIDLType { _void = new VoidData() };
		}

		public static WebIDLType Builtin(BuiltinType type) {
			return new WebIDLType { _builtin = new BuiltinData(type) };
		}

		public static WebIDLType Union(IEnumerable<WebIDLType> members) {
			return new WebIDLType { _union = new UnionData(members.AsReadOnlySafe()) };
		}

		public static WebIDLType TypeReference(string target) {
			return new WebIDLType { _typeReference = new TypeReferenceData(target) };
		}

		public static WebIDLType Array(WebIDLType elementType) {
			return new WebIDLType { _array = new ArrayData(elementType) };
		}

		public static WebIDLType Sequence(WebIDLType elementType) {
			return new WebIDLType { _sequence = new SequenceData(elementType) };
		}

		public static WebIDLType Nullable(WebIDLType underlyingType) {
			return new WebIDLType { _nullable = new NullableData(underlyingType) };
		}

		public void Decompose(Action<BuiltinData> builtin, Action<VoidData> @void, Action<UnionData> union, Action<TypeReferenceData> typeReference, Action<ArrayData> array, Action<SequenceData> sequence, Action<NullableData> nullable) {
			if (_builtin != null) {
				if (builtin != null) builtin(_builtin);
			}
			else if (_void != null) {
				if (@void != null) @void(_void);
			}
			else if (_union!= null) {
				if (union != null) union(_union);
			}
			else if (_typeReference != null) {
				if (typeReference != null) typeReference(_typeReference);
			}
			else if (_array != null) {
				if (array != null) array(_array);
			}
			else if (_sequence != null) {
				if (sequence != null) sequence(_sequence);
			}
			else if (_nullable != null) {
				if (nullable != null) nullable(_nullable);
			}
			else {
				throw new InvalidOperationException("Invalid state");
			}
		}

		public T DecomposeWithResult<T>(Func<BuiltinData, T> builtin, Func<VoidData, T> @void, Func<UnionData, T> union, Func<TypeReferenceData, T> typeReference, Func<ArrayData, T> array, Func<SequenceData, T> sequence, Func<NullableData, T> nullable) {
			if (_builtin != null) {
				if (builtin != null)
					return builtin(_builtin);
				else
					throw new InvalidOperationException("Case 'Builtin' not handled");
			}
			else if (_void != null) {
				if (@void != null)
					return @void(_void);
				else
					throw new InvalidOperationException("Case 'Void' not handled");
			}
			else if (_union!= null) {
				if (union != null)
					return union(_union);
				else
					throw new InvalidOperationException("Case 'Union' not handled");
			}
			else if (_typeReference != null) {
				if (typeReference != null)
					return typeReference(_typeReference);
				else
					throw new InvalidOperationException("Case 'TypeReference' not handled");
			}
			else if (_array != null) {
				if (array != null)
					return array(_array);
				else
					throw new InvalidOperationException("Case 'Array' not handled");
			}
			else if (_sequence != null) {
				if (sequence != null)
					return sequence(_sequence);
				else
					throw new InvalidOperationException("Case 'Sequence' not handled");
			}
			else if (_nullable != null) {
				if (nullable != null)
					return nullable(_nullable);
				else
					throw new InvalidOperationException("Case 'Nullable' not handled");
			}
			else {
				throw new InvalidOperationException("Invalid state");
			}
		}
	}
}