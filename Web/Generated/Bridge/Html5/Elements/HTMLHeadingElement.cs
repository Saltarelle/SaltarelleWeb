namespace Bridge.Html5.Elements
{
	[Namespace(false), External, Name("Element")]
	public partial class HTMLHeadingElement : HTMLElement
	{
		internal extern HTMLHeadingElement();

		public extern void AddEventListener(HTMLHeadingElementEvents type, Action listener);

		public extern void AddEventListener(HTMLHeadingElementEvents type, Action listener, bool capture);

		public extern void AddEventListener(HTMLHeadingElementEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(HTMLHeadingElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(HTMLHeadingElementEvents type, HtmlEventHandlerWithTarget<HTMLHeadingElement> listener);

		public extern void AddEventListener(HTMLHeadingElementEvents type, HtmlEventHandlerWithTarget<HTMLHeadingElement> listener, bool capture);

		public extern void AddEventListener(HTMLHeadingElementEvents type, IEventListener listener);

		public extern void AddEventListener(HTMLHeadingElementEvents type, IEventListener listener, bool capture);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<HTMLHeadingElement> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<HTMLHeadingElement> listener, bool capture);

		public string Align;

		public extern void RemoveEventListener(HTMLHeadingElementEvents type, Action listener);

		public extern void RemoveEventListener(HTMLHeadingElementEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(HTMLHeadingElementEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(HTMLHeadingElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(HTMLHeadingElementEvents type, HtmlEventHandlerWithTarget<HTMLHeadingElement> listener);

		public extern void RemoveEventListener(HTMLHeadingElementEvents type, HtmlEventHandlerWithTarget<HTMLHeadingElement> listener, bool capture);

		public extern void RemoveEventListener(HTMLHeadingElementEvents type, IEventListener listener);

		public extern void RemoveEventListener(HTMLHeadingElementEvents type, IEventListener listener, bool capture);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<HTMLHeadingElement> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<HTMLHeadingElement> listener, bool capture);
	}
}
