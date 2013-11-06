using System.Runtime.CompilerServices;

namespace System.Net.WebRTC {
	[Imported, Serializable]
	public partial class RTCTransportStats : RTCStats {
		public uint BytesReceived {
			get;
			set;
		}

		public uint BytesSent {
			get;
			set;
		}
	}
}
