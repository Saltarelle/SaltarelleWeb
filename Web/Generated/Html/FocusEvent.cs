using System.Runtime.CompilerServices;

namespace System.Html {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class FocusEvent : UIEvent {
		internal FocusEvent() {
		}

		public FocusEvent(string typeArg) {
		}

		public FocusEvent(string typeArg, FocusEventInit focusEventInitDict) {
		}

		[IntrinsicProperty]
		public EventTarget RelatedTarget {
			get { return default(EventTarget); }
		}
	}
}
