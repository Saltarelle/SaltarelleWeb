namespace Bridge.Html5.Net.WebRTC
{
	[External, Serializable]
	public partial class RTCIceCandidateStats : RTCStats
	{
		public extern string CandidateId
		{
			get;
			set;
		}

		public extern RTCStatsIceCandidateType CandidateType
		{
			get;
			set;
		}

		public extern string ComponentId
		{
			get;
			set;
		}

		public extern string IpAddress
		{
			get;
			set;
		}

		public extern int PortNumber
		{
			get;
			set;
		}

		public extern string Transport
		{
			get;
			set;
		}
	}
}
