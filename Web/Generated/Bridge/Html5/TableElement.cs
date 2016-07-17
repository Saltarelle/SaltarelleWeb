namespace Bridge.Html5
{
	[Namespace(false), External, Name("Element")]
	public partial class TableElement : Element
	{
		internal extern TableElement();

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<TableElement> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<TableElement> listener, bool capture);

		public extern void AddEventListener(TableElementEvents type, Action listener);

		public extern void AddEventListener(TableElementEvents type, Action listener, bool capture);

		public extern void AddEventListener(TableElementEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(TableElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(TableElementEvents type, HtmlEventHandlerWithTarget<TableElement> listener);

		public extern void AddEventListener(TableElementEvents type, HtmlEventHandlerWithTarget<TableElement> listener, bool capture);

		public extern void AddEventListener(TableElementEvents type, IEventListener listener);

		public extern void AddEventListener(TableElementEvents type, IEventListener listener, bool capture);

		public string Align;

		public string BgColor;

		public string Border;

		public TableCaptionElement Caption;

		public string CellPadding;

		public string CellSpacing;

		public extern Element CreateCaption();

		public extern Element CreateTBody();

		public extern Element CreateTFoot();

		public extern Element CreateTHead();

		public extern void DeleteCaption();

		public extern void DeleteRow(int index);

		public extern void DeleteTFoot();

		public extern void DeleteTHead();

		public string Frame;

		public extern Element InsertRow();

		public extern Element InsertRow(int index);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<TableElement> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<TableElement> listener, bool capture);

		public extern void RemoveEventListener(TableElementEvents type, Action listener);

		public extern void RemoveEventListener(TableElementEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(TableElementEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(TableElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(TableElementEvents type, HtmlEventHandlerWithTarget<TableElement> listener);

		public extern void RemoveEventListener(TableElementEvents type, HtmlEventHandlerWithTarget<TableElement> listener, bool capture);

		public extern void RemoveEventListener(TableElementEvents type, IEventListener listener);

		public extern void RemoveEventListener(TableElementEvents type, IEventListener listener, bool capture);

		public readonly ElementCollection Rows;

		public string Rules;

		public string Summary;

		public readonly ElementCollection TBodies;

		public TableSectionElement TFoot;

		public TableSectionElement THead;

		public string Width;
	}
}
