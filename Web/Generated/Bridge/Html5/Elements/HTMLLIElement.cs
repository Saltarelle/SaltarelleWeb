namespace Bridge.Html5.Elements
{
	[Namespace(false), External, Name("Element")]
	public partial class HTMLLIElement : HTMLElement
	{
		internal extern HTMLLIElement();

		public extern void AddEventListener(HTMLLIElementEvents type, Action listener);

		public extern void AddEventListener(HTMLLIElementEvents type, Action listener, bool capture);

		public extern void AddEventListener(HTMLLIElementEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(HTMLLIElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(HTMLLIElementEvents type, HtmlEventHandlerWithTarget<HTMLLIElement> listener);

		public extern void AddEventListener(HTMLLIElementEvents type, HtmlEventHandlerWithTarget<HTMLLIElement> listener, bool capture);

		public extern void AddEventListener(HTMLLIElementEvents type, IEventListener listener);

		public extern void AddEventListener(HTMLLIElementEvents type, IEventListener listener, bool capture);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<HTMLLIElement> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<HTMLLIElement> listener, bool capture);

		public extern void RemoveEventListener(HTMLLIElementEvents type, Action listener);

		public extern void RemoveEventListener(HTMLLIElementEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(HTMLLIElementEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(HTMLLIElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(HTMLLIElementEvents type, HtmlEventHandlerWithTarget<HTMLLIElement> listener);

		public extern void RemoveEventListener(HTMLLIElementEvents type, HtmlEventHandlerWithTarget<HTMLLIElement> listener, bool capture);

		public extern void RemoveEventListener(HTMLLIElementEvents type, IEventListener listener);

		public extern void RemoveEventListener(HTMLLIElementEvents type, IEventListener listener, bool capture);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<HTMLLIElement> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<HTMLLIElement> listener, bool capture);

		public string Type;

		public int Value;
	}
}
