using Bridge.Html5.Nodes;

namespace Bridge.Html5.Elements
{
	[Namespace(false), External, Name("Element")]
	public partial class HTMLTableElement : HTMLElement
	{
		internal extern HTMLTableElement();

		public extern void AddEventListener(HTMLTableElementEvents type, Action listener);

		public extern void AddEventListener(HTMLTableElementEvents type, Action listener, bool capture);

		public extern void AddEventListener(HTMLTableElementEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(HTMLTableElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(HTMLTableElementEvents type, HtmlEventHandlerWithTarget<HTMLTableElement> listener);

		public extern void AddEventListener(HTMLTableElementEvents type, HtmlEventHandlerWithTarget<HTMLTableElement> listener, bool capture);

		public extern void AddEventListener(HTMLTableElementEvents type, IEventListener listener);

		public extern void AddEventListener(HTMLTableElementEvents type, IEventListener listener, bool capture);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<HTMLTableElement> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<HTMLTableElement> listener, bool capture);

		public string Align;

		public string BgColor;

		public string Border;

		public HTMLTableCaptionElement Caption;

		public string CellPadding;

		public string CellSpacing;

		public extern HTMLElement CreateCaption();

		public extern HTMLElement CreateTBody();

		public extern HTMLElement CreateTFoot();

		public extern HTMLElement CreateTHead();

		public extern void DeleteCaption();

		public extern void DeleteRow(int index);

		public extern void DeleteTFoot();

		public extern void DeleteTHead();

		public string Frame;

		public extern HTMLElement InsertRow();

		public extern HTMLElement InsertRow(int index);

		public extern void RemoveEventListener(HTMLTableElementEvents type, Action listener);

		public extern void RemoveEventListener(HTMLTableElementEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(HTMLTableElementEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(HTMLTableElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(HTMLTableElementEvents type, HtmlEventHandlerWithTarget<HTMLTableElement> listener);

		public extern void RemoveEventListener(HTMLTableElementEvents type, HtmlEventHandlerWithTarget<HTMLTableElement> listener, bool capture);

		public extern void RemoveEventListener(HTMLTableElementEvents type, IEventListener listener);

		public extern void RemoveEventListener(HTMLTableElementEvents type, IEventListener listener, bool capture);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<HTMLTableElement> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<HTMLTableElement> listener, bool capture);

		public readonly HTMLCollection Rows;

		public string Rules;

		public string Summary;

		public readonly HTMLCollection TBodies;

		public HTMLTableSectionElement TFoot;

		public HTMLTableSectionElement THead;

		public string Width;
	}
}
