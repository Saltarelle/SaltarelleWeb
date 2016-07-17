namespace Bridge.Html5.Media.Graphics.SVG
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class SVGMarkerElement : SVGElement
	{
		internal extern SVGMarkerElement();

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<SVGMarkerElement> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<SVGMarkerElement> listener, bool capture);

		public extern void AddEventListener(SVGMarkerElementEvents type, Action listener);

		public extern void AddEventListener(SVGMarkerElementEvents type, Action listener, bool capture);

		public extern void AddEventListener(SVGMarkerElementEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(SVGMarkerElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(SVGMarkerElementEvents type, HtmlEventHandlerWithTarget<SVGMarkerElement> listener);

		public extern void AddEventListener(SVGMarkerElementEvents type, HtmlEventHandlerWithTarget<SVGMarkerElement> listener, bool capture);

		public extern void AddEventListener(SVGMarkerElementEvents type, IEventListener listener);

		public extern void AddEventListener(SVGMarkerElementEvents type, IEventListener listener, bool capture);

		public readonly SVGAnimatedLength MarkerHeight;

		public readonly SVGAnimatedEnumeration<SVGMarkerUnits> MarkerUnits;

		public readonly SVGAnimatedLength MarkerWidth;

		public readonly SVGAnimatedAngle OrientAngle;

		public readonly SVGAnimatedEnumeration<SVGMarkerOrient> OrientType;

		public readonly SVGAnimatedPreserveAspectRatio PreserveAspectRatio;

		public readonly SVGAnimatedLength RefX;

		public readonly SVGAnimatedLength RefY;

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<SVGMarkerElement> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<SVGMarkerElement> listener, bool capture);

		public extern void RemoveEventListener(SVGMarkerElementEvents type, Action listener);

		public extern void RemoveEventListener(SVGMarkerElementEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(SVGMarkerElementEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(SVGMarkerElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(SVGMarkerElementEvents type, HtmlEventHandlerWithTarget<SVGMarkerElement> listener);

		public extern void RemoveEventListener(SVGMarkerElementEvents type, HtmlEventHandlerWithTarget<SVGMarkerElement> listener, bool capture);

		public extern void RemoveEventListener(SVGMarkerElementEvents type, IEventListener listener);

		public extern void RemoveEventListener(SVGMarkerElementEvents type, IEventListener listener, bool capture);

		public extern void SetOrientToAngle(SVGAngle angle);

		public extern void SetOrientToAuto();

		[Name("SVG_MARKER_ORIENT_ANGLE")]
		public const ushort SVG_MARKER_ORIENT_ANGLE = 2;

		[Name("SVG_MARKER_ORIENT_AUTO")]
		public const ushort SVG_MARKER_ORIENT_AUTO = 1;

		[Name("SVG_MARKER_ORIENT_UNKNOWN")]
		public const ushort SVG_MARKER_ORIENT_UNKNOWN = 0;

		[Name("SVG_MARKERUNITS_STROKEWIDTH")]
		public const ushort SVG_MARKERUNITS_STROKEWIDTH = 2;

		[Name("SVG_MARKERUNITS_UNKNOWN")]
		public const ushort SVG_MARKERUNITS_UNKNOWN = 0;

		[Name("SVG_MARKERUNITS_USERSPACEONUSE")]
		public const ushort SVG_MARKERUNITS_USERSPACEONUSE = 1;

		public readonly SVGAnimatedRect ViewBox;
	}
}
