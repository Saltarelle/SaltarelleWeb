using System.Collections.Generic;
using Generator.ExtensionMethods;

namespace Generator.CSharp {
	public class EnumMember {
		private EnumMember() {}

		public string Name { get; private set; }
		public int? Value { get; private set; }
		public IReadOnlyList<Attribute> Attributes { get; private set; }

		public static EnumMember Create(string name, int? value, IEnumerable<Attribute> attributes) {
			return new EnumMember {
				Name = name,
				Value = value,
				Attributes = attributes.AsReadOnlySafe(),
			};
		}
	}
}
