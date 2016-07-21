namespace Bridge.Html5.Elements
{
	[Namespace(false), External, Name("Element")]
	public partial class HTMLTableCellElement : HTMLElement
	{
		internal extern HTMLTableCellElement();

		public string Abbr;

		public extern void AddEventListener(HTMLTableCellElementEvents type, Action listener);

		public extern void AddEventListener(HTMLTableCellElementEvents type, Action listener, bool capture);

		public extern void AddEventListener(HTMLTableCellElementEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(HTMLTableCellElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(HTMLTableCellElementEvents type, HtmlEventHandlerWithTarget<HTMLTableCellElement> listener);

		public extern void AddEventListener(HTMLTableCellElementEvents type, HtmlEventHandlerWithTarget<HTMLTableCellElement> listener, bool capture);

		public extern void AddEventListener(HTMLTableCellElementEvents type, IEventListener listener);

		public extern void AddEventListener(HTMLTableCellElementEvents type, IEventListener listener, bool capture);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<HTMLTableCellElement> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<HTMLTableCellElement> listener, bool capture);

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

		public extern void RemoveEventListener(HTMLTableCellElementEvents type, Action listener);

		public extern void RemoveEventListener(HTMLTableCellElementEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(HTMLTableCellElementEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(HTMLTableCellElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(HTMLTableCellElementEvents type, HtmlEventHandlerWithTarget<HTMLTableCellElement> listener);

		public extern void RemoveEventListener(HTMLTableCellElementEvents type, HtmlEventHandlerWithTarget<HTMLTableCellElement> listener, bool capture);

		public extern void RemoveEventListener(HTMLTableCellElementEvents type, IEventListener listener);

		public extern void RemoveEventListener(HTMLTableCellElementEvents type, IEventListener listener, bool capture);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<HTMLTableCellElement> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<HTMLTableCellElement> listener, bool capture);

		public int RowSpan;

		public string Scope;

		public string VAlign;

		public string Width;
	}
}
