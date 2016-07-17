namespace Bridge.Html5
{
	[Namespace("false"), External, Name("Element")]
	public partial class TableCaptionElement : Element
	{
		internal extern TableCaptionElement();

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<TableCaptionElement> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<TableCaptionElement> listener, bool capture);

		public extern void AddEventListener(TableCaptionElementEvents type, Action listener);

		public extern void AddEventListener(TableCaptionElementEvents type, Action listener, bool capture);

		public extern void AddEventListener(TableCaptionElementEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(TableCaptionElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(TableCaptionElementEvents type, HtmlEventHandlerWithTarget<TableCaptionElement> listener);

		public extern void AddEventListener(TableCaptionElementEvents type, HtmlEventHandlerWithTarget<TableCaptionElement> listener, bool capture);

		public extern void AddEventListener(TableCaptionElementEvents type, IEventListener listener);

		public extern void AddEventListener(TableCaptionElementEvents type, IEventListener listener, bool capture);

		public string Align;

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<TableCaptionElement> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<TableCaptionElement> listener, bool capture);

		public extern void RemoveEventListener(TableCaptionElementEvents type, Action listener);

		public extern void RemoveEventListener(TableCaptionElementEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(TableCaptionElementEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(TableCaptionElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(TableCaptionElementEvents type, HtmlEventHandlerWithTarget<TableCaptionElement> listener);

		public extern void RemoveEventListener(TableCaptionElementEvents type, HtmlEventHandlerWithTarget<TableCaptionElement> listener, bool capture);

		public extern void RemoveEventListener(TableCaptionElementEvents type, IEventListener listener);

		public extern void RemoveEventListener(TableCaptionElementEvents type, IEventListener listener, bool capture);
	}
}
