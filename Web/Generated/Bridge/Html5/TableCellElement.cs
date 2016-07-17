namespace Bridge.Html5
{
	[Namespace("false"), External(TypeCheckCode = "{$System.Script}.isInstanceOfType({this}, Element) && ({this}.tagName === 'TD' || {this}.tagName === 'TH')"), Name("Element")]
	public partial class TableCellElement : Element
	{
		internal extern TableCellElement();

		public string Abbr;

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<TableCellElement> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<TableCellElement> listener, bool capture);

		public extern void AddEventListener(TableCellElementEvents type, Action listener);

		public extern void AddEventListener(TableCellElementEvents type, Action listener, bool capture);

		public extern void AddEventListener(TableCellElementEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(TableCellElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(TableCellElementEvents type, HtmlEventHandlerWithTarget<TableCellElement> listener);

		public extern void AddEventListener(TableCellElementEvents type, HtmlEventHandlerWithTarget<TableCellElement> listener, bool capture);

		public extern void AddEventListener(TableCellElementEvents type, IEventListener listener);

		public extern void AddEventListener(TableCellElementEvents type, IEventListener listener, bool capture);

		public string Align;

		public string Axis;

		public string BgColor;

		public readonly int CellIndex;

		public string Ch;

		public string ChOff;

		public int ColSpan;

		public string Headers;

		public string Height;

		public bool NoWrap;

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<TableCellElement> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<TableCellElement> listener, bool capture);

		public extern void RemoveEventListener(TableCellElementEvents type, Action listener);

		public extern void RemoveEventListener(TableCellElementEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(TableCellElementEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(TableCellElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(TableCellElementEvents type, HtmlEventHandlerWithTarget<TableCellElement> listener);

		public extern void RemoveEventListener(TableCellElementEvents type, HtmlEventHandlerWithTarget<TableCellElement> listener, bool capture);

		public extern void RemoveEventListener(TableCellElementEvents type, IEventListener listener);

		public extern void RemoveEventListener(TableCellElementEvents type, IEventListener listener, bool capture);

		public int RowSpan;

		public string Scope;

		public string VAlign;

		public string Width;
	}
}
