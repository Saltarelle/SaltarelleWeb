using System.Runtime.CompilerServices;

namespace System.Html {
	[Imported, Serializable]
	public partial class StyleSheetChangeEventInit : EventInit {
		public bool DocumentSheet {
			get;
			set;
		}

		public CSSStyleSheet Stylesheet {
			get;
			set;
		}
	}
}
