using System.Html;
using System.Runtime.CompilerServices;

namespace System.Net.WebRTC {
	[Imported, Serializable]
	public partial class RTCPeerConnectionIceEventInit : EventInit {
		public RTCIceCandidate Candidate {
			get;
			set;
		}
	}
}
