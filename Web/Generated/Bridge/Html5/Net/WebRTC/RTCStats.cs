namespace Bridge.Html5.Net.WebRTC
{
	[External, Serializable]
	public partial class RTCStats
	{
		public string Id
		{
			get;
			set;
		}

		public double Timestamp
		{
			get;
			set;
		}

		public RTCStatsType Type
		{
			get;
			set;
		}
	}
}
