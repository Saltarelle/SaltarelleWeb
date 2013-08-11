using System;
using System.Collections.Generic;
using Generator.ExtensionMethods;

namespace Generator.CSharp {
	public class ClassMember {
		private ClassMember() {}

		public class ConstructorData {
			public Accessibility Accessibility { get; private set; }
			public IReadOnlyList<Attribute> Attributes { get; private set; }
			public IReadOnlyList<Parameter> Parameters { get; private set; }

			public ConstructorData(Accessibility accessibility, IReadOnlyList<Attribute> attributes, IReadOnlyList<Parameter> parameters) {
				Accessibility = accessibility;
				Attributes = attributes;
				Parameters = parameters;
			}
		}

		public class PropertyData {
			public Accessibility Accessibility { get; private set; }
			public IReadOnlyList<Attribute> Attributes { get; private set; }
			public string Name { get; private set; }
			public TypeReference Type { get; private set; }
			public MemberModifiers Modifiers { get; private set; }
			public bool CanRead { get; private set; }
			public bool CanWrite { get; private set; }

			public PropertyData(Accessibility accessibility, IReadOnlyList<Attribute> attributes, string name, TypeReference type, MemberModifiers modifiers, bool canRead, bool canWrite) {
				Accessibility = accessibility;
				Attributes = attributes;
				Name = name;
				Type = type;
				Modifiers = modifiers;
				CanRead = canRead;
				CanWrite = canWrite;
			}
		}

		public class MethodData {
			public Accessibility Accessibility { get; private set; }
			public IReadOnlyList<Attribute> Attributes { get; private set; }
			public string Name { get; private set; }
			public TypeReference ReturnType { get; private set; }
			public MemberModifiers Modifiers { get; private set; }
			public IReadOnlyList<Parameter> Parameters { get; private set; }

			public MethodData(Accessibility accessibility, IReadOnlyList<Attribute> attributes, string name, TypeReference returnType, MemberModifiers modifiers, IReadOnlyList<Parameter> parameters) {
				Accessibility = accessibility;
				Attributes = attributes;
				Name = name;
				ReturnType = returnType;
				Modifiers = modifiers;
				Parameters = parameters;
			}
		}

		public class FieldData {
			public Accessibility Accessibility { get; private set; }
			public IReadOnlyList<Attribute> Attributes { get; private set; }
			public string Name { get; private set; }
			public TypeReference Type { get; private set; }
			public MemberModifiers Modifiers { get; private set; }
			public string ConstValue { get; private set; }

			public FieldData(Accessibility accessibility, IReadOnlyList<Attribute> attributes, string name, TypeReference type, MemberModifiers modifiers, string constValue) {
				Accessibility = accessibility;
				Attributes = attributes;
				Name = name;
				Type = type;
				Modifiers = modifiers;
				ConstValue = constValue;
			}
		}

		public class IndexerData {
			public Accessibility Accessibility { get; private set; }
			public IReadOnlyList<Attribute> Attributes { get; private set; }
			public TypeReference Type { get; private set; }
			public MemberModifiers Modifiers { get; private set; }
			public IReadOnlyList<Parameter> Parameters { get; private set; }
			public bool CanRead { get; private set; }
			public bool CanWrite { get; private set; }

			public IndexerData(Accessibility accessibility, IReadOnlyList<Attribute> attributes, TypeReference type, MemberModifiers modifiers, IReadOnlyList<Parameter> parameters, bool canRead, bool canWrite) {
				Accessibility = accessibility;
				Attributes = attributes;
				Type = type;
				Modifiers = modifiers;
				Parameters = parameters;
				CanRead = canRead;
				CanWrite = canWrite;
			}
		}

		private ConstructorData _constructor;
		private PropertyData _property;
		private MethodData _method;
		private FieldData _field;
		private IndexerData _indexer;

		public void Decompose(Action<ConstructorData> constructor, Action<PropertyData> property, Action<MethodData> method, Action<FieldData> field, Action<IndexerData> indexer) {
			if (_constructor != null) {
				if (constructor != null) constructor(_constructor);
			}
			else if (_property != null) {
				if (property != null) property(_property);
			}
			else if (_method != null) {
				if (method != null) method(_method);
			}
			else if (_field != null) {
				if (field != null) field(_field);
			}
			else if (_indexer != null) {
				if (indexer != null) indexer(_indexer);
			}
			else {
				throw new InvalidOperationException("Invalid state");
			}
		}

		public T DecomposeWithResult<T>(Func<ConstructorData, T> constructor, Func<PropertyData, T> property, Func<MethodData, T> method, Func<FieldData, T> field, Func<IndexerData, T> indexer) {
			if (_constructor != null) {
				if (constructor != null)
					return constructor(_constructor);
				else
					throw new InvalidOperationException("Case 'Constructor' not handled");
			}
			else if (_property != null) {
				if (property != null)
					return property(_property);
				else
					throw new InvalidOperationException("Case 'Property' not handled");
			}
			else if (_method != null) {
				if (method != null)
					return method(_method);
				else
					throw new InvalidOperationException("Case 'Method' not handled");
			}
			else if (_field != null) {
				if (field != null)
					return field(_field);
				else
					throw new InvalidOperationException("Case 'Field' not handled");
			}
			else if (_indexer != null) {
				if (indexer != null)
					return indexer(_indexer);
				else
					throw new InvalidOperationException("Case 'Indexer' not handled");
			}
			else {
				throw new InvalidOperationException("Invalid state");
			}
		}

		public static ClassMember Constructor(Accessibility accessibility, IEnumerable<Parameter> parameters, IEnumerable<Attribute> attributes) {
			return new ClassMember { _constructor = new ConstructorData(accessibility, attributes.AsReadOnlySafe(), parameters.AsReadOnlySafe()) };
		}

		public static ClassMember Property(Accessibility accessibility, string name, TypeReference type, MemberModifiers modifiers, bool canRead, bool canWrite, IEnumerable<Attribute> attributes) {
			return new ClassMember { _property = new PropertyData(accessibility, attributes.AsReadOnlySafe(), name, type, modifiers, canRead, canWrite) };
		}

		public static ClassMember Method(Accessibility accessibility, string name, TypeReference returnType, MemberModifiers modifiers, IEnumerable<Parameter> parameters, IEnumerable<Attribute> attributes) {
			return new ClassMember { _method = new MethodData(accessibility, attributes.AsReadOnlySafe(), name, returnType, modifiers, parameters.AsReadOnlySafe()) };
		}

		public static ClassMember Field(Accessibility accessibility, string name, TypeReference type, MemberModifiers modifiers, string constValue, IEnumerable<Attribute> attributes) {
			return new ClassMember { _field = new FieldData(accessibility, attributes.AsReadOnlySafe(), name, type, modifiers, constValue) };
		}

		public static ClassMember Indexer(Accessibility accessibility, TypeReference type, MemberModifiers modifiers, IEnumerable<Parameter> parameters, bool canRead, bool canWrite, IEnumerable<Attribute> attributes) {
			return new ClassMember { _indexer = new IndexerData(accessibility, attributes.AsReadOnlySafe(), type, modifiers, parameters.AsReadOnlySafe(), canRead, canWrite) };
		}
	}
}
