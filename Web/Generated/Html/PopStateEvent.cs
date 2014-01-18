using System.Runtime.CompilerServices;

namespace System.Html {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class PopStateEvent : Event {
		internal PopStateEvent() {
		}

		public PopStateEvent(string type) {
		}

		public PopStateEvent(string type, PopStateEventInit eventInitDict) {
		}

		public void InitPopStateEvent(string type, bool canBubble, bool cancelable, object state) {
		}

		[IntrinsicProperty]
		public object State {
			get {
				return null;
			}
		}
	}
}
