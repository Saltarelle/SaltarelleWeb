namespace Bridge.Html5.Media.Graphics.SVG
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class SVGCircleElement : SVGGraphicsElement
	{
		internal extern SVGCircleElement();

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<SVGCircleElement> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<SVGCircleElement> listener, bool capture);

		public extern void AddEventListener(SVGCircleElementEvents type, Action listener);

		public extern void AddEventListener(SVGCircleElementEvents type, Action listener, bool capture);

		public extern void AddEventListener(SVGCircleElementEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(SVGCircleElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(SVGCircleElementEvents type, HtmlEventHandlerWithTarget<SVGCircleElement> listener);

		public extern void AddEventListener(SVGCircleElementEvents type, HtmlEventHandlerWithTarget<SVGCircleElement> listener, bool capture);

		public extern void AddEventListener(SVGCircleElementEvents type, IEventListener listener);

		public extern void AddEventListener(SVGCircleElementEvents type, IEventListener listener, bool capture);

		public readonly SVGAnimatedLength Cx;

		public readonly SVGAnimatedLength Cy;

		public readonly SVGAnimatedLength R;

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<SVGCircleElement> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<SVGCircleElement> listener, bool capture);

		public extern void RemoveEventListener(SVGCircleElementEvents type, Action listener);

		public extern void RemoveEventListener(SVGCircleElementEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(SVGCircleElementEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(SVGCircleElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(SVGCircleElementEvents type, HtmlEventHandlerWithTarget<SVGCircleElement> listener);

		public extern void RemoveEventListener(SVGCircleElementEvents type, HtmlEventHandlerWithTarget<SVGCircleElement> listener, bool capture);

		public extern void RemoveEventListener(SVGCircleElementEvents type, IEventListener listener);

		public extern void RemoveEventListener(SVGCircleElementEvents type, IEventListener listener, bool capture);
	}
}
