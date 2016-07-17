namespace Bridge.Html5
{
	[Namespace("false"), External(TypeCheckCode = "{$System.Script}.isInstanceOfType({this}, Element) && {this}.tagName === 'TIME'"), Name("Element")]
	public partial class TimeElement : Element
	{
		internal extern TimeElement();

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<TimeElement> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<TimeElement> listener, bool capture);

		public extern void AddEventListener(TimeElementEvents type, Action listener);

		public extern void AddEventListener(TimeElementEvents type, Action listener, bool capture);

		public extern void AddEventListener(TimeElementEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(TimeElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(TimeElementEvents type, HtmlEventHandlerWithTarget<TimeElement> listener);

		public extern void AddEventListener(TimeElementEvents type, HtmlEventHandlerWithTarget<TimeElement> listener, bool capture);

		public extern void AddEventListener(TimeElementEvents type, IEventListener listener);

		public extern void AddEventListener(TimeElementEvents type, IEventListener listener, bool capture);

		public string DateTime;

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<TimeElement> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<TimeElement> listener, bool capture);

		public extern void RemoveEventListener(TimeElementEvents type, Action listener);

		public extern void RemoveEventListener(TimeElementEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(TimeElementEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(TimeElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(TimeElementEvents type, HtmlEventHandlerWithTarget<TimeElement> listener);

		public extern void RemoveEventListener(TimeElementEvents type, HtmlEventHandlerWithTarget<TimeElement> listener, bool capture);

		public extern void RemoveEventListener(TimeElementEvents type, IEventListener listener);

		public extern void RemoveEventListener(TimeElementEvents type, IEventListener listener, bool capture);
	}
}
