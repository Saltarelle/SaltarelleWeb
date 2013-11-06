using System.Runtime.CompilerServices;

namespace System.Net.WebRTC {
	[Imported, Serializable]
	public partial class RTCIceComponentStats : RTCStats {
		public bool ActiveConnection {
			get;
			set;
		}

		public uint BytesReceived {
			get;
			set;
		}

		public uint BytesSent {
			get;
			set;
		}

		public int Component {
			get;
			set;
		}

		public string TransportId {
			get;
			set;
		}
	}
}
