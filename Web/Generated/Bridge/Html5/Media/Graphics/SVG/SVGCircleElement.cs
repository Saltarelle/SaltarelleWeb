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

		[FieldProperty]
		public extern SVGAnimatedLength Cx
		{
			get;
		}

		[FieldProperty]
		public extern SVGAnimatedLength Cy
		{
			get;
		}

		[FieldProperty]
		public extern SVGAnimatedLength R
		{
			get;
		}

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
