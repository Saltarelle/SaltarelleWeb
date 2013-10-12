using System.Runtime.CompilerServices;

namespace System.Html {
	[Imported, Serializable]
	public partial class UIEventInit : EventInit {
		public int Detail {
			get;
			set;
		}

		public WindowInstance View {
			get;
			set;
		}
	}
}
