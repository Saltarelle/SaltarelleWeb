using System.Runtime.CompilerServices;

namespace System.Html {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class CSSStyleSheet : StyleSheet {
		internal CSSStyleSheet() {
		}

		[IntrinsicProperty]
		public CSSRule[] CssRules {
			get {
				return null;
			}
		}

		public void DeleteRule(int index) {
		}

		public int InsertRule(string rule, int index) {
			return 0;
		}

		[IntrinsicProperty]
		public CSSRule OwnerRule {
			get {
				return default(CSSRule);
			}
		}
	}
}
