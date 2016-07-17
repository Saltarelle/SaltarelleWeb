namespace Bridge.Html5
{
	[Namespace(false), External, Name("Element")]
	public partial class SpanElement : Element
	{
		internal extern SpanElement();

		public extern void AddEventListener(SpanElementEvents type, Action listener);

		public extern void AddEventListener(SpanElementEvents type, Action listener, bool capture);

		public extern void AddEventListener(SpanElementEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(SpanElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(SpanElementEvents type, HtmlEventHandlerWithTarget<SpanElement> listener);

		public extern void AddEventListener(SpanElementEvents type, HtmlEventHandlerWithTarget<SpanElement> listener, bool capture);

		public extern void AddEventListener(SpanElementEvents type, IEventListener listener);

		public extern void AddEventListener(SpanElementEvents type, IEventListener listener, bool capture);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<SpanElement> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<SpanElement> listener, bool capture);

		public extern void RemoveEventListener(SpanElementEvents type, Action listener);

		public extern void RemoveEventListener(SpanElementEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(SpanElementEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(SpanElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(SpanElementEvents type, HtmlEventHandlerWithTarget<SpanElement> listener);

		public extern void RemoveEventListener(SpanElementEvents type, HtmlEventHandlerWithTarget<SpanElement> listener, bool capture);

		public extern void RemoveEventListener(SpanElementEvents type, IEventListener listener);

		public extern void RemoveEventListener(SpanElementEvents type, IEventListener listener, bool capture);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<SpanElement> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<SpanElement> listener, bool capture);
	}
}
