namespace Bridge.Html5.Elements
{
	[Namespace(false), External, Name("Element")]
	public partial class HTMLHeadElement : HTMLElement
	{
		internal extern HTMLHeadElement();

		public extern void AddEventListener(HTMLHeadElementEvents type, Action listener);

		public extern void AddEventListener(HTMLHeadElementEvents type, Action listener, bool capture);

		public extern void AddEventListener(HTMLHeadElementEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(HTMLHeadElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(HTMLHeadElementEvents type, HtmlEventHandlerWithTarget<HTMLHeadElement> listener);

		public extern void AddEventListener(HTMLHeadElementEvents type, HtmlEventHandlerWithTarget<HTMLHeadElement> listener, bool capture);

		public extern void AddEventListener(HTMLHeadElementEvents type, IEventListener listener);

		public extern void AddEventListener(HTMLHeadElementEvents type, IEventListener listener, bool capture);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<HTMLHeadElement> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<HTMLHeadElement> listener, bool capture);

		public extern void RemoveEventListener(HTMLHeadElementEvents type, Action listener);

		public extern void RemoveEventListener(HTMLHeadElementEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(HTMLHeadElementEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(HTMLHeadElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(HTMLHeadElementEvents type, HtmlEventHandlerWithTarget<HTMLHeadElement> listener);

		public extern void RemoveEventListener(HTMLHeadElementEvents type, HtmlEventHandlerWithTarget<HTMLHeadElement> listener, bool capture);

		public extern void RemoveEventListener(HTMLHeadElementEvents type, IEventListener listener);

		public extern void RemoveEventListener(HTMLHeadElementEvents type, IEventListener listener, bool capture);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<HTMLHeadElement> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<HTMLHeadElement> listener, bool capture);
	}
}
