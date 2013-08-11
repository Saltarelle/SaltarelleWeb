using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Generator.ExtensionMethods;

namespace Generator.CSharp {
	public enum ClassType {
		Class,
		Struct,
		Interface,
	}

	public class TypeDefinition {
		private TypeDefinition() {}

		public abstract class BaseData {
			public string Name { get; private set; }
			public string Namespace { get; private set; }
			public IReadOnlyList<Attribute> Attributes { get; private set; }

			protected BaseData(string name, string @namespace, IReadOnlyList<Attribute> attributes) {
				Name = name;
				Namespace = @namespace;
				Attributes = attributes;
			}
		}

		public class ClassData : BaseData {
			public ClassType ClassType { get; private set; }
			public ClassModifiers Modifiers { get; private set; }
			public IReadOnlyList<TypeReference> BaseTypes { get; private set; }
			public IReadOnlyList<ClassMember> Members { get; private set; }

			public ClassData(ClassType classType, ClassModifiers modifiers, string name, string @namespace, IReadOnlyList<Attribute> attributes, IReadOnlyList<TypeReference> baseTypes, IReadOnlyList<ClassMember> members) : base(name, @namespace, attributes) {
				ClassType = classType;
				Modifiers = modifiers;
				BaseTypes = baseTypes;
				Members = members;
			}
		}

		public class DelegateData : BaseData {
			public TypeReference ReturnType { get; private set; }
			public IReadOnlyList<Parameter> Parameters { get; private set; }

			public DelegateData(string name, string @namespace, IReadOnlyList<Attribute> attributes, TypeReference returnType, IReadOnlyList<Parameter> parameters) : base(name, @namespace, attributes) {
				ReturnType = returnType;
				Parameters = parameters;
			}
		}

		public class EnumData : BaseData {
			public IReadOnlyList<EnumMember> Members { get; private set; }

			public EnumData(string name, string @namespace, IReadOnlyList<Attribute> attributes, IReadOnlyList<EnumMember> members) : base(name, @namespace, attributes) {
				Members = members;
			}
		}

		private ClassData _class;
		private DelegateData _delegate;
		private EnumData _enum;

		public string Name {
			get { return (_class ?? _delegate ?? (BaseData)_enum).Name; }
		}

		public string Namespace {
			get { return (_class ?? _delegate ?? (BaseData)_enum).Namespace; }
		}

		public IReadOnlyList<Attribute> Attributes {
			get { return (_class ?? _delegate ?? (BaseData)_enum).Attributes; }
		}

		public void Decompose(Action<ClassData> @class, Action<DelegateData> @delegate, Action<EnumData> @enum) {
			if (_class != null) {
				if (@class != null) @class(_class);
			}
			else if (_delegate != null) {
				if (@delegate != null) @delegate(_delegate);
			}
			else if (_enum != null) {
				if (@enum != null) @enum(_enum);
			}
			else {
				throw new InvalidOperationException("Invalid state");
			}
		}

		public T DecomposeWithResult<T>(Func<ClassData, T> @class, Func<DelegateData, T> @delegate, Func<EnumData, T> @enum) {
			if (_class != null) {
				if (@class != null)
					return @class(_class);
				else
					throw new InvalidOperationException("Case 'Class' not handled");
			}
			else if (_delegate != null) {
				if (@delegate != null)
					return @delegate(_delegate);
				else
					throw new InvalidOperationException("Case 'Delegate' not handled");
			}
			else if (_enum != null) {
				if (@enum != null)
					return @enum(_enum);
				else
					throw new InvalidOperationException("Case 'Enum' not handled");
			}
			else {
				throw new InvalidOperationException("Invalid state");
			}
		}

		public static TypeDefinition Class(ClassType classType, ClassModifiers modifiers, string name, string @namespace, IEnumerable<TypeReference> baseTypes, IEnumerable<ClassMember> members, IEnumerable<Attribute> attributes)  {
			return new TypeDefinition { _class = new ClassData(classType, modifiers, name, @namespace, attributes.AsReadOnlySafe(), baseTypes.AsReadOnlySafe(), members.AsReadOnlySafe()) };
		}

		public static TypeDefinition Delegate(string name, string @namespace, TypeReference returnType, IEnumerable<Parameter> parameters, IEnumerable<Attribute> attributes)  {
			return new TypeDefinition { _delegate = new DelegateData(name, @namespace, attributes.AsReadOnlySafe(), returnType, parameters.AsReadOnlySafe()) };
		}

		public static TypeDefinition Enum(string name, string @namespace, IEnumerable<EnumMember> members, IEnumerable<Attribute> attributes)  {
			return new TypeDefinition { _enum = new EnumData(name, @namespace, attributes.AsReadOnlySafe(), members.AsReadOnlySafe()) };
		}
	}
}
