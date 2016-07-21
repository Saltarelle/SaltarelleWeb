using Bridge.Html5.Nodes;

namespace Bridge.Html5.Elements
{
	[Namespace(false), External, Name("Element")]
	public partial class HTMLTableSectionElement : HTMLElement
	{
		internal extern HTMLTableSectionElement();

		public extern void AddEventListener(HTMLTableSectionElementEvents type, Action listener);

		public extern void AddEventListener(HTMLTableSectionElementEvents type, Action listener, bool capture);

		public extern void AddEventListener(HTMLTableSectionElementEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(HTMLTableSectionElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(HTMLTableSectionElementEvents type, HtmlEventHandlerWithTarget<HTMLTableSectionElement> listener);

		public extern void AddEventListener(HTMLTableSectionElementEvents type, HtmlEventHandlerWithTarget<HTMLTableSectionElement> listener, bool capture);

		public extern void AddEventListener(HTMLTableSectionElementEvents type, IEventListener listener);

		public extern void AddEventListener(HTMLTableSectionElementEvents type, IEventListener listener, bool capture);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<HTMLTableSectionElement> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<HTMLTableSectionElement> listener, bool capture);

		public string Align;

		public string Ch;

		public string ChOff;

		public extern void DeleteRow(int index);

		public extern HTMLElement InsertRow();

		public extern HTMLElement InsertRow(int index);

		public extern void RemoveEventListener(HTMLTableSectionElementEvents type, Action listener);

		public extern void RemoveEventListener(HTMLTableSectionElementEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(HTMLTableSectionElementEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(HTMLTableSectionElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(HTMLTableSectionElementEvents type, HtmlEventHandlerWithTarget<HTMLTableSectionElement> listener);

		public extern void RemoveEventListener(HTMLTableSectionElementEvents type, HtmlEventHandlerWithTarget<HTMLTableSectionElement> listener, bool capture);

		public extern void RemoveEventListener(HTMLTableSectionElementEvents type, IEventListener listener);

		public extern void RemoveEventListener(HTMLTableSectionElementEvents type, IEventListener listener, bool capture);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<HTMLTableSectionElement> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<HTMLTableSectionElement> listener, bool capture);

		public readonly HTMLCollection Rows;

		public string VAlign;
	}
}
