namespace Bridge.Html5.Net.WebRTC
{
	[External, Enum(Emit.StringNamePreserveCase)]
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
