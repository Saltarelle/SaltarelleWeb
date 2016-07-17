namespace Bridge.Html5.Net.WebSockets
{
	[External, Name("Number"), Enum(Emit.Value)]
	public enum ReadyState
	{
		Closed = 3,
		Closing = 2,
		Connecting = 0,
		Open = 1
	}
}
