namespace Bridge.Html5.Elements
{
	[Namespace(false), External, Name("Element")]
	public partial class HTMLBRElement : HTMLElement
	{
		internal extern HTMLBRElement();

		public extern void AddEventListener(HTMLBRElementEvents type, Action listener);

		public extern void AddEventListener(HTMLBRElementEvents type, Action listener, bool capture);

		public extern void AddEventListener(HTMLBRElementEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(HTMLBRElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(HTMLBRElementEvents type, HtmlEventHandlerWithTarget<HTMLBRElement> listener);

		public extern void AddEventListener(HTMLBRElementEvents type, HtmlEventHandlerWithTarget<HTMLBRElement> listener, bool capture);

		public extern void AddEventListener(HTMLBRElementEvents type, IEventListener listener);

		public extern void AddEventListener(HTMLBRElementEvents type, IEventListener listener, bool capture);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<HTMLBRElement> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<HTMLBRElement> listener, bool capture);

		public string Clear;

		public extern void RemoveEventListener(HTMLBRElementEvents type, Action listener);

		public extern void RemoveEventListener(HTMLBRElementEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(HTMLBRElementEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(HTMLBRElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(HTMLBRElementEvents type, HtmlEventHandlerWithTarget<HTMLBRElement> listener);

		public extern void RemoveEventListener(HTMLBRElementEvents type, HtmlEventHandlerWithTarget<HTMLBRElement> listener, bool capture);

		public extern void RemoveEventListener(HTMLBRElementEvents type, IEventListener listener);

		public extern void RemoveEventListener(HTMLBRElementEvents type, IEventListener listener, bool capture);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<HTMLBRElement> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<HTMLBRElement> listener, bool capture);
	}
}
