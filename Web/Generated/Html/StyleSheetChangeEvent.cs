using System.Runtime.CompilerServices;

namespace System.Html {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class StyleSheetChangeEvent : Event {
		internal StyleSheetChangeEvent() {
		}

		public StyleSheetChangeEvent(string type) {
		}

		public StyleSheetChangeEvent(string type, StyleSheetChangeEventInit eventInitDict) {
		}

		[IntrinsicProperty]
		public bool DocumentSheet {
			get {
				return false;
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
