namespace Bridge.Html5.Media.Graphics.SVG
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class SVGPatternElement : SVGElement
	{
		internal extern SVGPatternElement();

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<SVGPatternElement> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<SVGPatternElement> listener, bool capture);

		public extern void AddEventListener(SVGPatternElementEvents type, Action listener);

		public extern void AddEventListener(SVGPatternElementEvents type, Action listener, bool capture);

		public extern void AddEventListener(SVGPatternElementEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(SVGPatternElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(SVGPatternElementEvents type, HtmlEventHandlerWithTarget<SVGPatternElement> listener);

		public extern void AddEventListener(SVGPatternElementEvents type, HtmlEventHandlerWithTarget<SVGPatternElement> listener, bool capture);

		public extern void AddEventListener(SVGPatternElementEvents type, IEventListener listener);

		public extern void AddEventListener(SVGPatternElementEvents type, IEventListener listener, bool capture);

		[FieldProperty]
		public extern SVGAnimatedLength Height
		{
			get;
		}

		[FieldProperty]
		public extern SVGAnimatedString Href
		{
			get;
		}

		[FieldProperty]
		public extern SVGAnimatedEnumeration<SVGUnitType> PatternContentUnits
		{
			get;
		}

		[FieldProperty]
		public extern SVGAnimatedTransformList PatternTransform
		{
			get;
		}

		[FieldProperty]
		public extern SVGAnimatedEnumeration<SVGUnitType> PatternUnits
		{
			get;
		}

		[FieldProperty]
		public extern SVGAnimatedPreserveAspectRatio PreserveAspectRatio
		{
			get;
		}

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<SVGPatternElement> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<SVGPatternElement> listener, bool capture);

		public extern void RemoveEventListener(SVGPatternElementEvents type, Action listener);

		public extern void RemoveEventListener(SVGPatternElementEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(SVGPatternElementEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(SVGPatternElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(SVGPatternElementEvents type, HtmlEventHandlerWithTarget<SVGPatternElement> listener);

		public extern void RemoveEventListener(SVGPatternElementEvents type, HtmlEventHandlerWithTarget<SVGPatternElement> listener, bool capture);

		public extern void RemoveEventListener(SVGPatternElementEvents type, IEventListener listener);

		public extern void RemoveEventListener(SVGPatternElementEvents type, IEventListener listener, bool capture);

		[Name("SVG_UNIT_TYPE_OBJECTBOUNDINGBOX")]
		public const ushort SVG_UNIT_TYPE_OBJECTBOUNDINGBOX = 2;

		[Name("SVG_UNIT_TYPE_UNKNOWN")]
		public const ushort SVG_UNIT_TYPE_UNKNOWN = 0;

		[Name("SVG_UNIT_TYPE_USERSPACEONUSE")]
		public const ushort SVG_UNIT_TYPE_USERSPACEONUSE = 1;

		[FieldProperty]
		public extern SVGAnimatedRect ViewBox
		{
			get;
		}

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
