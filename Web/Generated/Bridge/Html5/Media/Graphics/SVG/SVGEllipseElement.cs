namespace Bridge.Html5.Media.Graphics.SVG
{
	[Namespace("false"), External]
	public partial class SVGEllipseElement : SVGGraphicsElement
	{
		internal extern SVGEllipseElement();

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<SVGEllipseElement> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<SVGEllipseElement> listener, bool capture);

		public extern void AddEventListener(SVGEllipseElementEvents type, Action listener);

		public extern void AddEventListener(SVGEllipseElementEvents type, Action listener, bool capture);

		public extern void AddEventListener(SVGEllipseElementEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(SVGEllipseElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(SVGEllipseElementEvents type, HtmlEventHandlerWithTarget<SVGEllipseElement> listener);

		public extern void AddEventListener(SVGEllipseElementEvents type, HtmlEventHandlerWithTarget<SVGEllipseElement> listener, bool capture);

		public extern void AddEventListener(SVGEllipseElementEvents type, IEventListener listener);

		public extern void AddEventListener(SVGEllipseElementEvents type, IEventListener listener, bool capture);

		public readonly SVGAnimatedLength Cx;

		public readonly SVGAnimatedLength Cy;

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<SVGEllipseElement> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<SVGEllipseElement> listener, bool capture);

		public extern void RemoveEventListener(SVGEllipseElementEvents type, Action listener);

		public extern void RemoveEventListener(SVGEllipseElementEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(SVGEllipseElementEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(SVGEllipseElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(SVGEllipseElementEvents type, HtmlEventHandlerWithTarget<SVGEllipseElement> listener);

		public extern void RemoveEventListener(SVGEllipseElementEvents type, HtmlEventHandlerWithTarget<SVGEllipseElement> listener, bool capture);

		public extern void RemoveEventListener(SVGEllipseElementEvents type, IEventListener listener);

		public extern void RemoveEventListener(SVGEllipseElementEvents type, IEventListener listener, bool capture);

		public readonly SVGAnimatedLength Rx;

		public readonly SVGAnimatedLength Ry;
	}
}
