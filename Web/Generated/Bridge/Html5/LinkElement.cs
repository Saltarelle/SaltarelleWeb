namespace Bridge.Html5
{
	[Namespace("false"), External(TypeCheckCode = "{$System.Script}.isInstanceOfType({this}, Element) && {this}.tagName === 'LINK'"), Name("Element")]
	public partial class LinkElement : Element
	{
		internal extern LinkElement();

		public extern void AddEventListener(LinkElementEvents type, Action listener);

		public extern void AddEventListener(LinkElementEvents type, Action listener, bool capture);

		public extern void AddEventListener(LinkElementEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(LinkElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(LinkElementEvents type, HtmlEventHandlerWithTarget<LinkElement> listener);

		public extern void AddEventListener(LinkElementEvents type, HtmlEventHandlerWithTarget<LinkElement> listener, bool capture);

		public extern void AddEventListener(LinkElementEvents type, IEventListener listener);

		public extern void AddEventListener(LinkElementEvents type, IEventListener listener, bool capture);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<LinkElement> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<LinkElement> listener, bool capture);

		public string Charset;

		public string CrossOrigin;

		public bool Disabled;

		public string Href;

		public string Hreflang;

		public string Media;

		public string Rel;

		public readonly TokenList RelList;

		public extern void RemoveEventListener(LinkElementEvents type, Action listener);

		public extern void RemoveEventListener(LinkElementEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(LinkElementEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(LinkElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(LinkElementEvents type, HtmlEventHandlerWithTarget<LinkElement> listener);

		public extern void RemoveEventListener(LinkElementEvents type, HtmlEventHandlerWithTarget<LinkElement> listener, bool capture);

		public extern void RemoveEventListener(LinkElementEvents type, IEventListener listener);

		public extern void RemoveEventListener(LinkElementEvents type, IEventListener listener, bool capture);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<LinkElement> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<LinkElement> listener, bool capture);

		public string Rev;

		public readonly StyleSheet Sheet;

		public string Target;

		public string Type;
	}
}
