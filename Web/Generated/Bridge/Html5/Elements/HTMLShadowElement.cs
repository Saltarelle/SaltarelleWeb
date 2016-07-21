namespace Bridge.Html5.Elements
{
	[Namespace(false), External]
	public partial class HTMLShadowElement : HTMLElement
	{
		internal extern HTMLShadowElement();

		public extern void AddEventListener(HTMLShadowElementEvents type, Action listener);

		public extern void AddEventListener(HTMLShadowElementEvents type, Action listener, bool capture);

		public extern void AddEventListener(HTMLShadowElementEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(HTMLShadowElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(HTMLShadowElementEvents type, HtmlEventHandlerWithTarget<HTMLShadowElement> listener);

		public extern void AddEventListener(HTMLShadowElementEvents type, HtmlEventHandlerWithTarget<HTMLShadowElement> listener, bool capture);

		public extern void AddEventListener(HTMLShadowElementEvents type, IEventListener listener);

		public extern void AddEventListener(HTMLShadowElementEvents type, IEventListener listener, bool capture);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<HTMLShadowElement> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<HTMLShadowElement> listener, bool capture);

		public readonly ShadowRoot OlderShadowRoot;

		public extern void RemoveEventListener(HTMLShadowElementEvents type, Action listener);

		public extern void RemoveEventListener(HTMLShadowElementEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(HTMLShadowElementEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(HTMLShadowElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(HTMLShadowElementEvents type, HtmlEventHandlerWithTarget<HTMLShadowElement> listener);

		public extern void RemoveEventListener(HTMLShadowElementEvents type, HtmlEventHandlerWithTarget<HTMLShadowElement> listener, bool capture);

		public extern void RemoveEventListener(HTMLShadowElementEvents type, IEventListener listener);

		public extern void RemoveEventListener(HTMLShadowElementEvents type, IEventListener listener, bool capture);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<HTMLShadowElement> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<HTMLShadowElement> listener, bool capture);
	}
}
