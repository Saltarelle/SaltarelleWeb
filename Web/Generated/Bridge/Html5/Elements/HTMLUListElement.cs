namespace Bridge.Html5.Elements
{
	[Namespace(false), External, Name("Element")]
	public partial class HTMLUListElement : HTMLElement
	{
		internal extern HTMLUListElement();

		public extern void AddEventListener(HTMLUListElementEvents type, Action listener);

		public extern void AddEventListener(HTMLUListElementEvents type, Action listener, bool capture);

		public extern void AddEventListener(HTMLUListElementEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(HTMLUListElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(HTMLUListElementEvents type, HtmlEventHandlerWithTarget<HTMLUListElement> listener);

		public extern void AddEventListener(HTMLUListElementEvents type, HtmlEventHandlerWithTarget<HTMLUListElement> listener, bool capture);

		public extern void AddEventListener(HTMLUListElementEvents type, IEventListener listener);

		public extern void AddEventListener(HTMLUListElementEvents type, IEventListener listener, bool capture);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<HTMLUListElement> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<HTMLUListElement> listener, bool capture);

		public bool Compact;

		public extern void RemoveEventListener(HTMLUListElementEvents type, Action listener);

		public extern void RemoveEventListener(HTMLUListElementEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(HTMLUListElementEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(HTMLUListElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(HTMLUListElementEvents type, HtmlEventHandlerWithTarget<HTMLUListElement> listener);

		public extern void RemoveEventListener(HTMLUListElementEvents type, HtmlEventHandlerWithTarget<HTMLUListElement> listener, bool capture);

		public extern void RemoveEventListener(HTMLUListElementEvents type, IEventListener listener);

		public extern void RemoveEventListener(HTMLUListElementEvents type, IEventListener listener, bool capture);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<HTMLUListElement> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<HTMLUListElement> listener, bool capture);

		public string Type;
	}
}
