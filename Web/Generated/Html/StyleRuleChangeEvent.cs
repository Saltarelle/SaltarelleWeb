using System.Runtime.CompilerServices;

namespace System.Html {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class StyleRuleChangeEvent : Event {
		internal StyleRuleChangeEvent() {
		}

		public StyleRuleChangeEvent(string type) {
		}

		public StyleRuleChangeEvent(string type, StyleRuleChangeEventInit eventInitDict) {
		}

		[IntrinsicProperty]
		public CSSRule Rule {
			get {
				return default(CSSRule);
			}
		}

		[IntrinsicProperty]
		public CSSStyleSheet Stylesheet {
			get {
				return default(CSSStyleSheet);
			}
		}
	}
}
