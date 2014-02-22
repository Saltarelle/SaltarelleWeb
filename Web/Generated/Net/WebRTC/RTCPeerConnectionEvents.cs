using System.Runtime.CompilerServices;

namespace System.Net.WebRTC {
	[Imported, NamedValues]
	public enum RTCPeerConnectionEvents {
		Addstream,
		Closedconnection,
		Connection,
		Datachannel,
		Icecandidate,
		Iceconnectionstatechange,
		Negotiationneeded,
		Removestream,
		Signalingstatechange
	}
}
