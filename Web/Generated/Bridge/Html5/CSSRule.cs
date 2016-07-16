namespace Bridge.Html5
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class CSSRule
	{
		internal CSSRule()
		{
		}

		[Name("CHARSET_RULE")]
		public const ushort CHARSET_RULE = 2;

		[FieldProperty]
		public string CssText
		{
			get {
				return null;
			}
			set {
			}
		}

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

		[FieldProperty]
		public CSSRule ParentRule
		{
			get {
				return default(CSSRule);
			}
		}

		[FieldProperty]
		public CSSStyleSheet ParentStyleSheet
		{
			get {
				return default(CSSStyleSheet);
			}
		}

		[Name("STYLE_RULE")]
		public const ushort STYLE_RULE = 1;

		[FieldProperty]
		public CSSRuleType Type
		{
			get {
				return default(CSSRuleType);
			}
		}
	}
}
