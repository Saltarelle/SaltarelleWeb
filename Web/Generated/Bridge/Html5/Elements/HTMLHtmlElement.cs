namespace Bridge.Html5.Elements
{
	[Namespace(false), External, Name("Element")]
	public partial class HTMLHtmlElement : HTMLElement
	{
		internal extern HTMLHtmlElement();

		public extern void AddEventListener(HTMLHtmlElementEvents type, Action listener);

		public extern void AddEventListener(HTMLHtmlElementEvents type, Action listener, bool capture);

		public extern void AddEventListener(HTMLHtmlElementEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(HTMLHtmlElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(HTMLHtmlElementEvents type, HtmlEventHandlerWithTarget<HTMLHtmlElement> listener);

		public extern void AddEventListener(HTMLHtmlElementEvents type, HtmlEventHandlerWithTarget<HTMLHtmlElement> listener, bool capture);

		public extern void AddEventListener(HTMLHtmlElementEvents type, IEventListener listener);

		public extern void AddEventListener(HTMLHtmlElementEvents type, IEventListener listener, bool capture);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<HTMLHtmlElement> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<HTMLHtmlElement> listener, bool capture);

		public extern void RemoveEventListener(HTMLHtmlElementEvents type, Action listener);

		public extern void RemoveEventListener(HTMLHtmlElementEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(HTMLHtmlElementEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(HTMLHtmlElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(HTMLHtmlElementEvents type, HtmlEventHandlerWithTarget<HTMLHtmlElement> listener);

		public extern void RemoveEventListener(HTMLHtmlElementEvents type, HtmlEventHandlerWithTarget<HTMLHtmlElement> listener, bool capture);

		public extern void RemoveEventListener(HTMLHtmlElementEvents type, IEventListener listener);

		public extern void RemoveEventListener(HTMLHtmlElementEvents type, IEventListener listener, bool capture);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<HTMLHtmlElement> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<HTMLHtmlElement> listener, bool capture);

		public string Version;
	}
}
