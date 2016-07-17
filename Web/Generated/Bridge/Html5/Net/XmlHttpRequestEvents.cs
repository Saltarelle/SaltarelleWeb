namespace Bridge.Html5.Net
{
	[External, Name("String"), Enum(Emit.StringNameLowerCase)]
	public enum XmlHttpRequestEvents
	{
		Abort,
		Error,
		Load,
		Loadend,
		Loadstart,
		Progress,
		Readystatechange,
		Timeout
	}
}
