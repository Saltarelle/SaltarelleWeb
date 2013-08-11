using System.Runtime.CompilerServices;

namespace System.Html {
	[Imported, Serializable]
	public partial class UIEventInit : EventInit {
		public int Detail {
			get { return 0; }
			set { }
		}

		public WindowInstance View {
			get { return default(WindowInstance); }
			set { }
		}
	}
}
