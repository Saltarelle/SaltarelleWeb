namespace Bridge.Html5.Net.WebSockets
{
	[External, Name("Number"), Enum(Emit.Value)]
	public enum ReadyState
	{
		Connecting = 0,
		Open = 1,
		Closing = 2,
		Closed = 3
	}
}
