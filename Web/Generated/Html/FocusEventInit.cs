using System.Runtime.CompilerServices;

namespace System.Html {
	[Imported, Serializable]
	public partial class FocusEventInit : UIEventInit {
		public EventTarget RelatedTarget {
			get;
			set;
		}
	}
}
