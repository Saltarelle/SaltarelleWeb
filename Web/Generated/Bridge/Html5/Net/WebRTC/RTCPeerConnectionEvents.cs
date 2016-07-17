namespace Bridge.Html5.Net.WebRTC
{
	[External, Name("String"), Enum(Emit.StringNameLowerCase)]
	public enum RTCPeerConnectionEvents
	{
		Addstream,
		Closedconnection,
		Connection,
		Datachannel,
		Icecandidate,
		Iceconnectionstatechange,
		Identityresult,
		Negotiationneeded,
		Peeridentity,
		Removestream,
		Signalingstatechange
	}
}
