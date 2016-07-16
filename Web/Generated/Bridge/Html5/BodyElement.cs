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

		[FieldProperty]
		public extern string ALink
		{
			get;
			set;
		}

		[FieldProperty]
		public extern string Background
		{
			get;
			set;
		}

		[FieldProperty]
		public extern string BgColor
		{
			get;
			set;
		}

		[FieldProperty]
		public extern string Link
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

		[FieldProperty]
		public extern string Text
		{
			get;
			set;
		}

		[FieldProperty]
		public extern string VLink
		{
			get;
			set;
		}
	}
}
