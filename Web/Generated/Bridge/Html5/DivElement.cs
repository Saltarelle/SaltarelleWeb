namespace Bridge.Html5
{
	[Namespace(false), External, Name("Element")]
	public partial class DivElement : Element
	{
		internal extern DivElement();

		public extern void AddEventListener(DivElementEvents type, Action listener);

		public extern void AddEventListener(DivElementEvents type, Action listener, bool capture);

		public extern void AddEventListener(DivElementEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(DivElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(DivElementEvents type, HtmlEventHandlerWithTarget<DivElement> listener);

		public extern void AddEventListener(DivElementEvents type, HtmlEventHandlerWithTarget<DivElement> listener, bool capture);

		public extern void AddEventListener(DivElementEvents type, IEventListener listener);

		public extern void AddEventListener(DivElementEvents type, IEventListener listener, bool capture);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<DivElement> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<DivElement> listener, bool capture);

		public string Align;

		public extern void RemoveEventListener(DivElementEvents type, Action listener);

		public extern void RemoveEventListener(DivElementEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(DivElementEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(DivElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(DivElementEvents type, HtmlEventHandlerWithTarget<DivElement> listener);

		public extern void RemoveEventListener(DivElementEvents type, HtmlEventHandlerWithTarget<DivElement> listener, bool capture);

		public extern void RemoveEventListener(DivElementEvents type, IEventListener listener);

		public extern void RemoveEventListener(DivElementEvents type, IEventListener listener, bool capture);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<DivElement> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<DivElement> listener, bool capture);
	}
}
