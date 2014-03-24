using System.Runtime.CompilerServices;

namespace System.Net.WebRTC {
	[Imported, Serializable]
	public partial class RTCMediaStreamTrackStats : RTCStats {
		public uint AudioLevel {
			get;
			set;
		}

		public uint FrameHeight {
			get;
			set;
		}

		public uint FramesDecoded {
			get;
			set;
		}

		public double FramesPerSecond {
			get;
			set;
		}

		public uint FramesReceived {
			get;
			set;
		}

		public uint FramesSent {
			get;
			set;
		}

		public uint FrameWidth {
			get;
			set;
		}

		public bool RemoteSource {
			get;
			set;
		}

		public string[] SsrcIds {
			get;
			set;
		}

		public string TrackIdentifier {
			get;
			set;
		}
	}
}
