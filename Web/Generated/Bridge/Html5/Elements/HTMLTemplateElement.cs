namespace Bridge.Html5.Elements
{
	[Namespace(false), External, Name("Element")]
	public partial class HTMLTemplateElement : HTMLElement
	{
		internal extern HTMLTemplateElement();

		public extern void AddEventListener(HTMLTemplateElementEvents type, Action listener);

		public extern void AddEventListener(HTMLTemplateElementEvents type, Action listener, bool capture);

		public extern void AddEventListener(HTMLTemplateElementEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(HTMLTemplateElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(HTMLTemplateElementEvents type, HtmlEventHandlerWithTarget<HTMLTemplateElement> listener);

		public extern void AddEventListener(HTMLTemplateElementEvents type, HtmlEventHandlerWithTarget<HTMLTemplateElement> listener, bool capture);

		public extern void AddEventListener(HTMLTemplateElementEvents type, IEventListener listener);

		public extern void AddEventListener(HTMLTemplateElementEvents type, IEventListener listener, bool capture);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<HTMLTemplateElement> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<HTMLTemplateElement> listener, bool capture);

		public readonly DocumentFragment Content;

		public extern void RemoveEventListener(HTMLTemplateElementEvents type, Action listener);

		public extern void RemoveEventListener(HTMLTemplateElementEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(HTMLTemplateElementEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(HTMLTemplateElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(HTMLTemplateElementEvents type, HtmlEventHandlerWithTarget<HTMLTemplateElement> listener);

		public extern void RemoveEventListener(HTMLTemplateElementEvents type, HtmlEventHandlerWithTarget<HTMLTemplateElement> listener, bool capture);

		public extern void RemoveEventListener(HTMLTemplateElementEvents type, IEventListener listener);

		public extern void RemoveEventListener(HTMLTemplateElementEvents type, IEventListener listener, bool capture);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<HTMLTemplateElement> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<HTMLTemplateElement> listener, bool capture);
	}
}
