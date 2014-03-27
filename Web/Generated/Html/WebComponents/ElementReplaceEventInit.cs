using System.Runtime.CompilerServices;

namespace System.Html.WebComponents {
	[Imported, Serializable]
	public partial class ElementReplaceEventInit : EventInit {
		public Element Upgrade {
			get;
			set;
		}
	}
}
