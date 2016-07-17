namespace Bridge.Html5
{
	[Namespace("false"), External(TypeCheckCode = "{$System.Script}.isInstanceOfType({this}, Element) && {this}.tagName === 'Q'"), Name("Element")]
	public partial class QuoteElement : Element
	{
		internal extern QuoteElement();

		public extern void AddEventListener(QuoteElementEvents type, Action listener);

		public extern void AddEventListener(QuoteElementEvents type, Action listener, bool capture);

		public extern void AddEventListener(QuoteElementEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(QuoteElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(QuoteElementEvents type, HtmlEventHandlerWithTarget<QuoteElement> listener);

		public extern void AddEventListener(QuoteElementEvents type, HtmlEventHandlerWithTarget<QuoteElement> listener, bool capture);

		public extern void AddEventListener(QuoteElementEvents type, IEventListener listener);

		public extern void AddEventListener(QuoteElementEvents type, IEventListener listener, bool capture);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<QuoteElement> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<QuoteElement> listener, bool capture);

		public string Cite;

		public extern void RemoveEventListener(QuoteElementEvents type, Action listener);

		public extern void RemoveEventListener(QuoteElementEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(QuoteElementEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(QuoteElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(QuoteElementEvents type, HtmlEventHandlerWithTarget<QuoteElement> listener);

		public extern void RemoveEventListener(QuoteElementEvents type, HtmlEventHandlerWithTarget<QuoteElement> listener, bool capture);

		public extern void RemoveEventListener(QuoteElementEvents type, IEventListener listener);

		public extern void RemoveEventListener(QuoteElementEvents type, IEventListener listener, bool capture);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<QuoteElement> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<QuoteElement> listener, bool capture);
	}
}
