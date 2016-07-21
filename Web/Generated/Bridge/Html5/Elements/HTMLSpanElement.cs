namespace Bridge.Html5.Elements
{
	[Namespace(false), External, Name("Element")]
	public partial class HTMLSpanElement : HTMLElement
	{
		internal extern HTMLSpanElement();

		public extern void AddEventListener(HTMLSpanElementEvents type, Action listener);

		public extern void AddEventListener(HTMLSpanElementEvents type, Action listener, bool capture);

		public extern void AddEventListener(HTMLSpanElementEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(HTMLSpanElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(HTMLSpanElementEvents type, HtmlEventHandlerWithTarget<HTMLSpanElement> listener);

		public extern void AddEventListener(HTMLSpanElementEvents type, HtmlEventHandlerWithTarget<HTMLSpanElement> listener, bool capture);

		public extern void AddEventListener(HTMLSpanElementEvents type, IEventListener listener);

		public extern void AddEventListener(HTMLSpanElementEvents type, IEventListener listener, bool capture);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<HTMLSpanElement> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<HTMLSpanElement> listener, bool capture);

		public extern void RemoveEventListener(HTMLSpanElementEvents type, Action listener);

		public extern void RemoveEventListener(HTMLSpanElementEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(HTMLSpanElementEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(HTMLSpanElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(HTMLSpanElementEvents type, HtmlEventHandlerWithTarget<HTMLSpanElement> listener);

		public extern void RemoveEventListener(HTMLSpanElementEvents type, HtmlEventHandlerWithTarget<HTMLSpanElement> listener, bool capture);

		public extern void RemoveEventListener(HTMLSpanElementEvents type, IEventListener listener);

		public extern void RemoveEventListener(HTMLSpanElementEvents type, IEventListener listener, bool capture);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<HTMLSpanElement> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<HTMLSpanElement> listener, bool capture);
	}
}
