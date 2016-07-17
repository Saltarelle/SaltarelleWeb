namespace Bridge.Html5.Mobile
{
	[Namespace("false"), External]
	public partial class DeviceMotionEvent : Event
	{
		internal extern DeviceMotionEvent();

		public extern DeviceMotionEvent(string type);

		public extern DeviceMotionEvent(string type, DeviceMotionEventInit eventInitDict);

		public readonly DeviceAcceleration Acceleration;

		public readonly DeviceAcceleration AccelerationIncludingGravity;

		public extern void InitDeviceMotionEvent(string type, bool canBubble, bool cancelable, DeviceAccelerationInit acceleration, DeviceAccelerationInit accelerationIncludingGravity, DeviceRotationRateInit rotationRate, double? interval);

		public readonly double? Interval;

		public readonly DeviceRotationRate RotationRate;
	}
}
