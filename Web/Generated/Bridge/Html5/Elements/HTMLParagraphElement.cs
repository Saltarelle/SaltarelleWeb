namespace Bridge.Html5.Elements
{
	[Namespace(false), External, Name("Element")]
	public partial class HTMLParagraphElement : HTMLElement
	{
		internal extern HTMLParagraphElement();

		public extern void AddEventListener(HTMLParagraphElementEvents type, Action listener);

		public extern void AddEventListener(HTMLParagraphElementEvents type, Action listener, bool capture);

		public extern void AddEventListener(HTMLParagraphElementEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(HTMLParagraphElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(HTMLParagraphElementEvents type, HtmlEventHandlerWithTarget<HTMLParagraphElement> listener);

		public extern void AddEventListener(HTMLParagraphElementEvents type, HtmlEventHandlerWithTarget<HTMLParagraphElement> listener, bool capture);

		public extern void AddEventListener(HTMLParagraphElementEvents type, IEventListener listener);

		public extern void AddEventListener(HTMLParagraphElementEvents type, IEventListener listener, bool capture);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<HTMLParagraphElement> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<HTMLParagraphElement> listener, bool capture);

		public string Align;

		public extern void RemoveEventListener(HTMLParagraphElementEvents type, Action listener);

		public extern void RemoveEventListener(HTMLParagraphElementEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(HTMLParagraphElementEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(HTMLParagraphElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(HTMLParagraphElementEvents type, HtmlEventHandlerWithTarget<HTMLParagraphElement> listener);

		public extern void RemoveEventListener(HTMLParagraphElementEvents type, HtmlEventHandlerWithTarget<HTMLParagraphElement> listener, bool capture);

		public extern void RemoveEventListener(HTMLParagraphElementEvents type, IEventListener listener);

		public extern void RemoveEventListener(HTMLParagraphElementEvents type, IEventListener listener, bool capture);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<HTMLParagraphElement> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<HTMLParagraphElement> listener, bool capture);
	}
}
