namespace Bridge.Html5.Elements
{
	[Namespace(false), External, Name("Element")]
	public partial class HTMLQuoteElement : HTMLElement
	{
		internal extern HTMLQuoteElement();

		public extern void AddEventListener(HTMLQuoteElementEvents type, Action listener);

		public extern void AddEventListener(HTMLQuoteElementEvents type, Action listener, bool capture);

		public extern void AddEventListener(HTMLQuoteElementEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(HTMLQuoteElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(HTMLQuoteElementEvents type, HtmlEventHandlerWithTarget<HTMLQuoteElement> listener);

		public extern void AddEventListener(HTMLQuoteElementEvents type, HtmlEventHandlerWithTarget<HTMLQuoteElement> listener, bool capture);

		public extern void AddEventListener(HTMLQuoteElementEvents type, IEventListener listener);

		public extern void AddEventListener(HTMLQuoteElementEvents type, IEventListener listener, bool capture);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<HTMLQuoteElement> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<HTMLQuoteElement> listener, bool capture);

		public string Cite;

		public extern void RemoveEventListener(HTMLQuoteElementEvents type, Action listener);

		public extern void RemoveEventListener(HTMLQuoteElementEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(HTMLQuoteElementEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(HTMLQuoteElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(HTMLQuoteElementEvents type, HtmlEventHandlerWithTarget<HTMLQuoteElement> listener);

		public extern void RemoveEventListener(HTMLQuoteElementEvents type, HtmlEventHandlerWithTarget<HTMLQuoteElement> listener, bool capture);

		public extern void RemoveEventListener(HTMLQuoteElementEvents type, IEventListener listener);

		public extern void RemoveEventListener(HTMLQuoteElementEvents type, IEventListener listener, bool capture);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<HTMLQuoteElement> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<HTMLQuoteElement> listener, bool capture);
	}
}
