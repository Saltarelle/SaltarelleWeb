using System.Runtime.CompilerServices;

namespace System.Html {
	[Imported, NamedValues]
	public enum DOMParserSupportedType {
		[ScriptName("text/html")]
		TextHtml,
		[ScriptName("text/xml")]
		TextXml,
		[ScriptName("application/xml")]
		ApplicationXml,
		[ScriptName("application/xhtml+xml")]
		ApplicationXhtmlXml,
		[ScriptName("image/svg+xml")]
		ImageSvgXml
	}
}
