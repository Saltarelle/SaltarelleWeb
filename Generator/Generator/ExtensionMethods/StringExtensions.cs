using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generator.ExtensionMethods {
	static class StringExtensions {
		public static string MakeCamelCase(this string s) {
			if (String.IsNullOrEmpty(s))
				return s;
			if (s.Equals("ID", StringComparison.Ordinal))
				return "id";

			bool hasNonUppercase = false;
			int numUppercaseChars = 0;
			for (int index = 0; index < s.Length; index++) {
				if (Char.IsUpper(s, index)) {
					numUppercaseChars++;
				}
				else {
					hasNonUppercase = true;
					break;
				}
			}

			if ((!hasNonUppercase && s.Length != 1) || numUppercaseChars == 0)
				return s;
			else if (numUppercaseChars > 1)
				return s.Substring(0, numUppercaseChars - 1).ToLower(CultureInfo.InvariantCulture) + s.Substring(numUppercaseChars - 1);
			else if (s.Length == 1)
				return s.ToLower(CultureInfo.InvariantCulture);
			else
				return Char.ToLower(s[0], CultureInfo.InvariantCulture) + s.Substring(1);
		}

		public static string MakeCSharpName(this string s) {
			if (s.Length > 2 && s.StartsWith("on") && s != "online")
				return "On" + char.ToUpperInvariant(s[2]) + s.Substring(3);
			else if (s.Length == 0)
				return "None";
			else {
				string result = string.Join("", s.Split(new[] { '-', '/', '+' }, StringSplitOptions.RemoveEmptyEntries).Select(p => char.ToUpperInvariant(p[0]) + p.Substring(1)));
				if (!char.IsLetter(s[0]) && s[0] != '_')
					result = '_' + result;
				return result;
			}
		}

		public static string RemoveLeadingUnderscore(this string s) {
			return s != null && s.StartsWith("_") ? s.Substring(1) : s;
		}

		public static string ConstantCaseToPascalCase(this string s) {
			return string.Join("", s.Split(new[] { '_' }, StringSplitOptions.RemoveEmptyEntries).Select(p => p[0] + p.Substring(1).ToLowerInvariant()));
		}
	}
}
