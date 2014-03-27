using System.Runtime.CompilerServices;

namespace System.Html.Mobile {
	[Imported, Serializable]
	public partial class DeviceMotionEventInit : EventInit {
		public DeviceAccelerationInit Acceleration {
			get;
			set;
		}

		public DeviceAccelerationInit AccelerationIncludingGravity {
			get;
			set;
		}

		public double? Interval {
			get;
			set;
		}

		public DeviceRotationRateInit RotationRate {
			get;
			set;
		}
	}
}
