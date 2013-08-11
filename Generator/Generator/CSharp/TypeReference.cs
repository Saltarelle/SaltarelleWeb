using System;
using System.Collections.Generic;
using Generator.ExtensionMethods;

namespace Generator.CSharp {
	public class TypeReference {
		private TypeReference() {}

		public class KeywordData {
			public string Keyword { get; private set; }

			public KeywordData(string keyword) {
				Keyword = keyword;
			}
		}

		public class NamedTypeData {
			public string Name { get; private set; }
			public string Namespace { get; private set; }
			public IReadOnlyList<TypeReference> TypeArguments { get; private set; }

			public NamedTypeData(string name, string @namespace, IReadOnlyList<TypeReference> typeArguments) {
				Name = name;
				Namespace = @namespace;
				TypeArguments = typeArguments; 
			}
		}

		public class ArrayData {
			public TypeReference ElementType { get; private set; }

			public ArrayData(TypeReference elementType) {
				ElementType = elementType;
			}
		}

		public class NullableData {
			public TypeReference UnderlyingType { get; private set; }

			public NullableData(TypeReference underlyingType) {
				UnderlyingType = underlyingType;
			}
		}

		private KeywordData _keyword;
		private NamedTypeData _namedType;
		private ArrayData _array;
		private NullableData _nullable;

		public void Decompose(Action<KeywordData> keyword, Action<NamedTypeData> namedType, Action<ArrayData> array, Action<NullableData> nullable) {
			if (_keyword != null) {
				if (keyword != null) keyword(_keyword);
			}
			else if (_namedType != null) {
				if (namedType != null) namedType(_namedType);
			}
			else if (_array != null) {
				if (array != null) array(_array);
			}
			else if (_nullable != null) {
				if (nullable != null) nullable(_nullable);
			}
			else {
				throw new InvalidOperationException("Invalid state");
			}
		}

		public T DecomposeWithResult<T>(Func<KeywordData, T> keyword, Func<NamedTypeData, T> namedType, Func<ArrayData, T> array, Func<NullableData, T> nullable) {
			if (_keyword != null) {
				if (keyword != null)
					return keyword(_keyword);
				else
					throw new InvalidOperationException("Case 'Keyword' not handled");
			}
			else if (_namedType != null) {
				if (namedType != null)
					return namedType(_namedType);
				else
					throw new InvalidOperationException("Case 'NamedType' not handled");
			}
			else if (_array != null) {
				if (array != null)
					return array(_array);
				else
					throw new InvalidOperationException("Case 'Array' not handled");
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

		public static TypeReference Keyword(string keyword) {
			return new TypeReference { _keyword = new KeywordData(keyword) };
		}

		public static TypeReference NamedType(string name, string @namespace) {
			return new TypeReference { _namedType = new NamedTypeData(name, @namespace, new TypeReference[0]) };
		}

		public static TypeReference GenericNamedType(string name, string @namespace, IEnumerable<TypeReference> typeArguments) {
			return new TypeReference { _namedType = new NamedTypeData(name, @namespace, typeArguments.AsReadOnlySafe()) };
		}

		public static TypeReference Array(TypeReference elementType) {
			return new TypeReference { _array = new ArrayData(elementType) };
		}

		public static TypeReference Nullable(TypeReference underlyingType) {
			return new TypeReference { _nullable = new NullableData(underlyingType) };
		}
	}
}
