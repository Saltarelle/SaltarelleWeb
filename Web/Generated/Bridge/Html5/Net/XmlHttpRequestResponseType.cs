namespace Bridge.Html5.Net
{
	[External, Name("String"), Enum(Emit.StringNameLowerCase)]
	public enum XmlHttpRequestResponseType
	{
		[Name("")]
		String,
		Arraybuffer,
		Blob,
		Document,
		Json,
		Text
	}
}
