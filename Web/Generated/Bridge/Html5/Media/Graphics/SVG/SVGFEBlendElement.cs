namespace Bridge.Html5.Media.Graphics.SVG
{
	[Namespace(false), External]
	public partial class SVGFEBlendElement : SVGElement
	{
		internal extern SVGFEBlendElement();

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<SVGFEBlendElement> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<SVGFEBlendElement> listener, bool capture);

		public extern void AddEventListener(SVGFEBlendElementEvents type, Action listener);

		public extern void AddEventListener(SVGFEBlendElementEvents type, Action listener, bool capture);

		public extern void AddEventListener(SVGFEBlendElementEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(SVGFEBlendElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(SVGFEBlendElementEvents type, HtmlEventHandlerWithTarget<SVGFEBlendElement> listener);

		public extern void AddEventListener(SVGFEBlendElementEvents type, HtmlEventHandlerWithTarget<SVGFEBlendElement> listener, bool capture);

		public extern void AddEventListener(SVGFEBlendElementEvents type, IEventListener listener);

		public extern void AddEventListener(SVGFEBlendElementEvents type, IEventListener listener, bool capture);

		public readonly SVGAnimatedLength Height;

		public readonly SVGAnimatedString In1;

		public readonly SVGAnimatedString In2;

		public readonly SVGAnimatedEnumeration<SVGFEBlendMode> Mode;

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<SVGFEBlendElement> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<SVGFEBlendElement> listener, bool capture);

		public extern void RemoveEventListener(SVGFEBlendElementEvents type, Action listener);

		public extern void RemoveEventListener(SVGFEBlendElementEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(SVGFEBlendElementEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(SVGFEBlendElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(SVGFEBlendElementEvents type, HtmlEventHandlerWithTarget<SVGFEBlendElement> listener);

		public extern void RemoveEventListener(SVGFEBlendElementEvents type, HtmlEventHandlerWithTarget<SVGFEBlendElement> listener, bool capture);

		public extern void RemoveEventListener(SVGFEBlendElementEvents type, IEventListener listener);

		public extern void RemoveEventListener(SVGFEBlendElementEvents type, IEventListener listener, bool capture);

		public readonly SVGAnimatedString Result;

		[Name("SVG_FEBLEND_MODE_DARKEN")]
		public const ushort SVG_FEBLEND_MODE_DARKEN = 4;

		[Name("SVG_FEBLEND_MODE_LIGHTEN")]
		public const ushort SVG_FEBLEND_MODE_LIGHTEN = 5;

		[Name("SVG_FEBLEND_MODE_MULTIPLY")]
		public const ushort SVG_FEBLEND_MODE_MULTIPLY = 2;

		[Name("SVG_FEBLEND_MODE_NORMAL")]
		public const ushort SVG_FEBLEND_MODE_NORMAL = 1;

		[Name("SVG_FEBLEND_MODE_SCREEN")]
		public const ushort SVG_FEBLEND_MODE_SCREEN = 3;

		[Name("SVG_FEBLEND_MODE_UNKNOWN")]
		public const ushort SVG_FEBLEND_MODE_UNKNOWN = 0;

		public readonly SVGAnimatedLength Width;

		public readonly SVGAnimatedLength X;

		public readonly SVGAnimatedLength Y;
	}
}
