namespace Bridge.Html5.Elements
{
	[Namespace(false), External, Name("Element")]
	public partial class HTMLAreaElement : HTMLElement
	{
		internal extern HTMLAreaElement();

		public extern void AddEventListener(HTMLAreaElementEvents type, Action listener);

		public extern void AddEventListener(HTMLAreaElementEvents type, Action listener, bool capture);

		public extern void AddEventListener(HTMLAreaElementEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(HTMLAreaElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(HTMLAreaElementEvents type, HtmlEventHandlerWithTarget<HTMLAreaElement> listener);

		public extern void AddEventListener(HTMLAreaElementEvents type, HtmlEventHandlerWithTarget<HTMLAreaElement> listener, bool capture);

		public extern void AddEventListener(HTMLAreaElementEvents type, IEventListener listener);

		public extern void AddEventListener(HTMLAreaElementEvents type, IEventListener listener, bool capture);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<HTMLAreaElement> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<HTMLAreaElement> listener, bool capture);

		public string Alt;

		public string Coords;

		public string Download;

		public string Hash;

		public string Host;

		public string Hostname;

		public string Href;

		public bool NoHref;

		public readonly string Origin;

		public string Password;

		public string Pathname;

		public string Ping;

		public string Port;

		public string Protocol;

		public string Rel;

		public readonly TokenList RelList;

		public extern void RemoveEventListener(HTMLAreaElementEvents type, Action listener);

		public extern void RemoveEventListener(HTMLAreaElementEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(HTMLAreaElementEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(HTMLAreaElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(HTMLAreaElementEvents type, HtmlEventHandlerWithTarget<HTMLAreaElement> listener);

		public extern void RemoveEventListener(HTMLAreaElementEvents type, HtmlEventHandlerWithTarget<HTMLAreaElement> listener, bool capture);

		public extern void RemoveEventListener(HTMLAreaElementEvents type, IEventListener listener);

		public extern void RemoveEventListener(HTMLAreaElementEvents type, IEventListener listener, bool capture);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<HTMLAreaElement> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<HTMLAreaElement> listener, bool capture);

		public string Search;

		public URLSearchParams SearchParams;

		public string Shape;

		public string Target;

		public string Username;
	}
}
