using System;
using System.Collections.Generic;
using Generator.ExtensionMethods;

namespace Generator.CSharp {
	public class Attribute {
		private Attribute() {}

		public string AttributeTypeName { get; private set; }
		public string AttributeTypeNamespace { get; private set; }
		public IReadOnlyList<string> PositionalArguments { get; private set; }
		public IReadOnlyList<Tuple<string, string>> NamedArguments { get; private set; }

		public static Attribute Create(string attributeTypeName, string attributeTypeNamespace, IEnumerable<string> positionalArguments, IEnumerable<Tuple<string, string>> namedArguments) {
			return new Attribute {
				AttributeTypeName = attributeTypeName,
				AttributeTypeNamespace = attributeTypeNamespace,
				PositionalArguments = positionalArguments.AsReadOnlySafe(),
				NamedArguments = namedArguments.AsReadOnlySafe(),
			};
		}
	}
}
