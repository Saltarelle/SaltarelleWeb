using System.Runtime.CompilerServices;

namespace System.Html.Mobile {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class DeviceLightEvent : Event {
		internal DeviceLightEvent() {
		}

		public DeviceLightEvent(string type) {
		}

		public DeviceLightEvent(string type, DeviceLightEventInit eventInitDict) {
		}

		[IntrinsicProperty]
		public double Value {
			get {
				return 0;
			}
		}
	}
}
