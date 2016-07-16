namespace Bridge.Html5.Net.ServerEvents
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class EventSource : EventTarget
	{
		internal extern EventSource();

		public extern EventSource(string url);

		public extern EventSource(string url, EventSourceInit eventSourceInitDict);

		public extern void AddEventListener(EventSourceEvents type, Action listener);

		public extern void AddEventListener(EventSourceEvents type, Action listener, bool capture);

		public extern void AddEventListener(EventSourceEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(EventSourceEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(EventSourceEvents type, HtmlEventHandlerWithTarget<EventSource> listener);

		public extern void AddEventListener(EventSourceEvents type, HtmlEventHandlerWithTarget<EventSource> listener, bool capture);

		public extern void AddEventListener(EventSourceEvents type, IEventListener listener);

		public extern void AddEventListener(EventSourceEvents type, IEventListener listener, bool capture);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<EventSource> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<EventSource> listener, bool capture);

		public extern void Close();

		public const ushort CLOSED = 2;

		public const ushort CONNECTING = 0;

		[FieldProperty, Name("onerror")]
		public extern HtmlEventHandler OnError
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

		[FieldProperty, Name("onopen")]
		public extern HtmlEventHandler OnOpen
		{
			get;
			set;
		}

		public const ushort OPEN = 1;

		[FieldProperty]
		public extern ushort ReadyState
		{
			get;
		}

		public extern void RemoveEventListener(EventSourceEvents type, Action listener);

		public extern void RemoveEventListener(EventSourceEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(EventSourceEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(EventSourceEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(EventSourceEvents type, HtmlEventHandlerWithTarget<EventSource> listener);

		public extern void RemoveEventListener(EventSourceEvents type, HtmlEventHandlerWithTarget<EventSource> listener, bool capture);

		public extern void RemoveEventListener(EventSourceEvents type, IEventListener listener);

		public extern void RemoveEventListener(EventSourceEvents type, IEventListener listener, bool capture);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<EventSource> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<EventSource> listener, bool capture);

		[FieldProperty]
		public extern string Url
		{
			get;
		}

		[FieldProperty]
		public extern bool WithCredentials
		{
			get;
		}
	}
}
