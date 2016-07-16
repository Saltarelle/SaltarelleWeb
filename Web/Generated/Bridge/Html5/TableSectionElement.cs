namespace Bridge.Html5
{
	[Namespace("false"), External(TypeCheckCode = "{$System.Script}.isInstanceOfType({this}, Element) && ({this}.tagName === 'THEAD' || {this}.tagName === 'TFOOT' || {this}.tagName === 'TBODY')"), Name("Element")]
	public partial class TableSectionElement : Element
	{
		internal extern TableSectionElement();

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<TableSectionElement> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<TableSectionElement> listener, bool capture);

		public extern void AddEventListener(TableSectionElementEvents type, Action listener);

		public extern void AddEventListener(TableSectionElementEvents type, Action listener, bool capture);

		public extern void AddEventListener(TableSectionElementEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(TableSectionElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(TableSectionElementEvents type, HtmlEventHandlerWithTarget<TableSectionElement> listener);

		public extern void AddEventListener(TableSectionElementEvents type, HtmlEventHandlerWithTarget<TableSectionElement> listener, bool capture);

		public extern void AddEventListener(TableSectionElementEvents type, IEventListener listener);

		public extern void AddEventListener(TableSectionElementEvents type, IEventListener listener, bool capture);

		[FieldProperty]
		public extern string Align
		{
			get;
			set;
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

		public extern void DeleteRow(int index);

		public extern Element InsertRow();

		public extern Element InsertRow(int index);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<TableSectionElement> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<TableSectionElement> listener, bool capture);

		public extern void RemoveEventListener(TableSectionElementEvents type, Action listener);

		public extern void RemoveEventListener(TableSectionElementEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(TableSectionElementEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(TableSectionElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(TableSectionElementEvents type, HtmlEventHandlerWithTarget<TableSectionElement> listener);

		public extern void RemoveEventListener(TableSectionElementEvents type, HtmlEventHandlerWithTarget<TableSectionElement> listener, bool capture);

		public extern void RemoveEventListener(TableSectionElementEvents type, IEventListener listener);

		public extern void RemoveEventListener(TableSectionElementEvents type, IEventListener listener, bool capture);

		[FieldProperty]
		public extern ElementCollection Rows
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
