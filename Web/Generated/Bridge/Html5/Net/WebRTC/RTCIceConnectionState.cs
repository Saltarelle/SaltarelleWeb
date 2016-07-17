namespace Bridge.Html5.Net.WebRTC
{
	[External, Name("String"), Enum(Emit.StringNameLowerCase)]
	public enum RTCIceConnectionState
	{
		Checking,
		Closed,
		Completed,
		Connected,
		Disconnected,
		Failed,
		New
	}
}
