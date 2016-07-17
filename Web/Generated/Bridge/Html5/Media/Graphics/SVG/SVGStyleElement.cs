namespace Bridge.Html5.Media.Graphics.SVG
{
	[Namespace(false), External]
	public partial class SVGStyleElement : SVGElement
	{
		internal extern SVGStyleElement();

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<SVGStyleElement> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<SVGStyleElement> listener, bool capture);

		public extern void AddEventListener(SVGStyleElementEvents type, Action listener);

		public extern void AddEventListener(SVGStyleElementEvents type, Action listener, bool capture);

		public extern void AddEventListener(SVGStyleElementEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(SVGStyleElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(SVGStyleElementEvents type, HtmlEventHandlerWithTarget<SVGStyleElement> listener);

		public extern void AddEventListener(SVGStyleElementEvents type, HtmlEventHandlerWithTarget<SVGStyleElement> listener, bool capture);

		public extern void AddEventListener(SVGStyleElementEvents type, IEventListener listener);

		public extern void AddEventListener(SVGStyleElementEvents type, IEventListener listener, bool capture);

		public string Media;

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<SVGStyleElement> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<SVGStyleElement> listener, bool capture);

		public extern void RemoveEventListener(SVGStyleElementEvents type, Action listener);

		public extern void RemoveEventListener(SVGStyleElementEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(SVGStyleElementEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(SVGStyleElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(SVGStyleElementEvents type, HtmlEventHandlerWithTarget<SVGStyleElement> listener);

		public extern void RemoveEventListener(SVGStyleElementEvents type, HtmlEventHandlerWithTarget<SVGStyleElement> listener, bool capture);

		public extern void RemoveEventListener(SVGStyleElementEvents type, IEventListener listener);

		public extern void RemoveEventListener(SVGStyleElementEvents type, IEventListener listener, bool capture);

		public bool Scoped;

		public string Title;

		public string Type;

		public string Xmlspace;
	}
}
