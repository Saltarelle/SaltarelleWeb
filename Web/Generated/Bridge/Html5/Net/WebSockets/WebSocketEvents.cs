namespace Bridge.Html5.Net.WebSockets
{
	[External, Name("String"), Enum(Emit.StringNameLowerCase)]
	public enum WebSocketEvents
	{
		Close,
		Error,
		Message,
		Open
	}
}
