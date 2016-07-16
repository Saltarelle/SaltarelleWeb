namespace Bridge.Html5
{
	[Namespace("false"), External(TypeCheckCode = "{$System.Script}.isInstanceOfType({this}, Element) && {this}.tagName === 'TABLE'"), Name("Element")]
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
		public extern string Border
		{
			get;
			set;
		}

		[FieldProperty]
		public extern TableCaptionElement Caption
		{
			get;
			set;
		}

		[FieldProperty]
		public extern string CellPadding
		{
			get;
			set;
		}

		[FieldProperty]
		public extern string CellSpacing
		{
			get;
			set;
		}

		public extern Element CreateCaption();

		public extern Element CreateTBody();

		public extern Element CreateTFoot();

		public extern Element CreateTHead();

		public extern void DeleteCaption();

		public extern void DeleteRow(int index);

		public extern void DeleteTFoot();

		public extern void DeleteTHead();

		[FieldProperty]
		public extern string Frame
		{
			get;
			set;
		}

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

		[FieldProperty]
		public extern ElementCollection Rows
		{
			get;
		}

		[FieldProperty]
		public extern string Rules
		{
			get;
			set;
		}

		[FieldProperty]
		public extern string Summary
		{
			get;
			set;
		}

		[FieldProperty]
		public extern ElementCollection TBodies
		{
			get;
		}

		[FieldProperty]
		public extern TableSectionElement TFoot
		{
			get;
			set;
		}

		[FieldProperty]
		public extern TableSectionElement THead
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
