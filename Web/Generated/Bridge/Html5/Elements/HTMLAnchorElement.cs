namespace Bridge.Html5.Elements
{
	[Namespace(false), External, Name("Element")]
	public partial class HTMLAnchorElement : HTMLElement
	{
		internal extern HTMLAnchorElement();

		public extern void AddEventListener(HTMLAnchorElementEvents type, Action listener);

		public extern void AddEventListener(HTMLAnchorElementEvents type, Action listener, bool capture);

		public extern void AddEventListener(HTMLAnchorElementEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(HTMLAnchorElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(HTMLAnchorElementEvents type, HtmlEventHandlerWithTarget<HTMLAnchorElement> listener);

		public extern void AddEventListener(HTMLAnchorElementEvents type, HtmlEventHandlerWithTarget<HTMLAnchorElement> listener, bool capture);

		public extern void AddEventListener(HTMLAnchorElementEvents type, IEventListener listener);

		public extern void AddEventListener(HTMLAnchorElementEvents type, IEventListener listener, bool capture);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<HTMLAnchorElement> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<HTMLAnchorElement> listener, bool capture);

		public string Charset;

		public string Coords;

		public string Download;

		public string Hash;

		public string Host;

		public string Hostname;

		public string Href;

		public string Hreflang;

		public string Name;

		public readonly string Origin;

		public string Password;

		public string Pathname;

		public string Ping;

		public string Port;

		public string Protocol;

		public string Rel;

		public readonly TokenList RelList;

		public extern void RemoveEventListener(HTMLAnchorElementEvents type, Action listener);

		public extern void RemoveEventListener(HTMLAnchorElementEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(HTMLAnchorElementEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(HTMLAnchorElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(HTMLAnchorElementEvents type, HtmlEventHandlerWithTarget<HTMLAnchorElement> listener);

		public extern void RemoveEventListener(HTMLAnchorElementEvents type, HtmlEventHandlerWithTarget<HTMLAnchorElement> listener, bool capture);

		public extern void RemoveEventListener(HTMLAnchorElementEvents type, IEventListener listener);

		public extern void RemoveEventListener(HTMLAnchorElementEvents type, IEventListener listener, bool capture);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<HTMLAnchorElement> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<HTMLAnchorElement> listener, bool capture);

		public string Rev;

		public string Search;

		public URLSearchParams SearchParams;

		public string Shape;

		public string Target;

		public string Text;

		public string Type;

		public string Username;
	}
}
