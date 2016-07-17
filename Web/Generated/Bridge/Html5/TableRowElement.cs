namespace Bridge.Html5
{
	[Namespace("false"), External, Name("Element")]
	public partial class TableRowElement : Element
	{
		internal extern TableRowElement();

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<TableRowElement> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<TableRowElement> listener, bool capture);

		public extern void AddEventListener(TableRowElementEvents type, Action listener);

		public extern void AddEventListener(TableRowElementEvents type, Action listener, bool capture);

		public extern void AddEventListener(TableRowElementEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(TableRowElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(TableRowElementEvents type, HtmlEventHandlerWithTarget<TableRowElement> listener);

		public extern void AddEventListener(TableRowElementEvents type, HtmlEventHandlerWithTarget<TableRowElement> listener, bool capture);

		public extern void AddEventListener(TableRowElementEvents type, IEventListener listener);

		public extern void AddEventListener(TableRowElementEvents type, IEventListener listener, bool capture);

		public string Align;

		public string BgColor;

		public readonly ElementCollection Cells;

		public string Ch;

		public string ChOff;

		public extern void DeleteCell(int index);

		public extern Element InsertCell();

		public extern Element InsertCell(int index);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<TableRowElement> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<TableRowElement> listener, bool capture);

		public extern void RemoveEventListener(TableRowElementEvents type, Action listener);

		public extern void RemoveEventListener(TableRowElementEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(TableRowElementEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(TableRowElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(TableRowElementEvents type, HtmlEventHandlerWithTarget<TableRowElement> listener);

		public extern void RemoveEventListener(TableRowElementEvents type, HtmlEventHandlerWithTarget<TableRowElement> listener, bool capture);

		public extern void RemoveEventListener(TableRowElementEvents type, IEventListener listener);

		public extern void RemoveEventListener(TableRowElementEvents type, IEventListener listener, bool capture);

		public readonly int RowIndex;

		public readonly int SectionRowIndex;

		public string VAlign;
	}
}
