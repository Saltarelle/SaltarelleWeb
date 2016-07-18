namespace Bridge.Html5.Net.WebRTC
{
	[External]
	public partial class RTCStatsReportInternal
	{
		public RTCCodecStats[] CodecStats;

		public RTCIceCandidatePairStats[] IceCandidatePairStats;

		public RTCIceCandidateStats[] IceCandidateStats;

		public RTCIceComponentStats[] IceComponentStats;

		public RTCInboundRTPStreamStats[] InboundRTPStreamStats;

		public RTCMediaStreamStats[] MediaStreamStats;

		public RTCMediaStreamTrackStats[] MediaStreamTrackStats;

		public RTCOutboundRTPStreamStats[] OutboundRTPStreamStats;

		public string Pcid;

		public RTCRTPStreamStats[] RtpStreamStats;

		public RTCTransportStats[] TransportStats;
	}
}
