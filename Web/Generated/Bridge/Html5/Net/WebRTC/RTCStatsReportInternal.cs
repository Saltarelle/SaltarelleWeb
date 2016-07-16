namespace Bridge.Html5.Net.WebRTC
{
	[External, Serializable]
	public partial class RTCStatsReportInternal
	{
		public extern RTCCodecStats[] CodecStats
		{
			get;
			set;
		}

		public extern RTCIceCandidatePairStats[] IceCandidatePairStats
		{
			get;
			set;
		}

		public extern RTCIceCandidateStats[] IceCandidateStats
		{
			get;
			set;
		}

		public extern RTCIceComponentStats[] IceComponentStats
		{
			get;
			set;
		}

		public extern RTCInboundRTPStreamStats[] InboundRTPStreamStats
		{
			get;
			set;
		}

		public extern RTCMediaStreamStats[] MediaStreamStats
		{
			get;
			set;
		}

		public extern RTCMediaStreamTrackStats[] MediaStreamTrackStats
		{
			get;
			set;
		}

		public extern RTCOutboundRTPStreamStats[] OutboundRTPStreamStats
		{
			get;
			set;
		}

		public extern string Pcid
		{
			get;
			set;
		}

		public extern RTCRTPStreamStats[] RtpStreamStats
		{
			get;
			set;
		}

		public extern RTCTransportStats[] TransportStats
		{
			get;
			set;
		}
	}
}
