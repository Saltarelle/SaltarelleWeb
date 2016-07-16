using System.Runtime.CompilerServices;

namespace System.Html {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class CloseEvent : Event {
		internal CloseEvent() {
		}

		public CloseEvent(string type) {
		}

		public CloseEvent(string type, CloseEventInit eventInitDict) {
		}

		[IntrinsicProperty]
		public ushort Code {
			get {
				return 0;
			}
		}

		public void InitCloseEvent(string type, bool canBubble, bool cancelable, bool wasClean, ushort code, string reason) {
		}

		[IntrinsicProperty]
		public string Reason {
			get {
				return null;
			}
		}

		[IntrinsicProperty]
		public bool WasClean {
			get {
				return false;
			}
		}
	}
}
