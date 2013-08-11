using System.Runtime.CompilerServices;

namespace System.Html {
	[Imported, Serializable]
	public partial class PageTransitionEventInit : EventInit {
		public bool Persisted {
			get { return false; }
			set { }
		}
	}
}
