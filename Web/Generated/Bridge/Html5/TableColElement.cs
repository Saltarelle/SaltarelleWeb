namespace Bridge.Html5
{
	[Namespace("false"), External(TypeCheckCode = "{$System.Script}.isInstanceOfType({this}, Element) && ({this}.tagName === 'COL' || {this}.tagName === 'COLGROUP')"), Name("Element")]
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

		[FieldProperty]
		public extern int Span
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
