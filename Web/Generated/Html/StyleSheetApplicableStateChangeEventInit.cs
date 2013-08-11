using System.Runtime.CompilerServices;

namespace System.Html {
	[Imported, Serializable]
	public partial class StyleSheetApplicableStateChangeEventInit : EventInit {
		public bool Applicable {
			get { return false; }
			set { }
		}

		public CSSStyleSheet Stylesheet {
			get { return default(CSSStyleSheet); }
			set { }
		}
	}
}
