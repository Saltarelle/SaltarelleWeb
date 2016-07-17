namespace Bridge.Html5.Net.ServerEvents
{
	[Namespace(false), External]
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

		[Name("onerror")]
		public HtmlEventHandler OnError;

		[Name("onmessage")]
		public HtmlEventHandler OnMessage;

		[Name("onopen")]
		public HtmlEventHandler OnOpen;

		public const ushort OPEN = 1;

		public readonly ushort ReadyState;

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

		public readonly string Url;

		public readonly bool WithCredentials;
	}
}
