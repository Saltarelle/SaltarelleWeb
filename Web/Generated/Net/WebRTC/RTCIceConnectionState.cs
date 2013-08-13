using System.Runtime.CompilerServices;

namespace System.Net.WebRTC {
	[Imported, NamedValues]
	public enum RTCIceConnectionState {
		New,
		Checking,
		Connected,
		Completed,
		Failed,
		Disconnected,
		Closed
	}
}
