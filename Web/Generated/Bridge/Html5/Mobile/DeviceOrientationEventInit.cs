namespace Bridge.Html5.Mobile
{
	[External, Serializable]
	public partial class DeviceOrientationEventInit : EventInit
	{
		public extern bool Absolute
		{
			get;
			set;
		}

		public extern double Alpha
		{
			get;
			set;
		}

		public extern double Beta
		{
			get;
			set;
		}

		public extern double Gamma
		{
			get;
			set;
		}
	}
}
