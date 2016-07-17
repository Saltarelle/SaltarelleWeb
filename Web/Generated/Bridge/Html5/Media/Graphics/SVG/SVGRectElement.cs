namespace Bridge.Html5.Media.Graphics.SVG
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class SVGRectElement : SVGGraphicsElement
	{
		internal extern SVGRectElement();

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<SVGRectElement> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<SVGRectElement> listener, bool capture);

		public extern void AddEventListener(SVGRectElementEvents type, Action listener);

		public extern void AddEventListener(SVGRectElementEvents type, Action listener, bool capture);

		public extern void AddEventListener(SVGRectElementEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(SVGRectElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(SVGRectElementEvents type, HtmlEventHandlerWithTarget<SVGRectElement> listener);

		public extern void AddEventListener(SVGRectElementEvents type, HtmlEventHandlerWithTarget<SVGRectElement> listener, bool capture);

		public extern void AddEventListener(SVGRectElementEvents type, IEventListener listener);

		public extern void AddEventListener(SVGRectElementEvents type, IEventListener listener, bool capture);

		public readonly SVGAnimatedLength Height;

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<SVGRectElement> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<SVGRectElement> listener, bool capture);

		public extern void RemoveEventListener(SVGRectElementEvents type, Action listener);

		public extern void RemoveEventListener(SVGRectElementEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(SVGRectElementEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(SVGRectElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(SVGRectElementEvents type, HtmlEventHandlerWithTarget<SVGRectElement> listener);

		public extern void RemoveEventListener(SVGRectElementEvents type, HtmlEventHandlerWithTarget<SVGRectElement> listener, bool capture);

		public extern void RemoveEventListener(SVGRectElementEvents type, IEventListener listener);

		public extern void RemoveEventListener(SVGRectElementEvents type, IEventListener listener, bool capture);

		public readonly SVGAnimatedLength Rx;

		public readonly SVGAnimatedLength Ry;

		public readonly SVGAnimatedLength Width;

		public readonly SVGAnimatedLength X;

		public readonly SVGAnimatedLength Y;
	}
}
