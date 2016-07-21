namespace Bridge.Html5.Elements
{
	[Namespace(false), External, Name("Element")]
	public partial class HTMLTitleElement : HTMLElement
	{
		internal extern HTMLTitleElement();

		public extern void AddEventListener(HTMLTitleElementEvents type, Action listener);

		public extern void AddEventListener(HTMLTitleElementEvents type, Action listener, bool capture);

		public extern void AddEventListener(HTMLTitleElementEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(HTMLTitleElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(HTMLTitleElementEvents type, HtmlEventHandlerWithTarget<HTMLTitleElement> listener);

		public extern void AddEventListener(HTMLTitleElementEvents type, HtmlEventHandlerWithTarget<HTMLTitleElement> listener, bool capture);

		public extern void AddEventListener(HTMLTitleElementEvents type, IEventListener listener);

		public extern void AddEventListener(HTMLTitleElementEvents type, IEventListener listener, bool capture);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<HTMLTitleElement> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<HTMLTitleElement> listener, bool capture);

		public extern void RemoveEventListener(HTMLTitleElementEvents type, Action listener);

		public extern void RemoveEventListener(HTMLTitleElementEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(HTMLTitleElementEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(HTMLTitleElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(HTMLTitleElementEvents type, HtmlEventHandlerWithTarget<HTMLTitleElement> listener);

		public extern void RemoveEventListener(HTMLTitleElementEvents type, HtmlEventHandlerWithTarget<HTMLTitleElement> listener, bool capture);

		public extern void RemoveEventListener(HTMLTitleElementEvents type, IEventListener listener);

		public extern void RemoveEventListener(HTMLTitleElementEvents type, IEventListener listener, bool capture);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<HTMLTitleElement> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<HTMLTitleElement> listener, bool capture);

		public string Text;
	}
}
