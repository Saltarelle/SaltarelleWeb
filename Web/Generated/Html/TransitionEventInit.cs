using System.Runtime.CompilerServices;

namespace System.Html {
	[Imported, Serializable]
	public partial class TransitionEventInit : EventInit {
		public double ElapsedTime {
			get;
			set;
		}

		public string PropertyName {
			get;
			set;
		}

		public string PseudoElement {
			get;
			set;
		}
	}
}
