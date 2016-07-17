namespace Bridge.Html5.Net
{
	[External, Name("String"), Enum(Emit.StringNameLowerCase)]
	public enum XmlHttpRequestUploadEvents
	{
		Abort,
		Error,
		Load,
		Loadend,
		Loadstart,
		Progress,
		Timeout
	}
}
