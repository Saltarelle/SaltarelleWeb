namespace Bridge.Html5.Net.ServerEvents
{
	[External, Name("String"), Enum(Emit.StringNameLowerCase)]
	public enum EventSourceEvents
	{
		Error,
		Message,
		Open
	}
}
