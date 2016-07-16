namespace Bridge.Html5.Geolocation
{
	[External, Serializable]
	public partial class PositionOptions
	{
		public bool EnableHighAccuracy
		{
			get;
			set;
		}

		public int MaximumAge
		{
			get;
			set;
		}

		public int Timeout
		{
			get;
			set;
		}
	}
}
