using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.RegularExpressions;
using System.Linq;

namespace Generator.Meta {
	public enum GeneratedEnumSourceType {
		Constants,
		Attributes,
	}

	public class GeneratedEnum {
		public string EnumName { get; private set; }
		public string EnumNamespace { get; private set; }
		public GeneratedEnumSourceType SourceType { get; private set; }
		public Regex MembersRegex { get; private set; }
		public IReadOnlyDictionary<string, string> Names { get; private set; }
		public bool Flags { get; private set; }
		public bool GenerateInDerivedTypes { get; private set; }
		public Regex ValueRegex { get; private set; }

		public GeneratedEnum(string enumName, string enumNamespace, GeneratedEnumSourceType sourceType, Regex membersRegex, IEnumerable<Tuple<string, string>> names, bool flags, bool generateInDerivedTypes, Regex valueRegex) {
			EnumName = enumName;
			EnumNamespace = enumNamespace;
			SourceType = sourceType;
			MembersRegex = membersRegex;
			Names = new ReadOnlyDictionary<string, string>((names ?? new Tuple<string, string>[0]).ToDictionary(n => n.Item1, n => n.Item2));
			Flags = flags;
			GenerateInDerivedTypes = generateInDerivedTypes;
			ValueRegex = valueRegex;
		}
	}
}