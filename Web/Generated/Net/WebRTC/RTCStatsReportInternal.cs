using System.Runtime.CompilerServices;

namespace System.Net.WebRTC {
	[Imported, Serializable]
	public partial class RTCStatsReportInternal {
		public RTCCodecStats[] CodecStats {
			get;
			set;
		}

		public RTCIceCandidatePairStats[] IceCandidatePairStats {
			get;
			set;
		}

		public RTCIceCandidateStats[] IceCandidateStats {
			get;
			set;
		}

		public RTCIceComponentStats[] IceComponentStats {
			get;
			set;
		}

		public RTCInboundRTPStreamStats[] InboundRTPStreamStats {
			get;
			set;
		}

		public RTCMediaStreamStats[] MediaStreamStats {
			get;
			set;
		}

		public RTCMediaStreamTrackStats[] MediaStreamTrackStats {
			get;
			set;
		}

		public RTCOutboundRTPStreamStats[] OutboundRTPStreamStats {
			get;
			set;
		}

		public RTCRTPStreamStats[] RtpStreamStats {
			get;
			set;
		}

		public RTCTransportStats[] TransportStats {
			get;
			set;
		}
	}
}
