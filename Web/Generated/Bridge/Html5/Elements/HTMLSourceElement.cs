namespace Bridge.Html5.Elements
{
	[Namespace(false), External, Name("Element")]
	public partial class HTMLSourceElement : HTMLElement
	{
		internal extern HTMLSourceElement();

		public extern void AddEventListener(HTMLSourceElementEvents type, Action listener);

		public extern void AddEventListener(HTMLSourceElementEvents type, Action listener, bool capture);

		public extern void AddEventListener(HTMLSourceElementEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(HTMLSourceElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(HTMLSourceElementEvents type, HtmlEventHandlerWithTarget<HTMLSourceElement> listener);

		public extern void AddEventListener(HTMLSourceElementEvents type, HtmlEventHandlerWithTarget<HTMLSourceElement> listener, bool capture);

		public extern void AddEventListener(HTMLSourceElementEvents type, IEventListener listener);

		public extern void AddEventListener(HTMLSourceElementEvents type, IEventListener listener, bool capture);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<HTMLSourceElement> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<HTMLSourceElement> listener, bool capture);

		public string Media;

		public extern void RemoveEventListener(HTMLSourceElementEvents type, Action listener);

		public extern void RemoveEventListener(HTMLSourceElementEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(HTMLSourceElementEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(HTMLSourceElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(HTMLSourceElementEvents type, HtmlEventHandlerWithTarget<HTMLSourceElement> listener);

		public extern void RemoveEventListener(HTMLSourceElementEvents type, HtmlEventHandlerWithTarget<HTMLSourceElement> listener, bool capture);

		public extern void RemoveEventListener(HTMLSourceElementEvents type, IEventListener listener);

		public extern void RemoveEventListener(HTMLSourceElementEvents type, IEventListener listener, bool capture);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<HTMLSourceElement> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<HTMLSourceElement> listener, bool capture);

		public string Src;

		public string Type;
	}
}
