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

		[FieldProperty]
		public extern string Cols
		{
			get;
			set;
		}

		[FieldProperty, Name("onafterprint")]
		public extern HtmlEventHandler OnAfterprint
		{
			get;
			set;
		}

		[FieldProperty, Name("onbeforeprint")]
		public extern HtmlEventHandler OnBeforeprint
		{
			get;
			set;
		}

		[FieldProperty, Name("onbeforeunload")]
		public extern BeforeUnloadEventHandler OnBeforeunload
		{
			get;
			set;
		}

		[FieldProperty, Name("onhashchange")]
		public extern HtmlEventHandler OnHashchange
		{
			get;
			set;
		}

		[FieldProperty, Name("onmessage")]
		public extern HtmlEventHandler OnMessage
		{
			get;
			set;
		}

		[FieldProperty, Name("onoffline")]
		public extern HtmlEventHandler OnOffline
		{
			get;
			set;
		}

		[FieldProperty, Name("ononline")]
		public extern HtmlEventHandler OnOnline
		{
			get;
			set;
		}

		[FieldProperty, Name("onpagehide")]
		public extern HtmlEventHandler OnPagehide
		{
			get;
			set;
		}

		[FieldProperty, Name("onpageshow")]
		public extern HtmlEventHandler OnPageshow
		{
			get;
			set;
		}

		[FieldProperty, Name("onpopstate")]
		public extern HtmlEventHandler OnPopstate
		{
			get;
			set;
		}

		[FieldProperty, Name("onresize")]
		public extern HtmlEventHandler OnResize
		{
			get;
			set;
		}

		[FieldProperty, Name("onunload")]
		public extern HtmlEventHandler OnUnload
		{
			get;
			set;
		}

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

		[FieldProperty]
		public extern string Rows
		{
			get;
			set;
		}
	}
}
