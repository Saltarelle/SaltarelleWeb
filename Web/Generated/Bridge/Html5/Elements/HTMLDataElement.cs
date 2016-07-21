namespace Bridge.Html5.Elements
{
	[Namespace(false), External, Name("Element")]
	public partial class HTMLDataElement : HTMLElement
	{
		internal extern HTMLDataElement();

		public extern void AddEventListener(HTMLDataElementEvents type, Action listener);

		public extern void AddEventListener(HTMLDataElementEvents type, Action listener, bool capture);

		public extern void AddEventListener(HTMLDataElementEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(HTMLDataElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(HTMLDataElementEvents type, HtmlEventHandlerWithTarget<HTMLDataElement> listener);

		public extern void AddEventListener(HTMLDataElementEvents type, HtmlEventHandlerWithTarget<HTMLDataElement> listener, bool capture);

		public extern void AddEventListener(HTMLDataElementEvents type, IEventListener listener);

		public extern void AddEventListener(HTMLDataElementEvents type, IEventListener listener, bool capture);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<HTMLDataElement> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<HTMLDataElement> listener, bool capture);

		public extern void RemoveEventListener(HTMLDataElementEvents type, Action listener);

		public extern void RemoveEventListener(HTMLDataElementEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(HTMLDataElementEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(HTMLDataElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(HTMLDataElementEvents type, HtmlEventHandlerWithTarget<HTMLDataElement> listener);

		public extern void RemoveEventListener(HTMLDataElementEvents type, HtmlEventHandlerWithTarget<HTMLDataElement> listener, bool capture);

		public extern void RemoveEventListener(HTMLDataElementEvents type, IEventListener listener);

		public extern void RemoveEventListener(HTMLDataElementEvents type, IEventListener listener, bool capture);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<HTMLDataElement> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<HTMLDataElement> listener, bool capture);

		public string Value;
	}
}
