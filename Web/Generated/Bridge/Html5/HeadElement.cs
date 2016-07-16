namespace Bridge.Html5
{
	[Namespace("false"), External(TypeCheckCode = "{$System.Script}.isInstanceOfType({this}, Element) && {this}.tagName === 'HEAD'"), Name("Element")]
	public partial class HeadElement : Element
	{
		internal extern HeadElement();

		public extern void AddEventListener(HeadElementEvents type, Action listener);

		public extern void AddEventListener(HeadElementEvents type, Action listener, bool capture);

		public extern void AddEventListener(HeadElementEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(HeadElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(HeadElementEvents type, HtmlEventHandlerWithTarget<HeadElement> listener);

		public extern void AddEventListener(HeadElementEvents type, HtmlEventHandlerWithTarget<HeadElement> listener, bool capture);

		public extern void AddEventListener(HeadElementEvents type, IEventListener listener);

		public extern void AddEventListener(HeadElementEvents type, IEventListener listener, bool capture);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<HeadElement> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<HeadElement> listener, bool capture);

		public extern void RemoveEventListener(HeadElementEvents type, Action listener);

		public extern void RemoveEventListener(HeadElementEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(HeadElementEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(HeadElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(HeadElementEvents type, HtmlEventHandlerWithTarget<HeadElement> listener);

		public extern void RemoveEventListener(HeadElementEvents type, HtmlEventHandlerWithTarget<HeadElement> listener, bool capture);

		public extern void RemoveEventListener(HeadElementEvents type, IEventListener listener);

		public extern void RemoveEventListener(HeadElementEvents type, IEventListener listener, bool capture);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<HeadElement> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<HeadElement> listener, bool capture);
	}
}
