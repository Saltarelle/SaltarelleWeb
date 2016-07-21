namespace Bridge.Html5.Elements
{
	[Namespace(false), External, Name("Element")]
	public partial class HTMLDirectoryElement : HTMLElement
	{
		internal extern HTMLDirectoryElement();

		public extern void AddEventListener(HTMLDirectoryElementEvents type, Action listener);

		public extern void AddEventListener(HTMLDirectoryElementEvents type, Action listener, bool capture);

		public extern void AddEventListener(HTMLDirectoryElementEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(HTMLDirectoryElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(HTMLDirectoryElementEvents type, HtmlEventHandlerWithTarget<HTMLDirectoryElement> listener);

		public extern void AddEventListener(HTMLDirectoryElementEvents type, HtmlEventHandlerWithTarget<HTMLDirectoryElement> listener, bool capture);

		public extern void AddEventListener(HTMLDirectoryElementEvents type, IEventListener listener);

		public extern void AddEventListener(HTMLDirectoryElementEvents type, IEventListener listener, bool capture);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<HTMLDirectoryElement> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<HTMLDirectoryElement> listener, bool capture);

		public bool Compact;

		public extern void RemoveEventListener(HTMLDirectoryElementEvents type, Action listener);

		public extern void RemoveEventListener(HTMLDirectoryElementEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(HTMLDirectoryElementEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(HTMLDirectoryElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(HTMLDirectoryElementEvents type, HtmlEventHandlerWithTarget<HTMLDirectoryElement> listener);

		public extern void RemoveEventListener(HTMLDirectoryElementEvents type, HtmlEventHandlerWithTarget<HTMLDirectoryElement> listener, bool capture);

		public extern void RemoveEventListener(HTMLDirectoryElementEvents type, IEventListener listener);

		public extern void RemoveEventListener(HTMLDirectoryElementEvents type, IEventListener listener, bool capture);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<HTMLDirectoryElement> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<HTMLDirectoryElement> listener, bool capture);
	}
}
