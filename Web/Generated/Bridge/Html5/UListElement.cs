namespace Bridge.Html5
{
	[Namespace("false"), External(TypeCheckCode = "{$System.Script}.isInstanceOfType({this}, Element) && {this}.tagName === 'UL'"), Name("Element")]
	public partial class UListElement : Element
	{
		internal extern UListElement();

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<UListElement> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<UListElement> listener, bool capture);

		public extern void AddEventListener(UListElementEvents type, Action listener);

		public extern void AddEventListener(UListElementEvents type, Action listener, bool capture);

		public extern void AddEventListener(UListElementEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(UListElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(UListElementEvents type, HtmlEventHandlerWithTarget<UListElement> listener);

		public extern void AddEventListener(UListElementEvents type, HtmlEventHandlerWithTarget<UListElement> listener, bool capture);

		public extern void AddEventListener(UListElementEvents type, IEventListener listener);

		public extern void AddEventListener(UListElementEvents type, IEventListener listener, bool capture);

		public bool Compact;

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<UListElement> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<UListElement> listener, bool capture);

		public extern void RemoveEventListener(UListElementEvents type, Action listener);

		public extern void RemoveEventListener(UListElementEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(UListElementEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(UListElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(UListElementEvents type, HtmlEventHandlerWithTarget<UListElement> listener);

		public extern void RemoveEventListener(UListElementEvents type, HtmlEventHandlerWithTarget<UListElement> listener, bool capture);

		public extern void RemoveEventListener(UListElementEvents type, IEventListener listener);

		public extern void RemoveEventListener(UListElementEvents type, IEventListener listener, bool capture);

		public string Type;
	}
}
