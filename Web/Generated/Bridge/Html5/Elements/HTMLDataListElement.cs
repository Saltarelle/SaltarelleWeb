using Bridge.Html5.Nodes;

namespace Bridge.Html5.Elements
{
	[Namespace(false), External, Name("Element")]
	public partial class HTMLDataListElement : HTMLElement
	{
		internal extern HTMLDataListElement();

		public extern void AddEventListener(HTMLDataListElementEvents type, Action listener);

		public extern void AddEventListener(HTMLDataListElementEvents type, Action listener, bool capture);

		public extern void AddEventListener(HTMLDataListElementEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(HTMLDataListElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(HTMLDataListElementEvents type, HtmlEventHandlerWithTarget<HTMLDataListElement> listener);

		public extern void AddEventListener(HTMLDataListElementEvents type, HtmlEventHandlerWithTarget<HTMLDataListElement> listener, bool capture);

		public extern void AddEventListener(HTMLDataListElementEvents type, IEventListener listener);

		public extern void AddEventListener(HTMLDataListElementEvents type, IEventListener listener, bool capture);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<HTMLDataListElement> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<HTMLDataListElement> listener, bool capture);

		public readonly HTMLCollection Options;

		public extern void RemoveEventListener(HTMLDataListElementEvents type, Action listener);

		public extern void RemoveEventListener(HTMLDataListElementEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(HTMLDataListElementEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(HTMLDataListElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(HTMLDataListElementEvents type, HtmlEventHandlerWithTarget<HTMLDataListElement> listener);

		public extern void RemoveEventListener(HTMLDataListElementEvents type, HtmlEventHandlerWithTarget<HTMLDataListElement> listener, bool capture);

		public extern void RemoveEventListener(HTMLDataListElementEvents type, IEventListener listener);

		public extern void RemoveEventListener(HTMLDataListElementEvents type, IEventListener listener, bool capture);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<HTMLDataListElement> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<HTMLDataListElement> listener, bool capture);
	}
}
