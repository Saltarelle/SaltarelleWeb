namespace Bridge.Html5.Media.Graphics.SVG
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class SVGMaskElement : SVGElement
	{
		internal extern SVGMaskElement();

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<SVGMaskElement> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<SVGMaskElement> listener, bool capture);

		public extern void AddEventListener(SVGMaskElementEvents type, Action listener);

		public extern void AddEventListener(SVGMaskElementEvents type, Action listener, bool capture);

		public extern void AddEventListener(SVGMaskElementEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(SVGMaskElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(SVGMaskElementEvents type, HtmlEventHandlerWithTarget<SVGMaskElement> listener);

		public extern void AddEventListener(SVGMaskElementEvents type, HtmlEventHandlerWithTarget<SVGMaskElement> listener, bool capture);

		public extern void AddEventListener(SVGMaskElementEvents type, IEventListener listener);

		public extern void AddEventListener(SVGMaskElementEvents type, IEventListener listener, bool capture);

		[FieldProperty]
		public extern SVGAnimatedLength Height
		{
			get;
		}

		[FieldProperty]
		public extern SVGAnimatedEnumeration<SVGUnitType> MaskContentUnits
		{
			get;
		}

		[FieldProperty]
		public extern SVGAnimatedEnumeration<SVGUnitType> MaskUnits
		{
			get;
		}

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<SVGMaskElement> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<SVGMaskElement> listener, bool capture);

		public extern void RemoveEventListener(SVGMaskElementEvents type, Action listener);

		public extern void RemoveEventListener(SVGMaskElementEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(SVGMaskElementEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(SVGMaskElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(SVGMaskElementEvents type, HtmlEventHandlerWithTarget<SVGMaskElement> listener);

		public extern void RemoveEventListener(SVGMaskElementEvents type, HtmlEventHandlerWithTarget<SVGMaskElement> listener, bool capture);

		public extern void RemoveEventListener(SVGMaskElementEvents type, IEventListener listener);

		public extern void RemoveEventListener(SVGMaskElementEvents type, IEventListener listener, bool capture);

		[Name("SVG_MASKTYPE_ALPHA")]
		public const ushort SVG_MASKTYPE_ALPHA = 1;

		[Name("SVG_MASKTYPE_LUMINANCE")]
		public const ushort SVG_MASKTYPE_LUMINANCE = 0;

		[Name("SVG_UNIT_TYPE_OBJECTBOUNDINGBOX")]
		public const ushort SVG_UNIT_TYPE_OBJECTBOUNDINGBOX = 2;

		[Name("SVG_UNIT_TYPE_UNKNOWN")]
		public const ushort SVG_UNIT_TYPE_UNKNOWN = 0;

		[Name("SVG_UNIT_TYPE_USERSPACEONUSE")]
		public const ushort SVG_UNIT_TYPE_USERSPACEONUSE = 1;

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
