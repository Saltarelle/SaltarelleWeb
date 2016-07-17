namespace Bridge.Html5
{
	[Namespace("false"), External(TypeCheckCode = "{$System.Script}.isInstanceOfType({this}, Element) && {this}.tagName === 'AREA'"), Name("Element")]
	public partial class AreaElement : Element
	{
		internal extern AreaElement();

		public extern void AddEventListener(AreaElementEvents type, Action listener);

		public extern void AddEventListener(AreaElementEvents type, Action listener, bool capture);

		public extern void AddEventListener(AreaElementEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(AreaElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(AreaElementEvents type, HtmlEventHandlerWithTarget<AreaElement> listener);

		public extern void AddEventListener(AreaElementEvents type, HtmlEventHandlerWithTarget<AreaElement> listener, bool capture);

		public extern void AddEventListener(AreaElementEvents type, IEventListener listener);

		public extern void AddEventListener(AreaElementEvents type, IEventListener listener, bool capture);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<AreaElement> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<AreaElement> listener, bool capture);

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

		public extern void RemoveEventListener(AreaElementEvents type, Action listener);

		public extern void RemoveEventListener(AreaElementEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(AreaElementEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(AreaElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(AreaElementEvents type, HtmlEventHandlerWithTarget<AreaElement> listener);

		public extern void RemoveEventListener(AreaElementEvents type, HtmlEventHandlerWithTarget<AreaElement> listener, bool capture);

		public extern void RemoveEventListener(AreaElementEvents type, IEventListener listener);

		public extern void RemoveEventListener(AreaElementEvents type, IEventListener listener, bool capture);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<AreaElement> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<AreaElement> listener, bool capture);

		public string Search;

		public URLSearchParams SearchParams;

		public string Shape;

		public string Target;

		public string Username;
	}
}
