namespace Bridge.Html5.Net.ServerEvents
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class EventSource : EventTarget
	{
		internal EventSource()
		{
		}

		public EventSource(string url)
		{
		}

		public EventSource(string url, EventSourceInit eventSourceInitDict)
		{
		}

		public void AddEventListener(EventSourceEvents type, Action listener)
		{
		}

		public void AddEventListener(EventSourceEvents type, Action listener, bool capture)
		{
		}

		public void AddEventListener(EventSourceEvents type, HtmlEventHandler listener)
		{
		}

		public void AddEventListener(EventSourceEvents type, HtmlEventHandler listener, bool capture)
		{
		}

		public void AddEventListener(EventSourceEvents type, HtmlEventHandlerWithTarget<EventSource> listener)
		{
		}

		public void AddEventListener(EventSourceEvents type, HtmlEventHandlerWithTarget<EventSource> listener, bool capture)
		{
		}

		public void AddEventListener(EventSourceEvents type, IEventListener listener)
		{
		}

		public void AddEventListener(EventSourceEvents type, IEventListener listener, bool capture)
		{
		}

		public void AddEventListener(string type, HtmlEventHandlerWithTarget<EventSource> listener)
		{
		}

		public void AddEventListener(string type, HtmlEventHandlerWithTarget<EventSource> listener, bool capture)
		{
		}

		public void Close()
		{
		}

		public const ushort CLOSED = 2;

		public const ushort CONNECTING = 0;

		[FieldProperty, Name("onerror")]
		public HtmlEventHandler OnError
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onmessage")]
		public HtmlEventHandler OnMessage
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onopen")]
		public HtmlEventHandler OnOpen
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		public const ushort OPEN = 1;

		[FieldProperty]
		public ushort ReadyState
		{
			get {
				return 0;
			}
		}

		public void RemoveEventListener(EventSourceEvents type, Action listener)
		{
		}

		public void RemoveEventListener(EventSourceEvents type, Action listener, bool capture)
		{
		}

		public void RemoveEventListener(EventSourceEvents type, HtmlEventHandler listener)
		{
		}

		public void RemoveEventListener(EventSourceEvents type, HtmlEventHandler listener, bool capture)
		{
		}

		public void RemoveEventListener(EventSourceEvents type, HtmlEventHandlerWithTarget<EventSource> listener)
		{
		}

		public void RemoveEventListener(EventSourceEvents type, HtmlEventHandlerWithTarget<EventSource> listener, bool capture)
		{
		}

		public void RemoveEventListener(EventSourceEvents type, IEventListener listener)
		{
		}

		public void RemoveEventListener(EventSourceEvents type, IEventListener listener, bool capture)
		{
		}

		public void RemoveEventListener(string type, HtmlEventHandlerWithTarget<EventSource> listener)
		{
		}

		public void RemoveEventListener(string type, HtmlEventHandlerWithTarget<EventSource> listener, bool capture)
		{
		}

		[FieldProperty]
		public string Url
		{
			get {
				return null;
			}
		}

		[FieldProperty]
		public bool WithCredentials
		{
			get {
				return false;
			}
		}
	}
}
