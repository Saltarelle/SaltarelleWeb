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

		[Name("onabort")]
		public HtmlEventHandler OnAbort;

		[Name("onerror")]
		public HtmlEventHandler OnError;

		[Name("onload")]
		public HtmlEventHandler OnLoad;

		[Name("onloadend")]
		public HtmlEventHandler OnLoadend;

		[Name("onloadstart")]
		public HtmlEventHandler OnLoadstart;

		[Name("onprogress")]
		public HtmlEventHandler OnProgress;

		[Name("ontimeout")]
		public HtmlEventHandler OnTimeout;

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
