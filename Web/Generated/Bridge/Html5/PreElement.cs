namespace Bridge.Html5
{
	[Namespace(false), External, Name("Element")]
	public partial class PreElement : Element
	{
		internal extern PreElement();

		public extern void AddEventListener(PreElementEvents type, Action listener);

		public extern void AddEventListener(PreElementEvents type, Action listener, bool capture);

		public extern void AddEventListener(PreElementEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(PreElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(PreElementEvents type, HtmlEventHandlerWithTarget<PreElement> listener);

		public extern void AddEventListener(PreElementEvents type, HtmlEventHandlerWithTarget<PreElement> listener, bool capture);

		public extern void AddEventListener(PreElementEvents type, IEventListener listener);

		public extern void AddEventListener(PreElementEvents type, IEventListener listener, bool capture);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<PreElement> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<PreElement> listener, bool capture);

		public extern void RemoveEventListener(PreElementEvents type, Action listener);

		public extern void RemoveEventListener(PreElementEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(PreElementEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(PreElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(PreElementEvents type, HtmlEventHandlerWithTarget<PreElement> listener);

		public extern void RemoveEventListener(PreElementEvents type, HtmlEventHandlerWithTarget<PreElement> listener, bool capture);

		public extern void RemoveEventListener(PreElementEvents type, IEventListener listener);

		public extern void RemoveEventListener(PreElementEvents type, IEventListener listener, bool capture);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<PreElement> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<PreElement> listener, bool capture);

		public int Width;
	}
}
