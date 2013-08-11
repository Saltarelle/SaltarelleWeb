using System.Runtime.CompilerServices;

namespace System.Html {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class CSS {
		internal CSS() {
		}

		public static bool Supports(string conditionText) {
			return false;
		}

		public static bool Supports(string property, string value) {
			return false;
		}
	}
}
