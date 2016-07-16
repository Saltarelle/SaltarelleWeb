namespace Bridge.Html5.Geolocation
{
	[External, Serializable]
	public partial class PositionOptions
	{
		public extern bool EnableHighAccuracy
		{
			get;
			set;
		}

		public extern int MaximumAge
		{
			get;
			set;
		}

		public extern int Timeout
		{
			get;
			set;
		}
	}
}
