namespace Bridge.Html5
{
	[Namespace("false"), External, Name("Element")]
	public partial class HeadingElement : Element
	{
		internal extern HeadingElement();

		public extern void AddEventListener(HeadingElementEvents type, Action listener);

		public extern void AddEventListener(HeadingElementEvents type, Action listener, bool capture);

		public extern void AddEventListener(HeadingElementEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(HeadingElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(HeadingElementEvents type, HtmlEventHandlerWithTarget<HeadingElement> listener);

		public extern void AddEventListener(HeadingElementEvents type, HtmlEventHandlerWithTarget<HeadingElement> listener, bool capture);

		public extern void AddEventListener(HeadingElementEvents type, IEventListener listener);

		public extern void AddEventListener(HeadingElementEvents type, IEventListener listener, bool capture);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<HeadingElement> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<HeadingElement> listener, bool capture);

		public string Align;

		public extern void RemoveEventListener(HeadingElementEvents type, Action listener);

		public extern void RemoveEventListener(HeadingElementEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(HeadingElementEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(HeadingElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(HeadingElementEvents type, HtmlEventHandlerWithTarget<HeadingElement> listener);

		public extern void RemoveEventListener(HeadingElementEvents type, HtmlEventHandlerWithTarget<HeadingElement> listener, bool capture);

		public extern void RemoveEventListener(HeadingElementEvents type, IEventListener listener);

		public extern void RemoveEventListener(HeadingElementEvents type, IEventListener listener, bool capture);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<HeadingElement> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<HeadingElement> listener, bool capture);
	}
}
