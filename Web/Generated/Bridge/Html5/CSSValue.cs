namespace Bridge.Html5
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class CSSValue
	{
		internal extern CSSValue();

		[Name("CSS_CUSTOM")]
		public const ushort CSS_CUSTOM = 3;

		[Name("CSS_INHERIT")]
		public const ushort CSS_INHERIT = 0;

		[Name("CSS_PRIMITIVE_VALUE")]
		public const ushort CSS_PRIMITIVE_VALUE = 1;

		[Name("CSS_VALUE_LIST")]
		public const ushort CSS_VALUE_LIST = 2;

		public string CssText;

		public readonly ushort CssValueType;
	}
}
