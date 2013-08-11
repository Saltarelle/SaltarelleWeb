using Generator.CSharp;

namespace Generator.Meta {
	public class TypeOverride {
		public string Identifier { get; private set; }
		public TypeReference NewType { get; private set; }

		public TypeOverride(string identifier, TypeReference newType) {
			Identifier = identifier;
			NewType = newType;
		}
	}
}