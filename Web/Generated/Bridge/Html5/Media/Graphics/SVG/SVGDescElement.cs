namespace Bridge.Html5.Media.Graphics.SVG
{
	[Namespace(false), External]
	public partial class SVGDescElement : SVGElement
	{
		internal extern SVGDescElement();

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<SVGDescElement> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<SVGDescElement> listener, bool capture);

		public extern void AddEventListener(SVGDescElementEvents type, Action listener);

		public extern void AddEventListener(SVGDescElementEvents type, Action listener, bool capture);

		public extern void AddEventListener(SVGDescElementEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(SVGDescElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(SVGDescElementEvents type, HtmlEventHandlerWithTarget<SVGDescElement> listener);

		public extern void AddEventListener(SVGDescElementEvents type, HtmlEventHandlerWithTarget<SVGDescElement> listener, bool capture);

		public extern void AddEventListener(SVGDescElementEvents type, IEventListener listener);

		public extern void AddEventListener(SVGDescElementEvents type, IEventListener listener, bool capture);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<SVGDescElement> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<SVGDescElement> listener, bool capture);

		public extern void RemoveEventListener(SVGDescElementEvents type, Action listener);

		public extern void RemoveEventListener(SVGDescElementEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(SVGDescElementEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(SVGDescElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(SVGDescElementEvents type, HtmlEventHandlerWithTarget<SVGDescElement> listener);

		public extern void RemoveEventListener(SVGDescElementEvents type, HtmlEventHandlerWithTarget<SVGDescElement> listener, bool capture);

		public extern void RemoveEventListener(SVGDescElementEvents type, IEventListener listener);

		public extern void RemoveEventListener(SVGDescElementEvents type, IEventListener listener, bool capture);
	}
}
