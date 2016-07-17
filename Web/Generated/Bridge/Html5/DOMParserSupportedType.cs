namespace Bridge.Html5
{
	[External, Name("String"), Enum(Emit.StringNameLowerCase)]
	public enum DOMParserSupportedType
	{
		[Name("text/html")]
		TextHtml,
		[Name("text/xml")]
		TextXml,
		[Name("application/xml")]
		ApplicationXml,
		[Name("application/xhtml+xml")]
		ApplicationXhtmlXml,
		[Name("image/svg+xml")]
		ImageSvgXml
	}
}
