namespace Bridge.Html5.Mobile
{
	[External, Serializable]
	public partial class DeviceProximityEventInit : EventInit
	{
		public extern double Max
		{
			get;
			set;
		}

		public extern double Min
		{
			get;
			set;
		}

		public extern double Value
		{
			get;
			set;
		}
	}
}
