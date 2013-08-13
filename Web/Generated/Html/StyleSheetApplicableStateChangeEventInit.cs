using System.Runtime.CompilerServices;

namespace System.Html {
	[Imported, Serializable]
	public partial class StyleSheetApplicableStateChangeEventInit : EventInit {
		public bool Applicable {
			get;
			set;
		}

		public CSSStyleSheet Stylesheet {
			get;
			set;
		}
	}
}
