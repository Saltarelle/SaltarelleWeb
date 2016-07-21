namespace Bridge.Html5.Elements
{
	[Namespace(false), External, Name("Element")]
	public partial class HTMLScriptElement : HTMLElement
	{
		internal extern HTMLScriptElement();

		public extern void AddEventListener(HTMLScriptElementEvents type, Action listener);

		public extern void AddEventListener(HTMLScriptElementEvents type, Action listener, bool capture);

		public extern void AddEventListener(HTMLScriptElementEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(HTMLScriptElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(HTMLScriptElementEvents type, HtmlEventHandlerWithTarget<HTMLScriptElement> listener);

		public extern void AddEventListener(HTMLScriptElementEvents type, HtmlEventHandlerWithTarget<HTMLScriptElement> listener, bool capture);

		public extern void AddEventListener(HTMLScriptElementEvents type, IEventListener listener);

		public extern void AddEventListener(HTMLScriptElementEvents type, IEventListener listener, bool capture);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<HTMLScriptElement> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<HTMLScriptElement> listener, bool capture);

		public bool Async;

		public string Charset;

		public string CrossOrigin;

		public bool Defer;

		public string Event;

		public string HtmlFor;

		public extern void RemoveEventListener(HTMLScriptElementEvents type, Action listener);

		public extern void RemoveEventListener(HTMLScriptElementEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(HTMLScriptElementEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(HTMLScriptElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(HTMLScriptElementEvents type, HtmlEventHandlerWithTarget<HTMLScriptElement> listener);

		public extern void RemoveEventListener(HTMLScriptElementEvents type, HtmlEventHandlerWithTarget<HTMLScriptElement> listener, bool capture);

		public extern void RemoveEventListener(HTMLScriptElementEvents type, IEventListener listener);

		public extern void RemoveEventListener(HTMLScriptElementEvents type, IEventListener listener, bool capture);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<HTMLScriptElement> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<HTMLScriptElement> listener, bool capture);

		public string Src;

		public string Text;

		public string Type;
	}
}
