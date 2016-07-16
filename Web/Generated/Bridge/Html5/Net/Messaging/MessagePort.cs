namespace Bridge.Html5.Net.Messaging
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class MessagePort : EventTarget
	{
		internal MessagePort()
		{
		}

		public void AddEventListener(MessagePortEvents type, Action listener)
		{
		}

		public void AddEventListener(MessagePortEvents type, Action listener, bool capture)
		{
		}

		public void AddEventListener(MessagePortEvents type, HtmlEventHandler listener)
		{
		}

		public void AddEventListener(MessagePortEvents type, HtmlEventHandler listener, bool capture)
		{
		}

		public void AddEventListener(MessagePortEvents type, HtmlEventHandlerWithTarget<MessagePort> listener)
		{
		}

		public void AddEventListener(MessagePortEvents type, HtmlEventHandlerWithTarget<MessagePort> listener, bool capture)
		{
		}

		public void AddEventListener(MessagePortEvents type, IEventListener listener)
		{
		}

		public void AddEventListener(MessagePortEvents type, IEventListener listener, bool capture)
		{
		}

		public void AddEventListener(string type, HtmlEventHandlerWithTarget<MessagePort> listener)
		{
		}

		public void AddEventListener(string type, HtmlEventHandlerWithTarget<MessagePort> listener, bool capture)
		{
		}

		public void Close()
		{
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

		public void PostMessage(object message)
		{
		}

		public void PostMessage(object message, object[] transferable)
		{
		}

		public void RemoveEventListener(MessagePortEvents type, Action listener)
		{
		}

		public void RemoveEventListener(MessagePortEvents type, Action listener, bool capture)
		{
		}

		public void RemoveEventListener(MessagePortEvents type, HtmlEventHandler listener)
		{
		}

		public void RemoveEventListener(MessagePortEvents type, HtmlEventHandler listener, bool capture)
		{
		}

		public void RemoveEventListener(MessagePortEvents type, HtmlEventHandlerWithTarget<MessagePort> listener)
		{
		}

		public void RemoveEventListener(MessagePortEvents type, HtmlEventHandlerWithTarget<MessagePort> listener, bool capture)
		{
		}

		public void RemoveEventListener(MessagePortEvents type, IEventListener listener)
		{
		}

		public void RemoveEventListener(MessagePortEvents type, IEventListener listener, bool capture)
		{
		}

		public void RemoveEventListener(string type, HtmlEventHandlerWithTarget<MessagePort> listener)
		{
		}

		public void RemoveEventListener(string type, HtmlEventHandlerWithTarget<MessagePort> listener, bool capture)
		{
		}

		public void Start()
		{
		}
	}
}
