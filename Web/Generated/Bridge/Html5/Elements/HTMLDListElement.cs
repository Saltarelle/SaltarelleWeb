namespace Bridge.Html5.Elements
{
	[Namespace(false), External, Name("Element")]
	public partial class HTMLDListElement : HTMLElement
	{
		internal extern HTMLDListElement();

		public extern void AddEventListener(HTMLDListElementEvents type, Action listener);

		public extern void AddEventListener(HTMLDListElementEvents type, Action listener, bool capture);

		public extern void AddEventListener(HTMLDListElementEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(HTMLDListElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(HTMLDListElementEvents type, HtmlEventHandlerWithTarget<HTMLDListElement> listener);

		public extern void AddEventListener(HTMLDListElementEvents type, HtmlEventHandlerWithTarget<HTMLDListElement> listener, bool capture);

		public extern void AddEventListener(HTMLDListElementEvents type, IEventListener listener);

		public extern void AddEventListener(HTMLDListElementEvents type, IEventListener listener, bool capture);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<HTMLDListElement> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<HTMLDListElement> listener, bool capture);

		public bool Compact;

		public extern void RemoveEventListener(HTMLDListElementEvents type, Action listener);

		public extern void RemoveEventListener(HTMLDListElementEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(HTMLDListElementEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(HTMLDListElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(HTMLDListElementEvents type, HtmlEventHandlerWithTarget<HTMLDListElement> listener);

		public extern void RemoveEventListener(HTMLDListElementEvents type, HtmlEventHandlerWithTarget<HTMLDListElement> listener, bool capture);

		public extern void RemoveEventListener(HTMLDListElementEvents type, IEventListener listener);

		public extern void RemoveEventListener(HTMLDListElementEvents type, IEventListener listener, bool capture);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<HTMLDListElement> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<HTMLDListElement> listener, bool capture);
	}
}
