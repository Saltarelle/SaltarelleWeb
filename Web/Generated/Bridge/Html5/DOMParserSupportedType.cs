namespace Bridge.Html5
{
	[External, Name("String"), Enum(Emit.StringNameLowerCase)]
	public enum DOMParserSupportedType
	{
		[Name("application/xhtml+xml")]
		ApplicationXhtmlXml,
		[Name("application/xml")]
		ApplicationXml,
		[Name("image/svg+xml")]
		ImageSvgXml,
		[Name("text/html")]
		TextHtml,
		[Name("text/xml")]
		TextXml
	}
}
