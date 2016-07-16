namespace Bridge.Html5.Mobile
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class DeviceMotionEvent : Event
	{
		internal extern DeviceMotionEvent();

		public extern DeviceMotionEvent(string type);

		public extern DeviceMotionEvent(string type, DeviceMotionEventInit eventInitDict);

		[FieldProperty]
		public extern DeviceAcceleration Acceleration
		{
			get;
		}

		[FieldProperty]
		public extern DeviceAcceleration AccelerationIncludingGravity
		{
			get;
		}

		public extern void InitDeviceMotionEvent(string type, bool canBubble, bool cancelable, DeviceAccelerationInit acceleration, DeviceAccelerationInit accelerationIncludingGravity, DeviceRotationRateInit rotationRate, double? interval);

		[FieldProperty]
		public extern double? Interval
		{
			get;
		}

		[FieldProperty]
		public extern DeviceRotationRate RotationRate
		{
			get;
		}
	}
}
