namespace Bridge.Html5
{
	[Namespace("false"), External(TypeCheckCode = "{$System.Script}.isInstanceOfType({this}, Element) && {this}.tagName === 'BODY'"), Name("Element")]
	public partial class BodyElement : Element
	{
		internal extern BodyElement();

		public extern void AddEventListener(BodyElementEvents type, Action listener);

		public extern void AddEventListener(BodyElementEvents type, Action listener, bool capture);

		public extern void AddEventListener(BodyElementEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(BodyElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(BodyElementEvents type, HtmlEventHandlerWithTarget<BodyElement> listener);

		public extern void AddEventListener(BodyElementEvents type, HtmlEventHandlerWithTarget<BodyElement> listener, bool capture);

		public extern void AddEventListener(BodyElementEvents type, IEventListener listener);

		public extern void AddEventListener(BodyElementEvents type, IEventListener listener, bool capture);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<BodyElement> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<BodyElement> listener, bool capture);

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

		public extern void RemoveEventListener(BodyElementEvents type, Action listener);

		public extern void RemoveEventListener(BodyElementEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(BodyElementEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(BodyElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(BodyElementEvents type, HtmlEventHandlerWithTarget<BodyElement> listener);

		public extern void RemoveEventListener(BodyElementEvents type, HtmlEventHandlerWithTarget<BodyElement> listener, bool capture);

		public extern void RemoveEventListener(BodyElementEvents type, IEventListener listener);

		public extern void RemoveEventListener(BodyElementEvents type, IEventListener listener, bool capture);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<BodyElement> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<BodyElement> listener, bool capture);

		public string Text;

		public string VLink;
	}
}
