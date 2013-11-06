using System.Runtime.CompilerServices;

namespace System.Net.WebRTC {
	[Imported, Serializable]
	public partial class RTCInboundRTPStreamStats : RTCRTPStreamStats {
		public ulong BytesReceived {
			get;
			set;
		}

		public double Jitter {
			get;
			set;
		}

		public uint PacketsReceived {
			get;
			set;
		}
	}
}
