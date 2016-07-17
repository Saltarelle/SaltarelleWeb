namespace Bridge.Html5
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class CSSRule
	{
		internal extern CSSRule();

		[Name("CHARSET_RULE")]
		public const ushort CHARSET_RULE = 2;

		public string CssText;

		[Name("FONT_FACE_RULE")]
		public const ushort FONT_FACE_RULE = 5;

		[Name("IMPORT_RULE")]
		public const ushort IMPORT_RULE = 3;

		[Name("MEDIA_RULE")]
		public const ushort MEDIA_RULE = 4;

		[Name("NAMESPACE_RULE")]
		public const ushort NAMESPACE_RULE = 10;

		[Name("PAGE_RULE")]
		public const ushort PAGE_RULE = 6;

		public readonly CSSRule ParentRule;

		public readonly CSSStyleSheet ParentStyleSheet;

		[Name("STYLE_RULE")]
		public const ushort STYLE_RULE = 1;

		public readonly CSSRuleType Type;
	}
}
