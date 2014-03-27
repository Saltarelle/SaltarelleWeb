using System.Runtime.CompilerServices;

namespace System.Net.WebRTC {
	[Imported, Serializable]
	public partial class RTCStats {
		public string Id {
			get;
			set;
		}

		public double Timestamp {
			get;
			set;
		}

		public RTCStatsType Type {
			get;
			set;
		}
	}
}
