namespace Bridge.Html5
{
	[Namespace("false"), External, Name("Element")]
	public partial class BRElement : Element
	{
		internal extern BRElement();

		public extern void AddEventListener(BRElementEvents type, Action listener);

		public extern void AddEventListener(BRElementEvents type, Action listener, bool capture);

		public extern void AddEventListener(BRElementEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(BRElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(BRElementEvents type, HtmlEventHandlerWithTarget<BRElement> listener);

		public extern void AddEventListener(BRElementEvents type, HtmlEventHandlerWithTarget<BRElement> listener, bool capture);

		public extern void AddEventListener(BRElementEvents type, IEventListener listener);

		public extern void AddEventListener(BRElementEvents type, IEventListener listener, bool capture);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<BRElement> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<BRElement> listener, bool capture);

		public string Clear;

		public extern void RemoveEventListener(BRElementEvents type, Action listener);

		public extern void RemoveEventListener(BRElementEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(BRElementEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(BRElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(BRElementEvents type, HtmlEventHandlerWithTarget<BRElement> listener);

		public extern void RemoveEventListener(BRElementEvents type, HtmlEventHandlerWithTarget<BRElement> listener, bool capture);

		public extern void RemoveEventListener(BRElementEvents type, IEventListener listener);

		public extern void RemoveEventListener(BRElementEvents type, IEventListener listener, bool capture);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<BRElement> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<BRElement> listener, bool capture);
	}
}
