using System.Runtime.CompilerServices;

namespace System.Net.WebRTC {
	[Imported, Serializable]
	public partial class RTCTransportStats : RTCStats {
		public int BytesReceived {
			get;
			set;
		}

		public int BytesSent {
			get;
			set;
		}
	}
}
