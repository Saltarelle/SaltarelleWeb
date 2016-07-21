using Bridge.Html5.CSS;

namespace Bridge.Html5.Elements
{
	[Namespace(false), External, Name("Element")]
	public partial class HTMLStyleElement : HTMLElement
	{
		internal extern HTMLStyleElement();

		public extern void AddEventListener(HTMLStyleElementEvents type, Action listener);

		public extern void AddEventListener(HTMLStyleElementEvents type, Action listener, bool capture);

		public extern void AddEventListener(HTMLStyleElementEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(HTMLStyleElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(HTMLStyleElementEvents type, HtmlEventHandlerWithTarget<HTMLStyleElement> listener);

		public extern void AddEventListener(HTMLStyleElementEvents type, HtmlEventHandlerWithTarget<HTMLStyleElement> listener, bool capture);

		public extern void AddEventListener(HTMLStyleElementEvents type, IEventListener listener);

		public extern void AddEventListener(HTMLStyleElementEvents type, IEventListener listener, bool capture);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<HTMLStyleElement> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<HTMLStyleElement> listener, bool capture);

		public bool Disabled;

		public string Media;

		public extern void RemoveEventListener(HTMLStyleElementEvents type, Action listener);

		public extern void RemoveEventListener(HTMLStyleElementEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(HTMLStyleElementEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(HTMLStyleElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(HTMLStyleElementEvents type, HtmlEventHandlerWithTarget<HTMLStyleElement> listener);

		public extern void RemoveEventListener(HTMLStyleElementEvents type, HtmlEventHandlerWithTarget<HTMLStyleElement> listener, bool capture);

		public extern void RemoveEventListener(HTMLStyleElementEvents type, IEventListener listener);

		public extern void RemoveEventListener(HTMLStyleElementEvents type, IEventListener listener, bool capture);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<HTMLStyleElement> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<HTMLStyleElement> listener, bool capture);

		public bool Scoped;

		public readonly StyleSheet Sheet;

		public string Type;
	}
}
