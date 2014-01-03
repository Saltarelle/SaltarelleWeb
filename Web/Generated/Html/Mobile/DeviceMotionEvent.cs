using System.Runtime.CompilerServices;

namespace System.Html.Mobile {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class DeviceMotionEvent : Event {
		internal DeviceMotionEvent() {
		}

		public DeviceMotionEvent(string type) {
		}

		public DeviceMotionEvent(string type, DeviceMotionEventInit eventInitDict) {
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
		public double? Interval {
			get {
				return null;
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
