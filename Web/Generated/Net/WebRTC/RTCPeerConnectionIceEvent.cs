using System.Html;
using System.Runtime.CompilerServices;

namespace System.Net.WebRTC {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class RTCPeerConnectionIceEvent : Event {
		internal RTCPeerConnectionIceEvent() {
		}

		public RTCPeerConnectionIceEvent(string type) {
		}

		public RTCPeerConnectionIceEvent(string type, RTCPeerConnectionIceEventInit eventInitDict) {
		}

		[IntrinsicProperty]
		public RTCIceCandidate Candidate {
			get { return default(RTCIceCandidate); }
		}
	}
}
