namespace Bridge.Html5.Elements
{
	[Namespace(false), External, Name("Element")]
	public partial class HTMLTableCaptionElement : HTMLElement
	{
		internal extern HTMLTableCaptionElement();

		public extern void AddEventListener(HTMLTableCaptionElementEvents type, Action listener);

		public extern void AddEventListener(HTMLTableCaptionElementEvents type, Action listener, bool capture);

		public extern void AddEventListener(HTMLTableCaptionElementEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(HTMLTableCaptionElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(HTMLTableCaptionElementEvents type, HtmlEventHandlerWithTarget<HTMLTableCaptionElement> listener);

		public extern void AddEventListener(HTMLTableCaptionElementEvents type, HtmlEventHandlerWithTarget<HTMLTableCaptionElement> listener, bool capture);

		public extern void AddEventListener(HTMLTableCaptionElementEvents type, IEventListener listener);

		public extern void AddEventListener(HTMLTableCaptionElementEvents type, IEventListener listener, bool capture);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<HTMLTableCaptionElement> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<HTMLTableCaptionElement> listener, bool capture);

		public string Align;

		public extern void RemoveEventListener(HTMLTableCaptionElementEvents type, Action listener);

		public extern void RemoveEventListener(HTMLTableCaptionElementEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(HTMLTableCaptionElementEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(HTMLTableCaptionElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(HTMLTableCaptionElementEvents type, HtmlEventHandlerWithTarget<HTMLTableCaptionElement> listener);

		public extern void RemoveEventListener(HTMLTableCaptionElementEvents type, HtmlEventHandlerWithTarget<HTMLTableCaptionElement> listener, bool capture);

		public extern void RemoveEventListener(HTMLTableCaptionElementEvents type, IEventListener listener);

		public extern void RemoveEventListener(HTMLTableCaptionElementEvents type, IEventListener listener, bool capture);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<HTMLTableCaptionElement> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<HTMLTableCaptionElement> listener, bool capture);
	}
}
