using System.Runtime.CompilerServices;

namespace System.Html.Mobile {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class UserProximityEvent : Event {
		internal UserProximityEvent() {
		}

		public UserProximityEvent(string type) {
		}

		public UserProximityEvent(string type, UserProximityEventInit eventInitDict) {
		}

		[IntrinsicProperty]
		public bool Near {
			get {
				return false;
			}
		}
	}
}
