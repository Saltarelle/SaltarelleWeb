using System.Runtime.CompilerServices;

namespace System.Html {
	[Imported, Serializable]
	public partial class StyleRuleChangeEventInit : EventInit {
		public CSSRule Rule {
			get;
			set;
		}

		public CSSStyleSheet Stylesheet {
			get;
			set;
		}
	}
}
