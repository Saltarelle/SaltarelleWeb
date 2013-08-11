using System.Runtime.CompilerServices;

namespace System.Html {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class StyleSheetApplicableStateChangeEvent : Event {
		internal StyleSheetApplicableStateChangeEvent() {
		}

		public StyleSheetApplicableStateChangeEvent(string type) {
		}

		public StyleSheetApplicableStateChangeEvent(string type, StyleSheetApplicableStateChangeEventInit eventInitDict) {
		}

		[IntrinsicProperty]
		public bool Applicable {
			get { return false; }
		}

		[IntrinsicProperty]
		public CSSStyleSheet Stylesheet {
			get { return default(CSSStyleSheet); }
		}
	}
}
