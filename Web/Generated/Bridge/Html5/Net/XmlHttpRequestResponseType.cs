namespace Bridge.Html5.Net
{
	[External, Name("String"), Enum(Emit.StringNameLowerCase)]
	public enum XmlHttpRequestResponseType
	{
		Arraybuffer,
		Blob,
		Document,
		Json,
		[Name("")]
		String,
		Text
	}
}
