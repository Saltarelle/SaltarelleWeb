namespace Bridge.Html5.Elements
{
	[Namespace(false), External]
	public partial class HTMLUnknownElement : HTMLElement
	{
		internal extern HTMLUnknownElement();

		public extern void AddEventListener(HTMLUnknownElementEvents type, Action listener);

		public extern void AddEventListener(HTMLUnknownElementEvents type, Action listener, bool capture);

		public extern void AddEventListener(HTMLUnknownElementEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(HTMLUnknownElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(HTMLUnknownElementEvents type, HtmlEventHandlerWithTarget<HTMLUnknownElement> listener);

		public extern void AddEventListener(HTMLUnknownElementEvents type, HtmlEventHandlerWithTarget<HTMLUnknownElement> listener, bool capture);

		public extern void AddEventListener(HTMLUnknownElementEvents type, IEventListener listener);

		public extern void AddEventListener(HTMLUnknownElementEvents type, IEventListener listener, bool capture);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<HTMLUnknownElement> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<HTMLUnknownElement> listener, bool capture);

		public extern void RemoveEventListener(HTMLUnknownElementEvents type, Action listener);

		public extern void RemoveEventListener(HTMLUnknownElementEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(HTMLUnknownElementEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(HTMLUnknownElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(HTMLUnknownElementEvents type, HtmlEventHandlerWithTarget<HTMLUnknownElement> listener);

		public extern void RemoveEventListener(HTMLUnknownElementEvents type, HtmlEventHandlerWithTarget<HTMLUnknownElement> listener, bool capture);

		public extern void RemoveEventListener(HTMLUnknownElementEvents type, IEventListener listener);

		public extern void RemoveEventListener(HTMLUnknownElementEvents type, IEventListener listener, bool capture);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<HTMLUnknownElement> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<HTMLUnknownElement> listener, bool capture);
	}
}
