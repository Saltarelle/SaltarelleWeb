namespace Bridge.Html5
{
	[Namespace("false"), External(TypeCheckCode = "{$System.Script}.isInstanceOfType({this}, Element) && ({this}.tagName === 'TD' || {this}.tagName === 'TH')"), Name("Element")]
	public partial class TableCellElement : Element
	{
		internal extern TableCellElement();

		[FieldProperty]
		public extern string Abbr
		{
			get;
			set;
		}

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

		[FieldProperty]
		public extern string Align
		{
			get;
			set;
		}

		[FieldProperty]
		public extern string Axis
		{
			get;
			set;
		}

		[FieldProperty]
		public extern string BgColor
		{
			get;
			set;
		}

		[FieldProperty]
		public extern int CellIndex
		{
			get;
		}

		[FieldProperty]
		public extern string Ch
		{
			get;
			set;
		}

		[FieldProperty]
		public extern string ChOff
		{
			get;
			set;
		}

		[FieldProperty]
		public extern int ColSpan
		{
			get;
			set;
		}

		[FieldProperty]
		public extern string Headers
		{
			get;
			set;
		}

		[FieldProperty]
		public extern string Height
		{
			get;
			set;
		}

		[FieldProperty]
		public extern bool NoWrap
		{
			get;
			set;
		}

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

		[FieldProperty]
		public extern int RowSpan
		{
			get;
			set;
		}

		[FieldProperty]
		public extern string Scope
		{
			get;
			set;
		}

		[FieldProperty]
		public extern string VAlign
		{
			get;
			set;
		}

		[FieldProperty]
		public extern string Width
		{
			get;
			set;
		}
	}
}
