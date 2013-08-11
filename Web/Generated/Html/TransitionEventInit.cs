using System.Runtime.CompilerServices;

namespace System.Html {
	[Imported, Serializable]
	public partial class TransitionEventInit : EventInit {
		public float ElapsedTime {
			get { return 0; }
			set { }
		}

		public string PropertyName {
			get { return null; }
			set { }
		}

		public string PseudoElement {
			get { return null; }
			set { }
		}
	}
}
