using System.Runtime.CompilerServices;

namespace System.Net.WebRTC {
	[Imported, Serializable]
	public partial class RTCIceServer {
		public string Credential {
			get;
			set;
		}

		public string Url {
			get;
			set;
		}

		public string Username {
			get;
			set;
		}
	}
}
