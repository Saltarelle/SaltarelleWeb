using System.Runtime.CompilerServices;

namespace System.Html.Mobile {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class DeviceOrientationEvent : Event {
		internal DeviceOrientationEvent() {
		}

		public DeviceOrientationEvent(string type) {
		}

		public DeviceOrientationEvent(string type, DeviceOrientationEventInit eventInitDict) {
		}

		[IntrinsicProperty]
		public bool Absolute {
			get { return false; }
		}

		[IntrinsicProperty]
		public double Alpha {
			get { return 0; }
		}

		[IntrinsicProperty]
		public double Beta {
			get { return 0; }
		}

		[IntrinsicProperty]
		public double Gamma {
			get { return 0; }
		}
	}
}
