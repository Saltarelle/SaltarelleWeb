namespace Bridge.Html5.Elements
{
	[Namespace(false), External, Name("Element")]
	public partial class HTMLPreElement : HTMLElement
	{
		internal extern HTMLPreElement();

		public extern void AddEventListener(HTMLPreElementEvents type, Action listener);

		public extern void AddEventListener(HTMLPreElementEvents type, Action listener, bool capture);

		public extern void AddEventListener(HTMLPreElementEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(HTMLPreElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(HTMLPreElementEvents type, HtmlEventHandlerWithTarget<HTMLPreElement> listener);

		public extern void AddEventListener(HTMLPreElementEvents type, HtmlEventHandlerWithTarget<HTMLPreElement> listener, bool capture);

		public extern void AddEventListener(HTMLPreElementEvents type, IEventListener listener);

		public extern void AddEventListener(HTMLPreElementEvents type, IEventListener listener, bool capture);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<HTMLPreElement> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<HTMLPreElement> listener, bool capture);

		public extern void RemoveEventListener(HTMLPreElementEvents type, Action listener);

		public extern void RemoveEventListener(HTMLPreElementEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(HTMLPreElementEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(HTMLPreElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(HTMLPreElementEvents type, HtmlEventHandlerWithTarget<HTMLPreElement> listener);

		public extern void RemoveEventListener(HTMLPreElementEvents type, HtmlEventHandlerWithTarget<HTMLPreElement> listener, bool capture);

		public extern void RemoveEventListener(HTMLPreElementEvents type, IEventListener listener);

		public extern void RemoveEventListener(HTMLPreElementEvents type, IEventListener listener, bool capture);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<HTMLPreElement> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<HTMLPreElement> listener, bool capture);

		public int Width;
	}
}
