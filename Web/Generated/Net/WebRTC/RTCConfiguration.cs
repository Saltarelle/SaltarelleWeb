using System.Runtime.CompilerServices;

namespace System.Net.WebRTC {
	[Imported, Serializable]
	public partial class RTCConfiguration {
		public RTCIceServer[] IceServers {
			get;
			set;
		}
	}
}
