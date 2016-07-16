namespace Bridge.Html5.Net
{
	[Namespace("false"), External(ObeysTypeSystem = true), Name("EventTarget")]
	public partial class XmlHttpRequestEventTarget : EventTarget
	{
		internal extern XmlHttpRequestEventTarget();

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<XmlHttpRequestEventTarget> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<XmlHttpRequestEventTarget> listener, bool capture);

		public extern void AddEventListener(XmlHttpRequestEventTargetEvents type, Action listener);

		public extern void AddEventListener(XmlHttpRequestEventTargetEvents type, Action listener, bool capture);

		public extern void AddEventListener(XmlHttpRequestEventTargetEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(XmlHttpRequestEventTargetEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(XmlHttpRequestEventTargetEvents type, HtmlEventHandlerWithTarget<XmlHttpRequestEventTarget> listener);

		public extern void AddEventListener(XmlHttpRequestEventTargetEvents type, HtmlEventHandlerWithTarget<XmlHttpRequestEventTarget> listener, bool capture);

		public extern void AddEventListener(XmlHttpRequestEventTargetEvents type, IEventListener listener);

		public extern void AddEventListener(XmlHttpRequestEventTargetEvents type, IEventListener listener, bool capture);

		[FieldProperty, Name("onabort")]
		public extern HtmlEventHandler OnAbort
		{
			get;
			set;
		}

		[FieldProperty, Name("onerror")]
		public extern HtmlEventHandler OnError
		{
			get;
			set;
		}

		[FieldProperty, Name("onload")]
		public extern HtmlEventHandler OnLoad
		{
			get;
			set;
		}

		[FieldProperty, Name("onloadend")]
		public extern HtmlEventHandler OnLoadend
		{
			get;
			set;
		}

		[FieldProperty, Name("onloadstart")]
		public extern HtmlEventHandler OnLoadstart
		{
			get;
			set;
		}

		[FieldProperty, Name("onprogress")]
		public extern HtmlEventHandler OnProgress
		{
			get;
			set;
		}

		[FieldProperty, Name("ontimeout")]
		public extern HtmlEventHandler OnTimeout
		{
			get;
			set;
		}

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<XmlHttpRequestEventTarget> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<XmlHttpRequestEventTarget> listener, bool capture);

		public extern void RemoveEventListener(XmlHttpRequestEventTargetEvents type, Action listener);

		public extern void RemoveEventListener(XmlHttpRequestEventTargetEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(XmlHttpRequestEventTargetEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(XmlHttpRequestEventTargetEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(XmlHttpRequestEventTargetEvents type, HtmlEventHandlerWithTarget<XmlHttpRequestEventTarget> listener);

		public extern void RemoveEventListener(XmlHttpRequestEventTargetEvents type, HtmlEventHandlerWithTarget<XmlHttpRequestEventTarget> listener, bool capture);

		public extern void RemoveEventListener(XmlHttpRequestEventTargetEvents type, IEventListener listener);

		public extern void RemoveEventListener(XmlHttpRequestEventTargetEvents type, IEventListener listener, bool capture);
	}
}
