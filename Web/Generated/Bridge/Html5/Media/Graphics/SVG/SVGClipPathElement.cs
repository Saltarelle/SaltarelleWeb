namespace Bridge.Html5.Media.Graphics.SVG
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class SVGClipPathElement : SVGElement
	{
		internal extern SVGClipPathElement();

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<SVGClipPathElement> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<SVGClipPathElement> listener, bool capture);

		public extern void AddEventListener(SVGClipPathElementEvents type, Action listener);

		public extern void AddEventListener(SVGClipPathElementEvents type, Action listener, bool capture);

		public extern void AddEventListener(SVGClipPathElementEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(SVGClipPathElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(SVGClipPathElementEvents type, HtmlEventHandlerWithTarget<SVGClipPathElement> listener);

		public extern void AddEventListener(SVGClipPathElementEvents type, HtmlEventHandlerWithTarget<SVGClipPathElement> listener, bool capture);

		public extern void AddEventListener(SVGClipPathElementEvents type, IEventListener listener);

		public extern void AddEventListener(SVGClipPathElementEvents type, IEventListener listener, bool capture);

		[FieldProperty]
		public extern SVGAnimatedEnumeration<SVGUnitType> ClipPathUnits
		{
			get;
		}

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<SVGClipPathElement> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<SVGClipPathElement> listener, bool capture);

		public extern void RemoveEventListener(SVGClipPathElementEvents type, Action listener);

		public extern void RemoveEventListener(SVGClipPathElementEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(SVGClipPathElementEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(SVGClipPathElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(SVGClipPathElementEvents type, HtmlEventHandlerWithTarget<SVGClipPathElement> listener);

		public extern void RemoveEventListener(SVGClipPathElementEvents type, HtmlEventHandlerWithTarget<SVGClipPathElement> listener, bool capture);

		public extern void RemoveEventListener(SVGClipPathElementEvents type, IEventListener listener);

		public extern void RemoveEventListener(SVGClipPathElementEvents type, IEventListener listener, bool capture);

		[Name("SVG_UNIT_TYPE_OBJECTBOUNDINGBOX")]
		public const ushort SVG_UNIT_TYPE_OBJECTBOUNDINGBOX = 2;

		[Name("SVG_UNIT_TYPE_UNKNOWN")]
		public const ushort SVG_UNIT_TYPE_UNKNOWN = 0;

		[Name("SVG_UNIT_TYPE_USERSPACEONUSE")]
		public const ushort SVG_UNIT_TYPE_USERSPACEONUSE = 1;

		[FieldProperty]
		public extern SVGAnimatedTransformList Transform
		{
			get;
		}
	}
}
