using System.Collections.Generic;

namespace Generator.CSharp {
	public class Parameter {
		private Parameter() {}

		public string Name { get; private set; }
		public TypeReference Type { get; private set; }
		public bool IsParams { get; private set; }

		public static Parameter Create(string name, TypeReference type, bool isParams = false) {
			return new Parameter { Name = name, Type = type, IsParams = isParams };
		}
	}
}
