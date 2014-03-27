using System.Runtime.CompilerServices;

namespace System.Net.WebRTC {
	[Imported, Serializable]
	public partial class RTCMediaStreamStats : RTCStats {
		public string StreamIdentifier {
			get;
			set;
		}

		public string[] TrackIds {
			get;
			set;
		}
	}
}
