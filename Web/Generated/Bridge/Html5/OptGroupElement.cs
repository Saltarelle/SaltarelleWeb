namespace Bridge.Html5
{
	[Namespace(false), External, Name("Element")]
	public partial class OptGroupElement : Element
	{
		internal extern OptGroupElement();

		public extern void AddEventListener(OptGroupElementEvents type, Action listener);

		public extern void AddEventListener(OptGroupElementEvents type, Action listener, bool capture);

		public extern void AddEventListener(OptGroupElementEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(OptGroupElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(OptGroupElementEvents type, HtmlEventHandlerWithTarget<OptGroupElement> listener);

		public extern void AddEventListener(OptGroupElementEvents type, HtmlEventHandlerWithTarget<OptGroupElement> listener, bool capture);

		public extern void AddEventListener(OptGroupElementEvents type, IEventListener listener);

		public extern void AddEventListener(OptGroupElementEvents type, IEventListener listener, bool capture);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<OptGroupElement> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<OptGroupElement> listener, bool capture);

		public bool Disabled;

		public string Label;

		public extern void RemoveEventListener(OptGroupElementEvents type, Action listener);

		public extern void RemoveEventListener(OptGroupElementEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(OptGroupElementEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(OptGroupElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(OptGroupElementEvents type, HtmlEventHandlerWithTarget<OptGroupElement> listener);

		public extern void RemoveEventListener(OptGroupElementEvents type, HtmlEventHandlerWithTarget<OptGroupElement> listener, bool capture);

		public extern void RemoveEventListener(OptGroupElementEvents type, IEventListener listener);

		public extern void RemoveEventListener(OptGroupElementEvents type, IEventListener listener, bool capture);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<OptGroupElement> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<OptGroupElement> listener, bool capture);
	}
}
