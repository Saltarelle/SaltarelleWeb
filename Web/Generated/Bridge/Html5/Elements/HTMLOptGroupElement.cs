namespace Bridge.Html5.Elements
{
	[Namespace(false), External, Name("Element")]
	public partial class HTMLOptGroupElement : HTMLElement
	{
		internal extern HTMLOptGroupElement();

		public extern void AddEventListener(HTMLOptGroupElementEvents type, Action listener);

		public extern void AddEventListener(HTMLOptGroupElementEvents type, Action listener, bool capture);

		public extern void AddEventListener(HTMLOptGroupElementEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(HTMLOptGroupElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(HTMLOptGroupElementEvents type, HtmlEventHandlerWithTarget<HTMLOptGroupElement> listener);

		public extern void AddEventListener(HTMLOptGroupElementEvents type, HtmlEventHandlerWithTarget<HTMLOptGroupElement> listener, bool capture);

		public extern void AddEventListener(HTMLOptGroupElementEvents type, IEventListener listener);

		public extern void AddEventListener(HTMLOptGroupElementEvents type, IEventListener listener, bool capture);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<HTMLOptGroupElement> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<HTMLOptGroupElement> listener, bool capture);

		public bool Disabled;

		public string Label;

		public extern void RemoveEventListener(HTMLOptGroupElementEvents type, Action listener);

		public extern void RemoveEventListener(HTMLOptGroupElementEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(HTMLOptGroupElementEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(HTMLOptGroupElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(HTMLOptGroupElementEvents type, HtmlEventHandlerWithTarget<HTMLOptGroupElement> listener);

		public extern void RemoveEventListener(HTMLOptGroupElementEvents type, HtmlEventHandlerWithTarget<HTMLOptGroupElement> listener, bool capture);

		public extern void RemoveEventListener(HTMLOptGroupElementEvents type, IEventListener listener);

		public extern void RemoveEventListener(HTMLOptGroupElementEvents type, IEventListener listener, bool capture);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<HTMLOptGroupElement> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<HTMLOptGroupElement> listener, bool capture);
	}
}
