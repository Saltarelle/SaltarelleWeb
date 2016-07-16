namespace Bridge.Html5.Net.WebRTC
{
	[External, Serializable]
	public partial class RTCIceCandidateStats : RTCStats
	{
		public string CandidateId
		{
			get;
			set;
		}

		public RTCStatsIceCandidateType CandidateType
		{
			get;
			set;
		}

		public string ComponentId
		{
			get;
			set;
		}

		public string IpAddress
		{
			get;
			set;
		}

		public int PortNumber
		{
			get;
			set;
		}

		public string Transport
		{
			get;
			set;
		}
	}
}
