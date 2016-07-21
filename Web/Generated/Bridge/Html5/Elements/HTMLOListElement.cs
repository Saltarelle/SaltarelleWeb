namespace Bridge.Html5.Elements
{
	[Namespace(false), External, Name("Element")]
	public partial class HTMLOListElement : HTMLElement
	{
		internal extern HTMLOListElement();

		public extern void AddEventListener(HTMLOListElementEvents type, Action listener);

		public extern void AddEventListener(HTMLOListElementEvents type, Action listener, bool capture);

		public extern void AddEventListener(HTMLOListElementEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(HTMLOListElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(HTMLOListElementEvents type, HtmlEventHandlerWithTarget<HTMLOListElement> listener);

		public extern void AddEventListener(HTMLOListElementEvents type, HtmlEventHandlerWithTarget<HTMLOListElement> listener, bool capture);

		public extern void AddEventListener(HTMLOListElementEvents type, IEventListener listener);

		public extern void AddEventListener(HTMLOListElementEvents type, IEventListener listener, bool capture);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<HTMLOListElement> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<HTMLOListElement> listener, bool capture);

		public bool Compact;

		public extern void RemoveEventListener(HTMLOListElementEvents type, Action listener);

		public extern void RemoveEventListener(HTMLOListElementEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(HTMLOListElementEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(HTMLOListElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(HTMLOListElementEvents type, HtmlEventHandlerWithTarget<HTMLOListElement> listener);

		public extern void RemoveEventListener(HTMLOListElementEvents type, HtmlEventHandlerWithTarget<HTMLOListElement> listener, bool capture);

		public extern void RemoveEventListener(HTMLOListElementEvents type, IEventListener listener);

		public extern void RemoveEventListener(HTMLOListElementEvents type, IEventListener listener, bool capture);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<HTMLOListElement> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<HTMLOListElement> listener, bool capture);

		public bool Reversed;

		public int Start;

		public string Type;
	}
}
