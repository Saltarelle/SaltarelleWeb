namespace Bridge.Html5.Mobile
{
	[External, Serializable]
	public partial class DeviceMotionEventInit : EventInit
	{
		public DeviceAccelerationInit Acceleration
		{
			get;
			set;
		}

		public DeviceAccelerationInit AccelerationIncludingGravity
		{
			get;
			set;
		}

		public double? Interval
		{
			get;
			set;
		}

		public DeviceRotationRateInit RotationRate
		{
			get;
			set;
		}
	}
}
