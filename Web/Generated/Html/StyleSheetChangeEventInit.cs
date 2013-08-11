using System.Runtime.CompilerServices;

namespace System.Html {
	[Imported, Serializable]
	public partial class StyleSheetChangeEventInit : EventInit {
		public bool DocumentSheet {
			get { return false; }
			set { }
		}

		public CSSStyleSheet Stylesheet {
			get { return default(CSSStyleSheet); }
			set { }
		}
	}
}
