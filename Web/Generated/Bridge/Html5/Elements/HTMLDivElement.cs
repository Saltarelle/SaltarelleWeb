namespace Bridge.Html5.Elements
{
	[Namespace(false), External, Name("Element")]
	public partial class HTMLDivElement : HTMLElement
	{
		internal extern HTMLDivElement();

		public extern void AddEventListener(HTMLDivElementEvents type, Action listener);

		public extern void AddEventListener(HTMLDivElementEvents type, Action listener, bool capture);

		public extern void AddEventListener(HTMLDivElementEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(HTMLDivElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(HTMLDivElementEvents type, HtmlEventHandlerWithTarget<HTMLDivElement> listener);

		public extern void AddEventListener(HTMLDivElementEvents type, HtmlEventHandlerWithTarget<HTMLDivElement> listener, bool capture);

		public extern void AddEventListener(HTMLDivElementEvents type, IEventListener listener);

		public extern void AddEventListener(HTMLDivElementEvents type, IEventListener listener, bool capture);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<HTMLDivElement> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<HTMLDivElement> listener, bool capture);

		public string Align;

		public extern void RemoveEventListener(HTMLDivElementEvents type, Action listener);

		public extern void RemoveEventListener(HTMLDivElementEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(HTMLDivElementEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(HTMLDivElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(HTMLDivElementEvents type, HtmlEventHandlerWithTarget<HTMLDivElement> listener);

		public extern void RemoveEventListener(HTMLDivElementEvents type, HtmlEventHandlerWithTarget<HTMLDivElement> listener, bool capture);

		public extern void RemoveEventListener(HTMLDivElementEvents type, IEventListener listener);

		public extern void RemoveEventListener(HTMLDivElementEvents type, IEventListener listener, bool capture);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<HTMLDivElement> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<HTMLDivElement> listener, bool capture);
	}
}
