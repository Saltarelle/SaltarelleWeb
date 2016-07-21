namespace Bridge.Html5.Nodes
{
	[Namespace(false), External]
	public partial class CDATASection : Text
	{
		internal extern CDATASection();

		public extern void AddEventListener(CDATASectionEvents type, Action listener);

		public extern void AddEventListener(CDATASectionEvents type, Action listener, bool capture);

		public extern void AddEventListener(CDATASectionEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(CDATASectionEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(CDATASectionEvents type, HtmlEventHandlerWithTarget<CDATASection> listener);

		public extern void AddEventListener(CDATASectionEvents type, HtmlEventHandlerWithTarget<CDATASection> listener, bool capture);

		public extern void AddEventListener(CDATASectionEvents type, IEventListener listener);

		public extern void AddEventListener(CDATASectionEvents type, IEventListener listener, bool capture);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<CDATASection> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<CDATASection> listener, bool capture);

		public extern void RemoveEventListener(CDATASectionEvents type, Action listener);

		public extern void RemoveEventListener(CDATASectionEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(CDATASectionEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(CDATASectionEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(CDATASectionEvents type, HtmlEventHandlerWithTarget<CDATASection> listener);

		public extern void RemoveEventListener(CDATASectionEvents type, HtmlEventHandlerWithTarget<CDATASection> listener, bool capture);

		public extern void RemoveEventListener(CDATASectionEvents type, IEventListener listener);

		public extern void RemoveEventListener(CDATASectionEvents type, IEventListener listener, bool capture);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<CDATASection> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<CDATASection> listener, bool capture);
	}
}
