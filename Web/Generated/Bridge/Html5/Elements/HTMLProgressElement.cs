namespace Bridge.Html5.Elements
{
	[Namespace(false), External, Name("Element")]
	public partial class HTMLProgressElement : HTMLElement
	{
		internal extern HTMLProgressElement();

		public extern void AddEventListener(HTMLProgressElementEvents type, Action listener);

		public extern void AddEventListener(HTMLProgressElementEvents type, Action listener, bool capture);

		public extern void AddEventListener(HTMLProgressElementEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(HTMLProgressElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(HTMLProgressElementEvents type, HtmlEventHandlerWithTarget<HTMLProgressElement> listener);

		public extern void AddEventListener(HTMLProgressElementEvents type, HtmlEventHandlerWithTarget<HTMLProgressElement> listener, bool capture);

		public extern void AddEventListener(HTMLProgressElementEvents type, IEventListener listener);

		public extern void AddEventListener(HTMLProgressElementEvents type, IEventListener listener, bool capture);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<HTMLProgressElement> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<HTMLProgressElement> listener, bool capture);

		public double Max;

		public readonly double Position;

		public extern void RemoveEventListener(HTMLProgressElementEvents type, Action listener);

		public extern void RemoveEventListener(HTMLProgressElementEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(HTMLProgressElementEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(HTMLProgressElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(HTMLProgressElementEvents type, HtmlEventHandlerWithTarget<HTMLProgressElement> listener);

		public extern void RemoveEventListener(HTMLProgressElementEvents type, HtmlEventHandlerWithTarget<HTMLProgressElement> listener, bool capture);

		public extern void RemoveEventListener(HTMLProgressElementEvents type, IEventListener listener);

		public extern void RemoveEventListener(HTMLProgressElementEvents type, IEventListener listener, bool capture);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<HTMLProgressElement> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<HTMLProgressElement> listener, bool capture);

		public double Value;
	}
}
