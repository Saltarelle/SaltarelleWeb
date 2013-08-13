using System.Runtime.CompilerServices;

namespace System.Html {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class AnimationEvent : Event {
		internal AnimationEvent() {
		}

		public AnimationEvent(string type) {
		}

		public AnimationEvent(string type, AnimationEventInit eventInitDict) {
		}

		[IntrinsicProperty]
		public string AnimationName {
			get {
				return null;
			}
		}

		[IntrinsicProperty]
		public float ElapsedTime {
			get {
				return 0;
			}
		}

		[IntrinsicProperty]
		public string PseudoElement {
			get {
				return null;
			}
		}
	}
}
