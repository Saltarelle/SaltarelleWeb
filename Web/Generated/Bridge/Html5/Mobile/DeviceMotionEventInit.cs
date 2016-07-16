namespace Bridge.Html5.Mobile
{
	[External, Serializable]
	public partial class DeviceMotionEventInit : EventInit
	{
		public extern DeviceAccelerationInit Acceleration
		{
			get;
			set;
		}

		public extern DeviceAccelerationInit AccelerationIncludingGravity
		{
			get;
			set;
		}

		public extern double? Interval
		{
			get;
			set;
		}

		public extern DeviceRotationRateInit RotationRate
		{
			get;
			set;
		}
	}
}
