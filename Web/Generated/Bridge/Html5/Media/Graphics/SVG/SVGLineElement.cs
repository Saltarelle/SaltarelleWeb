namespace Bridge.Html5.Media.Graphics.SVG
{
	[Namespace(false), External]
	public partial class SVGLineElement : SVGGraphicsElement
	{
		internal extern SVGLineElement();

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<SVGLineElement> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<SVGLineElement> listener, bool capture);

		public extern void AddEventListener(SVGLineElementEvents type, Action listener);

		public extern void AddEventListener(SVGLineElementEvents type, Action listener, bool capture);

		public extern void AddEventListener(SVGLineElementEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(SVGLineElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(SVGLineElementEvents type, HtmlEventHandlerWithTarget<SVGLineElement> listener);

		public extern void AddEventListener(SVGLineElementEvents type, HtmlEventHandlerWithTarget<SVGLineElement> listener, bool capture);

		public extern void AddEventListener(SVGLineElementEvents type, IEventListener listener);

		public extern void AddEventListener(SVGLineElementEvents type, IEventListener listener, bool capture);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<SVGLineElement> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<SVGLineElement> listener, bool capture);

		public extern void RemoveEventListener(SVGLineElementEvents type, Action listener);

		public extern void RemoveEventListener(SVGLineElementEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(SVGLineElementEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(SVGLineElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(SVGLineElementEvents type, HtmlEventHandlerWithTarget<SVGLineElement> listener);

		public extern void RemoveEventListener(SVGLineElementEvents type, HtmlEventHandlerWithTarget<SVGLineElement> listener, bool capture);

		public extern void RemoveEventListener(SVGLineElementEvents type, IEventListener listener);

		public extern void RemoveEventListener(SVGLineElementEvents type, IEventListener listener, bool capture);

		public readonly SVGAnimatedLength X1;

		public readonly SVGAnimatedLength X2;

		public readonly SVGAnimatedLength Y1;

		public readonly SVGAnimatedLength Y2;
	}
}
