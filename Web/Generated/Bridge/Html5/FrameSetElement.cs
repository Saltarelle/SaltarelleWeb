namespace Bridge.Html5
{
	[Namespace("false"), External(TypeCheckCode = "{$System.Script}.isInstanceOfType({this}, Element) && {this}.tagName === 'FRAMESET'"), Name("Element")]
	public partial class FrameSetElement : Element
	{
		internal extern FrameSetElement();

		public extern void AddEventListener(FrameSetElementEvents type, Action listener);

		public extern void AddEventListener(FrameSetElementEvents type, Action listener, bool capture);

		public extern void AddEventListener(FrameSetElementEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(FrameSetElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(FrameSetElementEvents type, HtmlEventHandlerWithTarget<FrameSetElement> listener);

		public extern void AddEventListener(FrameSetElementEvents type, HtmlEventHandlerWithTarget<FrameSetElement> listener, bool capture);

		public extern void AddEventListener(FrameSetElementEvents type, IEventListener listener);

		public extern void AddEventListener(FrameSetElementEvents type, IEventListener listener, bool capture);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<FrameSetElement> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<FrameSetElement> listener, bool capture);

		public string Cols;

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

		public extern void RemoveEventListener(FrameSetElementEvents type, Action listener);

		public extern void RemoveEventListener(FrameSetElementEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(FrameSetElementEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(FrameSetElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(FrameSetElementEvents type, HtmlEventHandlerWithTarget<FrameSetElement> listener);

		public extern void RemoveEventListener(FrameSetElementEvents type, HtmlEventHandlerWithTarget<FrameSetElement> listener, bool capture);

		public extern void RemoveEventListener(FrameSetElementEvents type, IEventListener listener);

		public extern void RemoveEventListener(FrameSetElementEvents type, IEventListener listener, bool capture);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<FrameSetElement> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<FrameSetElement> listener, bool capture);

		public string Rows;
	}
}
