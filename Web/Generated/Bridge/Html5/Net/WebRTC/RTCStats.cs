namespace Bridge.Html5.Net.WebRTC
{
	[External, Serializable]
	public partial class RTCStats
	{
		public extern string Id
		{
			get;
			set;
		}

		public extern double Timestamp
		{
			get;
			set;
		}

		public extern RTCStatsType Type
		{
			get;
			set;
		}
	}
}
