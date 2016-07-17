namespace Bridge.Html5.Media.Graphics.SVG
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class SVGViewElement : SVGElement
	{
		internal extern SVGViewElement();

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<SVGViewElement> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<SVGViewElement> listener, bool capture);

		public extern void AddEventListener(SVGViewElementEvents type, Action listener);

		public extern void AddEventListener(SVGViewElementEvents type, Action listener, bool capture);

		public extern void AddEventListener(SVGViewElementEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(SVGViewElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(SVGViewElementEvents type, HtmlEventHandlerWithTarget<SVGViewElement> listener);

		public extern void AddEventListener(SVGViewElementEvents type, HtmlEventHandlerWithTarget<SVGViewElement> listener, bool capture);

		public extern void AddEventListener(SVGViewElementEvents type, IEventListener listener);

		public extern void AddEventListener(SVGViewElementEvents type, IEventListener listener, bool capture);

		public readonly SVGAnimatedPreserveAspectRatio PreserveAspectRatio;

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<SVGViewElement> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<SVGViewElement> listener, bool capture);

		public extern void RemoveEventListener(SVGViewElementEvents type, Action listener);

		public extern void RemoveEventListener(SVGViewElementEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(SVGViewElementEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(SVGViewElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(SVGViewElementEvents type, HtmlEventHandlerWithTarget<SVGViewElement> listener);

		public extern void RemoveEventListener(SVGViewElementEvents type, HtmlEventHandlerWithTarget<SVGViewElement> listener, bool capture);

		public extern void RemoveEventListener(SVGViewElementEvents type, IEventListener listener);

		public extern void RemoveEventListener(SVGViewElementEvents type, IEventListener listener, bool capture);

		[Name("SVG_ZOOMANDPAN_DISABLE")]
		public const ushort SVG_ZOOMANDPAN_DISABLE = 1;

		[Name("SVG_ZOOMANDPAN_MAGNIFY")]
		public const ushort SVG_ZOOMANDPAN_MAGNIFY = 2;

		[Name("SVG_ZOOMANDPAN_UNKNOWN")]
		public const ushort SVG_ZOOMANDPAN_UNKNOWN = 0;

		public readonly SVGAnimatedRect ViewBox;

		public readonly SVGStringList ViewTarget;

		public SVGZoomAndPanType ZoomAndPan;
	}
}
