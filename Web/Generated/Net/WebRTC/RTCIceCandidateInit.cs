using System.Runtime.CompilerServices;

namespace System.Net.WebRTC {
	[Imported, Serializable]
	public partial class RTCIceCandidateInit {
		public string Candidate {
			get;
			set;
		}

		public string SdpMid {
			get;
			set;
		}

		public ushort SdpMLineIndex {
			get;
			set;
		}
	}
}
