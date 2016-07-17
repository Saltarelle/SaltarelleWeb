namespace Bridge.Html5.Media.Graphics.SVG
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class SVGPolygonElement : SVGGraphicsElement
	{
		internal extern SVGPolygonElement();

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<SVGPolygonElement> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<SVGPolygonElement> listener, bool capture);

		public extern void AddEventListener(SVGPolygonElementEvents type, Action listener);

		public extern void AddEventListener(SVGPolygonElementEvents type, Action listener, bool capture);

		public extern void AddEventListener(SVGPolygonElementEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(SVGPolygonElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(SVGPolygonElementEvents type, HtmlEventHandlerWithTarget<SVGPolygonElement> listener);

		public extern void AddEventListener(SVGPolygonElementEvents type, HtmlEventHandlerWithTarget<SVGPolygonElement> listener, bool capture);

		public extern void AddEventListener(SVGPolygonElementEvents type, IEventListener listener);

		public extern void AddEventListener(SVGPolygonElementEvents type, IEventListener listener, bool capture);

		public readonly SVGPointList AnimatedPoints;

		public readonly SVGPointList Points;

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<SVGPolygonElement> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<SVGPolygonElement> listener, bool capture);

		public extern void RemoveEventListener(SVGPolygonElementEvents type, Action listener);

		public extern void RemoveEventListener(SVGPolygonElementEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(SVGPolygonElementEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(SVGPolygonElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(SVGPolygonElementEvents type, HtmlEventHandlerWithTarget<SVGPolygonElement> listener);

		public extern void RemoveEventListener(SVGPolygonElementEvents type, HtmlEventHandlerWithTarget<SVGPolygonElement> listener, bool capture);

		public extern void RemoveEventListener(SVGPolygonElementEvents type, IEventListener listener);

		public extern void RemoveEventListener(SVGPolygonElementEvents type, IEventListener listener, bool capture);
	}
}
