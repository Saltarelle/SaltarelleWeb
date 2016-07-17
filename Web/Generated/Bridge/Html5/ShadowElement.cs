namespace Bridge.Html5
{
	[Namespace("false"), External, Name("HTMLShadowElement")]
	public partial class ShadowElement : Element
	{
		internal extern ShadowElement();

		public extern void AddEventListener(ShadowElementEvents type, Action listener);

		public extern void AddEventListener(ShadowElementEvents type, Action listener, bool capture);

		public extern void AddEventListener(ShadowElementEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(ShadowElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(ShadowElementEvents type, HtmlEventHandlerWithTarget<ShadowElement> listener);

		public extern void AddEventListener(ShadowElementEvents type, HtmlEventHandlerWithTarget<ShadowElement> listener, bool capture);

		public extern void AddEventListener(ShadowElementEvents type, IEventListener listener);

		public extern void AddEventListener(ShadowElementEvents type, IEventListener listener, bool capture);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<ShadowElement> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<ShadowElement> listener, bool capture);

		public readonly ShadowRoot OlderShadowRoot;

		public extern void RemoveEventListener(ShadowElementEvents type, Action listener);

		public extern void RemoveEventListener(ShadowElementEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(ShadowElementEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(ShadowElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(ShadowElementEvents type, HtmlEventHandlerWithTarget<ShadowElement> listener);

		public extern void RemoveEventListener(ShadowElementEvents type, HtmlEventHandlerWithTarget<ShadowElement> listener, bool capture);

		public extern void RemoveEventListener(ShadowElementEvents type, IEventListener listener);

		public extern void RemoveEventListener(ShadowElementEvents type, IEventListener listener, bool capture);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<ShadowElement> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<ShadowElement> listener, bool capture);
	}
}
