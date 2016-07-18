namespace Bridge.Html5.Net.WebRTC
{
	[External]
	public partial class RTCIceCandidateStats : RTCStats
	{
		public string CandidateId;

		public RTCStatsIceCandidateType CandidateType;

		public string ComponentId;

		public string IpAddress;

		public int PortNumber;

		public string Transport;
	}
}
