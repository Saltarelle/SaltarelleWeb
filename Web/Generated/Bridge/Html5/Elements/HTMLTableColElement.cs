namespace Bridge.Html5.Elements
{
	[Namespace(false), External, Name("Element")]
	public partial class HTMLTableColElement : HTMLElement
	{
		internal extern HTMLTableColElement();

		public extern void AddEventListener(HTMLTableColElementEvents type, Action listener);

		public extern void AddEventListener(HTMLTableColElementEvents type, Action listener, bool capture);

		public extern void AddEventListener(HTMLTableColElementEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(HTMLTableColElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(HTMLTableColElementEvents type, HtmlEventHandlerWithTarget<HTMLTableColElement> listener);

		public extern void AddEventListener(HTMLTableColElementEvents type, HtmlEventHandlerWithTarget<HTMLTableColElement> listener, bool capture);

		public extern void AddEventListener(HTMLTableColElementEvents type, IEventListener listener);

		public extern void AddEventListener(HTMLTableColElementEvents type, IEventListener listener, bool capture);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<HTMLTableColElement> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<HTMLTableColElement> listener, bool capture);

		public string Align;

		public string Ch;

		public string ChOff;

		public extern void RemoveEventListener(HTMLTableColElementEvents type, Action listener);

		public extern void RemoveEventListener(HTMLTableColElementEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(HTMLTableColElementEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(HTMLTableColElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(HTMLTableColElementEvents type, HtmlEventHandlerWithTarget<HTMLTableColElement> listener);

		public extern void RemoveEventListener(HTMLTableColElementEvents type, HtmlEventHandlerWithTarget<HTMLTableColElement> listener, bool capture);

		public extern void RemoveEventListener(HTMLTableColElementEvents type, IEventListener listener);

		public extern void RemoveEventListener(HTMLTableColElementEvents type, IEventListener listener, bool capture);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<HTMLTableColElement> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<HTMLTableColElement> listener, bool capture);

		public int Span;

		public string VAlign;

		public string Width;
	}
}
