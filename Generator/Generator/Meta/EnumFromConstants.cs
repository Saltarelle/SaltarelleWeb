using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.RegularExpressions;
using System.Linq;

namespace Generator.Meta {
	public class EnumFromConstants {
		public string EnumName { get; private set; }
		public string EnumNamespace { get; private set; }
		public string Container { get; private set; }
		public Regex  ConstantsRegex { get; private set; }
		public IReadOnlyDictionary<string, string> Names { get; private set; }
		public bool Flags { get; private set; }

		public EnumFromConstants(string enumName, string enumNamespace, string container, Regex constantsRegex, IEnumerable<Tuple<string, string>> names, bool flags) {
			EnumName = enumName;
			EnumNamespace = enumNamespace;
			Container = container;
			ConstantsRegex = constantsRegex;
			Names = new ReadOnlyDictionary<string, string>((names ?? new Tuple<string, string>[0]).ToDictionary(n => n.Item1, n => n.Item2));
			Flags = flags;
		}
	}
}