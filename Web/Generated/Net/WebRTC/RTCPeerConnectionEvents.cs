using System.Runtime.CompilerServices;

namespace System.Net.WebRTC {
	[Imported, NamedValues]
	public enum RTCPeerConnectionEvents {
		[ScriptName("onaddstream")]
		Addstream,
		[ScriptName("onclosedconnection")]
		Closedconnection,
		[ScriptName("onconnection")]
		Connection,
		[ScriptName("ondatachannel")]
		Datachannel,
		[ScriptName("onicecandidate")]
		Icecandidate,
		[ScriptName("oniceconnectionstatechange")]
		Iceconnectionstatechange,
		[ScriptName("onnegotiationneeded")]
		Negotiationneeded,
		[ScriptName("onremovestream")]
		Removestream,
		[ScriptName("onsignalingstatechange")]
		Signalingstatechange
	}
}
