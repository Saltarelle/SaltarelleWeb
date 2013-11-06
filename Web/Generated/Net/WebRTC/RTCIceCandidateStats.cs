using System.Runtime.CompilerServices;

namespace System.Net.WebRTC {
	[Imported, Serializable]
	public partial class RTCIceCandidateStats : RTCStats {
		public string CandidateId {
			get;
			set;
		}

		public RTCStatsIceCandidateType CandidateType {
			get;
			set;
		}

		public string IpAddress {
			get;
			set;
		}

		public int PortNumber {
			get;
			set;
		}
	}
}
