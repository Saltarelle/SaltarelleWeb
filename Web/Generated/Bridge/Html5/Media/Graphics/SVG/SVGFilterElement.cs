namespace Bridge.Html5.Media.Graphics.SVG
{
	[Namespace("false"), External]
	public partial class SVGFilterElement : SVGElement
	{
		internal extern SVGFilterElement();

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<SVGFilterElement> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<SVGFilterElement> listener, bool capture);

		public extern void AddEventListener(SVGFilterElementEvents type, Action listener);

		public extern void AddEventListener(SVGFilterElementEvents type, Action listener, bool capture);

		public extern void AddEventListener(SVGFilterElementEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(SVGFilterElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(SVGFilterElementEvents type, HtmlEventHandlerWithTarget<SVGFilterElement> listener);

		public extern void AddEventListener(SVGFilterElementEvents type, HtmlEventHandlerWithTarget<SVGFilterElement> listener, bool capture);

		public extern void AddEventListener(SVGFilterElementEvents type, IEventListener listener);

		public extern void AddEventListener(SVGFilterElementEvents type, IEventListener listener, bool capture);

		public readonly SVGAnimatedEnumeration<SVGUnitType> FilterUnits;

		public readonly SVGAnimatedLength Height;

		public readonly SVGAnimatedString Href;

		public readonly SVGAnimatedEnumeration<SVGUnitType> PrimitiveUnits;

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<SVGFilterElement> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<SVGFilterElement> listener, bool capture);

		public extern void RemoveEventListener(SVGFilterElementEvents type, Action listener);

		public extern void RemoveEventListener(SVGFilterElementEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(SVGFilterElementEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(SVGFilterElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(SVGFilterElementEvents type, HtmlEventHandlerWithTarget<SVGFilterElement> listener);

		public extern void RemoveEventListener(SVGFilterElementEvents type, HtmlEventHandlerWithTarget<SVGFilterElement> listener, bool capture);

		public extern void RemoveEventListener(SVGFilterElementEvents type, IEventListener listener);

		public extern void RemoveEventListener(SVGFilterElementEvents type, IEventListener listener, bool capture);

		[Name("SVG_UNIT_TYPE_OBJECTBOUNDINGBOX")]
		public const ushort SVG_UNIT_TYPE_OBJECTBOUNDINGBOX = 2;

		[Name("SVG_UNIT_TYPE_UNKNOWN")]
		public const ushort SVG_UNIT_TYPE_UNKNOWN = 0;

		[Name("SVG_UNIT_TYPE_USERSPACEONUSE")]
		public const ushort SVG_UNIT_TYPE_USERSPACEONUSE = 1;

		public readonly SVGAnimatedLength Width;

		public readonly SVGAnimatedLength X;

		public readonly SVGAnimatedLength Y;
	}
}
