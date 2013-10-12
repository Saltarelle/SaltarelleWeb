using System.Runtime.CompilerServices;

namespace System.Html.Mobile {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class DeviceMotionEvent : Event {
		internal DeviceMotionEvent() {
		}

		[IntrinsicProperty]
		public DeviceAcceleration Acceleration {
			get {
				return default(DeviceAcceleration);
			}
		}

		[IntrinsicProperty]
		public DeviceAcceleration AccelerationIncludingGravity {
			get {
				return default(DeviceAcceleration);
			}
		}

		[IntrinsicProperty]
		public double Interval {
			get {
				return 0;
			}
		}

		[IntrinsicProperty]
		public DeviceRotationRate RotationRate {
			get {
				return default(DeviceRotationRate);
			}
		}
	}
}
