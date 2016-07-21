namespace Bridge.Html5.Elements
{
	[Namespace(false), External, Name("Element")]
	public partial class HTMLBodyElement : HTMLElement
	{
		internal extern HTMLBodyElement();

		public extern void AddEventListener(HTMLBodyElementEvents type, Action listener);

		public extern void AddEventListener(HTMLBodyElementEvents type, Action listener, bool capture);

		public extern void AddEventListener(HTMLBodyElementEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(HTMLBodyElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(HTMLBodyElementEvents type, HtmlEventHandlerWithTarget<HTMLBodyElement> listener);

		public extern void AddEventListener(HTMLBodyElementEvents type, HtmlEventHandlerWithTarget<HTMLBodyElement> listener, bool capture);

		public extern void AddEventListener(HTMLBodyElementEvents type, IEventListener listener);

		public extern void AddEventListener(HTMLBodyElementEvents type, IEventListener listener, bool capture);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<HTMLBodyElement> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<HTMLBodyElement> listener, bool capture);

		public string ALink;

		public string Background;

		public string BgColor;

		public string Link;

		[Name("onafterprint")]
		public HtmlEventHandler OnAfterprint;

		[Name("onbeforeprint")]
		public HtmlEventHandler OnBeforeprint;

		[Name("onbeforeunload")]
		public BeforeUnloadEventHandler OnBeforeunload;

		[Name("onhashchange")]
		public HtmlEventHandler OnHashchange;

		[Name("onmessage")]
		public HtmlEventHandler OnMessage;

		[Name("onoffline")]
		public HtmlEventHandler OnOffline;

		[Name("ononline")]
		public HtmlEventHandler OnOnline;

		[Name("onpagehide")]
		public HtmlEventHandler OnPagehide;

		[Name("onpageshow")]
		public HtmlEventHandler OnPageshow;

		[Name("onpopstate")]
		public HtmlEventHandler OnPopstate;

		[Name("onresize")]
		public HtmlEventHandler OnResize;

		[Name("onunload")]
		public HtmlEventHandler OnUnload;

		public extern void RemoveEventListener(HTMLBodyElementEvents type, Action listener);

		public extern void RemoveEventListener(HTMLBodyElementEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(HTMLBodyElementEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(HTMLBodyElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(HTMLBodyElementEvents type, HtmlEventHandlerWithTarget<HTMLBodyElement> listener);

		public extern void RemoveEventListener(HTMLBodyElementEvents type, HtmlEventHandlerWithTarget<HTMLBodyElement> listener, bool capture);

		public extern void RemoveEventListener(HTMLBodyElementEvents type, IEventListener listener);

		public extern void RemoveEventListener(HTMLBodyElementEvents type, IEventListener listener, bool capture);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<HTMLBodyElement> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<HTMLBodyElement> listener, bool capture);

		public string Text;

		public string VLink;
	}
}
