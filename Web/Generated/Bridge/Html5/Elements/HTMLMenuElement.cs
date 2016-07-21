namespace Bridge.Html5.Elements
{
	[Namespace(false), External, Name("Element")]
	public partial class HTMLMenuElement : HTMLElement
	{
		internal extern HTMLMenuElement();

		public extern void AddEventListener(HTMLMenuElementEvents type, Action listener);

		public extern void AddEventListener(HTMLMenuElementEvents type, Action listener, bool capture);

		public extern void AddEventListener(HTMLMenuElementEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(HTMLMenuElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(HTMLMenuElementEvents type, HtmlEventHandlerWithTarget<HTMLMenuElement> listener);

		public extern void AddEventListener(HTMLMenuElementEvents type, HtmlEventHandlerWithTarget<HTMLMenuElement> listener, bool capture);

		public extern void AddEventListener(HTMLMenuElementEvents type, IEventListener listener);

		public extern void AddEventListener(HTMLMenuElementEvents type, IEventListener listener, bool capture);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<HTMLMenuElement> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<HTMLMenuElement> listener, bool capture);

		public bool Compact;

		public string Label;

		public extern void RemoveEventListener(HTMLMenuElementEvents type, Action listener);

		public extern void RemoveEventListener(HTMLMenuElementEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(HTMLMenuElementEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(HTMLMenuElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(HTMLMenuElementEvents type, HtmlEventHandlerWithTarget<HTMLMenuElement> listener);

		public extern void RemoveEventListener(HTMLMenuElementEvents type, HtmlEventHandlerWithTarget<HTMLMenuElement> listener, bool capture);

		public extern void RemoveEventListener(HTMLMenuElementEvents type, IEventListener listener);

		public extern void RemoveEventListener(HTMLMenuElementEvents type, IEventListener listener, bool capture);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<HTMLMenuElement> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<HTMLMenuElement> listener, bool capture);

		public string Type;
	}
}
