using System.Runtime.CompilerServices;

namespace System.Net.WebRTC {
	[Imported, Serializable]
	public partial class RTCCodecStats : RTCStats {
		public int Channels {
			get;
			set;
		}

		public int ClockRate {
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

		public int PayloadType {
			get;
			set;
		}
	}
}
