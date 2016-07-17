namespace Bridge.Html5
{
	[Namespace("false"), External, Name("Element")]
	public partial class OListElement : Element
	{
		internal extern OListElement();

		public extern void AddEventListener(OListElementEvents type, Action listener);

		public extern void AddEventListener(OListElementEvents type, Action listener, bool capture);

		public extern void AddEventListener(OListElementEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(OListElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(OListElementEvents type, HtmlEventHandlerWithTarget<OListElement> listener);

		public extern void AddEventListener(OListElementEvents type, HtmlEventHandlerWithTarget<OListElement> listener, bool capture);

		public extern void AddEventListener(OListElementEvents type, IEventListener listener);

		public extern void AddEventListener(OListElementEvents type, IEventListener listener, bool capture);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<OListElement> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<OListElement> listener, bool capture);

		public bool Compact;

		public extern void RemoveEventListener(OListElementEvents type, Action listener);

		public extern void RemoveEventListener(OListElementEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(OListElementEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(OListElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(OListElementEvents type, HtmlEventHandlerWithTarget<OListElement> listener);

		public extern void RemoveEventListener(OListElementEvents type, HtmlEventHandlerWithTarget<OListElement> listener, bool capture);

		public extern void RemoveEventListener(OListElementEvents type, IEventListener listener);

		public extern void RemoveEventListener(OListElementEvents type, IEventListener listener, bool capture);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<OListElement> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<OListElement> listener, bool capture);

		public bool Reversed;

		public int Start;

		public string Type;
	}
}
