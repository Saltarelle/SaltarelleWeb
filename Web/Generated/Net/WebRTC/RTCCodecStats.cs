using System.Runtime.CompilerServices;

namespace System.Net.WebRTC {
	[Imported, Serializable]
	public partial class RTCCodecStats : RTCStats {
		public uint Channels {
			get;
			set;
		}

		public uint ClockRate {
			get;
			set;
		}

		public string Codec {
			get;
			set;
		}

		public string Parameters {
			get;
			set;
		}

		public uint PayloadType {
			get;
			set;
		}
	}
}
