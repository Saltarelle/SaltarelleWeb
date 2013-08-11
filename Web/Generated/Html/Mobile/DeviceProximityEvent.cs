using System.Runtime.CompilerServices;

namespace System.Html.Mobile {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class DeviceProximityEvent : Event {
		internal DeviceProximityEvent() {
		}

		public DeviceProximityEvent(string type) {
		}

		public DeviceProximityEvent(string type, DeviceProximityEventInit eventInitDict) {
		}

		[IntrinsicProperty]
		public double Max {
			get { return 0; }
		}

		[IntrinsicProperty]
		public double Min {
			get { return 0; }
		}

		[IntrinsicProperty]
		public double Value {
			get { return 0; }
		}
	}
}
