namespace Bridge.Html5.Net.WebRTC
{
	[External, Name("String"), Enum(Emit.StringNameLowerCase)]
	public enum RTCIceConnectionState
	{
		New,
		Checking,
		Connected,
		Completed,
		Failed,
		Disconnected,
		Closed
	}
}
