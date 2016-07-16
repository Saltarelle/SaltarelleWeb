namespace Bridge.Html5.Mobile
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class DeviceMotionEvent : Event
	{
		internal DeviceMotionEvent()
		{
		}

		public DeviceMotionEvent(string type)
		{
		}

		public DeviceMotionEvent(string type, DeviceMotionEventInit eventInitDict)
		{
		}

		[FieldProperty]
		public DeviceAcceleration Acceleration
		{
			get {
				return default(DeviceAcceleration);
			}
		}

		[FieldProperty]
		public DeviceAcceleration AccelerationIncludingGravity
		{
			get {
				return default(DeviceAcceleration);
			}
		}

		public void InitDeviceMotionEvent(string type, bool canBubble, bool cancelable, DeviceAccelerationInit acceleration, DeviceAccelerationInit accelerationIncludingGravity, DeviceRotationRateInit rotationRate, double? interval)
		{
		}

		[FieldProperty]
		public double? Interval
		{
			get {
				return null;
			}
		}

		[FieldProperty]
		public DeviceRotationRate RotationRate
		{
			get {
				return default(DeviceRotationRate);
			}
		}
	}
}
