using Bridge.Html5.Nodes;

namespace Bridge.Html5.Elements
{
	[Namespace(false), External, Name("Element")]
	public partial class HTMLTableRowElement : HTMLElement
	{
		internal extern HTMLTableRowElement();

		public extern void AddEventListener(HTMLTableRowElementEvents type, Action listener);

		public extern void AddEventListener(HTMLTableRowElementEvents type, Action listener, bool capture);

		public extern void AddEventListener(HTMLTableRowElementEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(HTMLTableRowElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(HTMLTableRowElementEvents type, HtmlEventHandlerWithTarget<HTMLTableRowElement> listener);

		public extern void AddEventListener(HTMLTableRowElementEvents type, HtmlEventHandlerWithTarget<HTMLTableRowElement> listener, bool capture);

		public extern void AddEventListener(HTMLTableRowElementEvents type, IEventListener listener);

		public extern void AddEventListener(HTMLTableRowElementEvents type, IEventListener listener, bool capture);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<HTMLTableRowElement> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<HTMLTableRowElement> listener, bool capture);

		public string Align;

		public string BgColor;

		public readonly HTMLCollection Cells;

		public string Ch;

		public string ChOff;

		public extern void DeleteCell(int index);

		public extern HTMLElement InsertCell();

		public extern HTMLElement InsertCell(int index);

		public extern void RemoveEventListener(HTMLTableRowElementEvents type, Action listener);

		public extern void RemoveEventListener(HTMLTableRowElementEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(HTMLTableRowElementEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(HTMLTableRowElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(HTMLTableRowElementEvents type, HtmlEventHandlerWithTarget<HTMLTableRowElement> listener);

		public extern void RemoveEventListener(HTMLTableRowElementEvents type, HtmlEventHandlerWithTarget<HTMLTableRowElement> listener, bool capture);

		public extern void RemoveEventListener(HTMLTableRowElementEvents type, IEventListener listener);

		public extern void RemoveEventListener(HTMLTableRowElementEvents type, IEventListener listener, bool capture);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<HTMLTableRowElement> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<HTMLTableRowElement> listener, bool capture);

		public readonly int RowIndex;

		public readonly int SectionRowIndex;

		public string VAlign;
	}
}
