using System.Runtime.CompilerServices;

namespace System.Html {
	[Imported, Serializable]
	public partial class AnimationEventInit : EventInit {
		public string AnimationName {
			get;
			set;
		}

		public float ElapsedTime {
			get;
			set;
		}

		public string PseudoElement {
			get;
			set;
		}
	}
}
