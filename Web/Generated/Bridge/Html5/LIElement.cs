namespace Bridge.Html5
{
	[Namespace("false"), External, Name("Element")]
	public partial class LIElement : Element
	{
		internal extern LIElement();

		public extern void AddEventListener(LIElementEvents type, Action listener);

		public extern void AddEventListener(LIElementEvents type, Action listener, bool capture);

		public extern void AddEventListener(LIElementEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(LIElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(LIElementEvents type, HtmlEventHandlerWithTarget<LIElement> listener);

		public extern void AddEventListener(LIElementEvents type, HtmlEventHandlerWithTarget<LIElement> listener, bool capture);

		public extern void AddEventListener(LIElementEvents type, IEventListener listener);

		public extern void AddEventListener(LIElementEvents type, IEventListener listener, bool capture);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<LIElement> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<LIElement> listener, bool capture);

		public extern void RemoveEventListener(LIElementEvents type, Action listener);

		public extern void RemoveEventListener(LIElementEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(LIElementEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(LIElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(LIElementEvents type, HtmlEventHandlerWithTarget<LIElement> listener);

		public extern void RemoveEventListener(LIElementEvents type, HtmlEventHandlerWithTarget<LIElement> listener, bool capture);

		public extern void RemoveEventListener(LIElementEvents type, IEventListener listener);

		public extern void RemoveEventListener(LIElementEvents type, IEventListener listener, bool capture);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<LIElement> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<LIElement> listener, bool capture);

		public string Type;

		public int Value;
	}
}
