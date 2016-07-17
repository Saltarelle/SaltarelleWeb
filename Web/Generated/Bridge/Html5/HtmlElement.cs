namespace Bridge.Html5
{
	[Namespace("false"), External(TypeCheckCode = "{$System.Script}.isInstanceOfType({this}, Element) && {this}.tagName === 'HTML'"), Name("Element")]
	public partial class HtmlElement : Element
	{
		internal extern HtmlElement();

		public extern void AddEventListener(HtmlElementEvents type, Action listener);

		public extern void AddEventListener(HtmlElementEvents type, Action listener, bool capture);

		public extern void AddEventListener(HtmlElementEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(HtmlElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(HtmlElementEvents type, HtmlEventHandlerWithTarget<HtmlElement> listener);

		public extern void AddEventListener(HtmlElementEvents type, HtmlEventHandlerWithTarget<HtmlElement> listener, bool capture);

		public extern void AddEventListener(HtmlElementEvents type, IEventListener listener);

		public extern void AddEventListener(HtmlElementEvents type, IEventListener listener, bool capture);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<HtmlElement> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<HtmlElement> listener, bool capture);

		public extern void RemoveEventListener(HtmlElementEvents type, Action listener);

		public extern void RemoveEventListener(HtmlElementEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(HtmlElementEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(HtmlElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(HtmlElementEvents type, HtmlEventHandlerWithTarget<HtmlElement> listener);

		public extern void RemoveEventListener(HtmlElementEvents type, HtmlEventHandlerWithTarget<HtmlElement> listener, bool capture);

		public extern void RemoveEventListener(HtmlElementEvents type, IEventListener listener);

		public extern void RemoveEventListener(HtmlElementEvents type, IEventListener listener, bool capture);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<HtmlElement> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<HtmlElement> listener, bool capture);

		public string Version;
	}
}
