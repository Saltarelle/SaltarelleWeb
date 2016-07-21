namespace Bridge.Html5.Elements
{
	[Namespace(false), External, Name("Element")]
	public partial class HTMLModElement : HTMLElement
	{
		internal extern HTMLModElement();

		public extern void AddEventListener(HTMLModElementEvents type, Action listener);

		public extern void AddEventListener(HTMLModElementEvents type, Action listener, bool capture);

		public extern void AddEventListener(HTMLModElementEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(HTMLModElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(HTMLModElementEvents type, HtmlEventHandlerWithTarget<HTMLModElement> listener);

		public extern void AddEventListener(HTMLModElementEvents type, HtmlEventHandlerWithTarget<HTMLModElement> listener, bool capture);

		public extern void AddEventListener(HTMLModElementEvents type, IEventListener listener);

		public extern void AddEventListener(HTMLModElementEvents type, IEventListener listener, bool capture);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<HTMLModElement> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<HTMLModElement> listener, bool capture);

		public string Cite;

		public string DateTime;

		public extern void RemoveEventListener(HTMLModElementEvents type, Action listener);

		public extern void RemoveEventListener(HTMLModElementEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(HTMLModElementEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(HTMLModElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(HTMLModElementEvents type, HtmlEventHandlerWithTarget<HTMLModElement> listener);

		public extern void RemoveEventListener(HTMLModElementEvents type, HtmlEventHandlerWithTarget<HTMLModElement> listener, bool capture);

		public extern void RemoveEventListener(HTMLModElementEvents type, IEventListener listener);

		public extern void RemoveEventListener(HTMLModElementEvents type, IEventListener listener, bool capture);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<HTMLModElement> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<HTMLModElement> listener, bool capture);
	}
}
