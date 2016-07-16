namespace Bridge.Html5.Media.Graphics.SVG
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
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

		[FieldProperty]
		public extern SVGAnimatedLength Height
		{
			get;
		}

		[FieldProperty]
		public extern SVGAnimatedString In1
		{
			get;
		}

		[FieldProperty]
		public extern SVGAnimatedString In2
		{
			get;
		}

		[FieldProperty]
		public extern SVGAnimatedEnumeration<SVGFEBlendMode> Mode
		{
			get;
		}

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

		[FieldProperty]
		public extern SVGAnimatedString Result
		{
			get;
		}

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

		[FieldProperty]
		public extern SVGAnimatedLength Width
		{
			get;
		}

		[FieldProperty]
		public extern SVGAnimatedLength X
		{
			get;
		}

		[FieldProperty]
		public extern SVGAnimatedLength Y
		{
			get;
		}
	}
}
