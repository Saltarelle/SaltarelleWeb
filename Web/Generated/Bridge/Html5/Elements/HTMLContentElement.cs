using Bridge.Html5.Nodes;

namespace Bridge.Html5.Elements
{
	[Namespace(false), External]
	public partial class HTMLContentElement : HTMLElement
	{
		internal extern HTMLContentElement();

		public extern void AddEventListener(HTMLContentElementEvents type, Action listener);

		public extern void AddEventListener(HTMLContentElementEvents type, Action listener, bool capture);

		public extern void AddEventListener(HTMLContentElementEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(HTMLContentElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(HTMLContentElementEvents type, HtmlEventHandlerWithTarget<HTMLContentElement> listener);

		public extern void AddEventListener(HTMLContentElementEvents type, HtmlEventHandlerWithTarget<HTMLContentElement> listener, bool capture);

		public extern void AddEventListener(HTMLContentElementEvents type, IEventListener listener);

		public extern void AddEventListener(HTMLContentElementEvents type, IEventListener listener, bool capture);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<HTMLContentElement> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<HTMLContentElement> listener, bool capture);

		public extern NodeList GetDistributedNodes();

		public extern void RemoveEventListener(HTMLContentElementEvents type, Action listener);

		public extern void RemoveEventListener(HTMLContentElementEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(HTMLContentElementEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(HTMLContentElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(HTMLContentElementEvents type, HtmlEventHandlerWithTarget<HTMLContentElement> listener);

		public extern void RemoveEventListener(HTMLContentElementEvents type, HtmlEventHandlerWithTarget<HTMLContentElement> listener, bool capture);

		public extern void RemoveEventListener(HTMLContentElementEvents type, IEventListener listener);

		public extern void RemoveEventListener(HTMLContentElementEvents type, IEventListener listener, bool capture);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<HTMLContentElement> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<HTMLContentElement> listener, bool capture);

		public string Select;
	}
}
