using System.Runtime.CompilerServices;

namespace System.Net.WebRTC {
	[Imported, Serializable]
	public partial class RTCSessionDescriptionInit {
		public string Sdp {
			get;
			set;
		}

		public RTCSdpType? Type {
			get;
			set;
		}
	}
}
