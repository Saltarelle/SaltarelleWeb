namespace Bridge.Html5.Net
{
	[External, Name("Number"), Enum(Emit.Value)]
	public enum ReadyState
	{
		Unsent = 0,
		Opened = 1,
		HeadersReceived = 2,
		Loading = 3,
		Done = 4
	}
}
