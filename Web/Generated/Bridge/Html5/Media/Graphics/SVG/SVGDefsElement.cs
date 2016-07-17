namespace Bridge.Html5.Media.Graphics.SVG
{
	[Namespace(false), External]
	public partial class SVGDefsElement : SVGGraphicsElement
	{
		internal extern SVGDefsElement();

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<SVGDefsElement> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<SVGDefsElement> listener, bool capture);

		public extern void AddEventListener(SVGDefsElementEvents type, Action listener);

		public extern void AddEventListener(SVGDefsElementEvents type, Action listener, bool capture);

		public extern void AddEventListener(SVGDefsElementEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(SVGDefsElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(SVGDefsElementEvents type, HtmlEventHandlerWithTarget<SVGDefsElement> listener);

		public extern void AddEventListener(SVGDefsElementEvents type, HtmlEventHandlerWithTarget<SVGDefsElement> listener, bool capture);

		public extern void AddEventListener(SVGDefsElementEvents type, IEventListener listener);

		public extern void AddEventListener(SVGDefsElementEvents type, IEventListener listener, bool capture);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<SVGDefsElement> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<SVGDefsElement> listener, bool capture);

		public extern void RemoveEventListener(SVGDefsElementEvents type, Action listener);

		public extern void RemoveEventListener(SVGDefsElementEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(SVGDefsElementEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(SVGDefsElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(SVGDefsElementEvents type, HtmlEventHandlerWithTarget<SVGDefsElement> listener);

		public extern void RemoveEventListener(SVGDefsElementEvents type, HtmlEventHandlerWithTarget<SVGDefsElement> listener, bool capture);

		public extern void RemoveEventListener(SVGDefsElementEvents type, IEventListener listener);

		public extern void RemoveEventListener(SVGDefsElementEvents type, IEventListener listener, bool capture);
	}
}
