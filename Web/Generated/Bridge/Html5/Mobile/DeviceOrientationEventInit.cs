namespace Bridge.Html5.Mobile
{
	[External, Serializable]
	public partial class DeviceOrientationEventInit : EventInit
	{
		public bool Absolute
		{
			get;
			set;
		}

		public double Alpha
		{
			get;
			set;
		}

		public double Beta
		{
			get;
			set;
		}

		public double Gamma
		{
			get;
			set;
		}
	}
}
