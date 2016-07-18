namespace Bridge.Html5.Mobile
{
	[External]
	public partial class DeviceMotionEventInit : EventInit
	{
		public DeviceAccelerationInit Acceleration;

		public DeviceAccelerationInit AccelerationIncludingGravity;

		public double? Interval;

		public DeviceRotationRateInit RotationRate;
	}
}
