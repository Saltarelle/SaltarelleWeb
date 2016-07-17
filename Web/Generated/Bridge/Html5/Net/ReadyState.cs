namespace Bridge.Html5.Net
{
	[External, Name("Number"), Enum(Emit.Value)]
	public enum ReadyState
	{
		Done = 4,
		HeadersReceived = 2,
		Loading = 3,
		Opened = 1,
		Unsent = 0
	}
}
