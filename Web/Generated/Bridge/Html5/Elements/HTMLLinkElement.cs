using Bridge.Html5.CSS;

namespace Bridge.Html5.Elements
{
	[Namespace(false), External, Name("Element")]
	public partial class HTMLLinkElement : HTMLElement
	{
		internal extern HTMLLinkElement();

		public extern void AddEventListener(HTMLLinkElementEvents type, Action listener);

		public extern void AddEventListener(HTMLLinkElementEvents type, Action listener, bool capture);

		public extern void AddEventListener(HTMLLinkElementEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(HTMLLinkElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(HTMLLinkElementEvents type, HtmlEventHandlerWithTarget<HTMLLinkElement> listener);

		public extern void AddEventListener(HTMLLinkElementEvents type, HtmlEventHandlerWithTarget<HTMLLinkElement> listener, bool capture);

		public extern void AddEventListener(HTMLLinkElementEvents type, IEventListener listener);

		public extern void AddEventListener(HTMLLinkElementEvents type, IEventListener listener, bool capture);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<HTMLLinkElement> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<HTMLLinkElement> listener, bool capture);

		public string Charset;

		public string CrossOrigin;

		public bool Disabled;

		public string Href;

		public string Hreflang;

		public string Media;

		public string Rel;

		public readonly TokenList RelList;

		public extern void RemoveEventListener(HTMLLinkElementEvents type, Action listener);

		public extern void RemoveEventListener(HTMLLinkElementEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(HTMLLinkElementEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(HTMLLinkElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(HTMLLinkElementEvents type, HtmlEventHandlerWithTarget<HTMLLinkElement> listener);

		public extern void RemoveEventListener(HTMLLinkElementEvents type, HtmlEventHandlerWithTarget<HTMLLinkElement> listener, bool capture);

		public extern void RemoveEventListener(HTMLLinkElementEvents type, IEventListener listener);

		public extern void RemoveEventListener(HTMLLinkElementEvents type, IEventListener listener, bool capture);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<HTMLLinkElement> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<HTMLLinkElement> listener, bool capture);

		public string Rev;

		public readonly StyleSheet Sheet;

		public string Target;

		public string Type;
	}
}
