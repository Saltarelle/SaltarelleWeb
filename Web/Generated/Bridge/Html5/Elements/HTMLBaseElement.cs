namespace Bridge.Html5.Elements
{
	[Namespace(false), External, Name("Element")]
	public partial class HTMLBaseElement : HTMLElement
	{
		internal extern HTMLBaseElement();

		public extern void AddEventListener(HTMLBaseElementEvents type, Action listener);

		public extern void AddEventListener(HTMLBaseElementEvents type, Action listener, bool capture);

		public extern void AddEventListener(HTMLBaseElementEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(HTMLBaseElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(HTMLBaseElementEvents type, HtmlEventHandlerWithTarget<HTMLBaseElement> listener);

		public extern void AddEventListener(HTMLBaseElementEvents type, HtmlEventHandlerWithTarget<HTMLBaseElement> listener, bool capture);

		public extern void AddEventListener(HTMLBaseElementEvents type, IEventListener listener);

		public extern void AddEventListener(HTMLBaseElementEvents type, IEventListener listener, bool capture);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<HTMLBaseElement> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<HTMLBaseElement> listener, bool capture);

		public string Href;

		public extern void RemoveEventListener(HTMLBaseElementEvents type, Action listener);

		public extern void RemoveEventListener(HTMLBaseElementEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(HTMLBaseElementEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(HTMLBaseElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(HTMLBaseElementEvents type, HtmlEventHandlerWithTarget<HTMLBaseElement> listener);

		public extern void RemoveEventListener(HTMLBaseElementEvents type, HtmlEventHandlerWithTarget<HTMLBaseElement> listener, bool capture);

		public extern void RemoveEventListener(HTMLBaseElementEvents type, IEventListener listener);

		public extern void RemoveEventListener(HTMLBaseElementEvents type, IEventListener listener, bool capture);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<HTMLBaseElement> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<HTMLBaseElement> listener, bool capture);

		public string Target;
	}
}
