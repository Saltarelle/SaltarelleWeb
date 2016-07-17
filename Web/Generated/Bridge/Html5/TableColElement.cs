namespace Bridge.Html5
{
	[Namespace("false"), External, Name("Element")]
	public partial class TableColElement : Element
	{
		internal extern TableColElement();

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<TableColElement> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<TableColElement> listener, bool capture);

		public extern void AddEventListener(TableColElementEvents type, Action listener);

		public extern void AddEventListener(TableColElementEvents type, Action listener, bool capture);

		public extern void AddEventListener(TableColElementEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(TableColElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(TableColElementEvents type, HtmlEventHandlerWithTarget<TableColElement> listener);

		public extern void AddEventListener(TableColElementEvents type, HtmlEventHandlerWithTarget<TableColElement> listener, bool capture);

		public extern void AddEventListener(TableColElementEvents type, IEventListener listener);

		public extern void AddEventListener(TableColElementEvents type, IEventListener listener, bool capture);

		public string Align;

		public string Ch;

		public string ChOff;

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<TableColElement> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<TableColElement> listener, bool capture);

		public extern void RemoveEventListener(TableColElementEvents type, Action listener);

		public extern void RemoveEventListener(TableColElementEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(TableColElementEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(TableColElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(TableColElementEvents type, HtmlEventHandlerWithTarget<TableColElement> listener);

		public extern void RemoveEventListener(TableColElementEvents type, HtmlEventHandlerWithTarget<TableColElement> listener, bool capture);

		public extern void RemoveEventListener(TableColElementEvents type, IEventListener listener);

		public extern void RemoveEventListener(TableColElementEvents type, IEventListener listener, bool capture);

		public int Span;

		public string VAlign;

		public string Width;
	}
}
