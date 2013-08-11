// DeviceMotionEvent.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
// 

using System.Runtime.CompilerServices;

namespace System.Html.Mobile {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class DeviceMotionEvent : Event {
		internal DeviceMotionEvent() {
		}

		[IntrinsicProperty]
		public DeviceAcceleration Acceleration {
			get { return default(DeviceAcceleration); }
		}

		[IntrinsicProperty]
		public DeviceAcceleration AccelerationIncludingGravity {
			get { return default(DeviceAcceleration); }
		}

		[IntrinsicProperty]
		public double Interval {
			get { return 0; }
		}

		[IntrinsicProperty]
		public DeviceRotationRate RotationRate {
			get { return default(DeviceRotationRate); }
		}
	}
}
