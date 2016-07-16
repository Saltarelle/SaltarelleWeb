namespace Bridge.Html5
{
	[Namespace("false"), External(TypeCheckCode = "{$System.Script}.isInstanceOfType({this}, Element) && {this}.tagName === 'TR'"), Name("Element")]
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

		[FieldProperty]
		public extern string Align
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
		public extern ElementCollection Cells
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

		[FieldProperty]
		public extern int RowIndex
		{
			get;
		}

		[FieldProperty]
		public extern int SectionRowIndex
		{
			get;
		}

		[FieldProperty]
		public extern string VAlign
		{
			get;
			set;
		}
	}
}
