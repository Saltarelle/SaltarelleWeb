namespace Bridge.Html5.Elements
{
	[Namespace(false), External, Name("Element")]
	public partial class HTMLMetaElement : HTMLElement
	{
		internal extern HTMLMetaElement();

		public extern void AddEventListener(HTMLMetaElementEvents type, Action listener);

		public extern void AddEventListener(HTMLMetaElementEvents type, Action listener, bool capture);

		public extern void AddEventListener(HTMLMetaElementEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(HTMLMetaElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(HTMLMetaElementEvents type, HtmlEventHandlerWithTarget<HTMLMetaElement> listener);

		public extern void AddEventListener(HTMLMetaElementEvents type, HtmlEventHandlerWithTarget<HTMLMetaElement> listener, bool capture);

		public extern void AddEventListener(HTMLMetaElementEvents type, IEventListener listener);

		public extern void AddEventListener(HTMLMetaElementEvents type, IEventListener listener, bool capture);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<HTMLMetaElement> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<HTMLMetaElement> listener, bool capture);

		public string Content;

		public string HttpEquiv;

		public string Name;

		public extern void RemoveEventListener(HTMLMetaElementEvents type, Action listener);

		public extern void RemoveEventListener(HTMLMetaElementEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(HTMLMetaElementEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(HTMLMetaElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(HTMLMetaElementEvents type, HtmlEventHandlerWithTarget<HTMLMetaElement> listener);

		public extern void RemoveEventListener(HTMLMetaElementEvents type, HtmlEventHandlerWithTarget<HTMLMetaElement> listener, bool capture);

		public extern void RemoveEventListener(HTMLMetaElementEvents type, IEventListener listener);

		public extern void RemoveEventListener(HTMLMetaElementEvents type, IEventListener listener, bool capture);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<HTMLMetaElement> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<HTMLMetaElement> listener, bool capture);

		public string Scheme;
	}
}
