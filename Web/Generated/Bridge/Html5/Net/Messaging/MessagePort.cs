namespace Bridge.Html5.Net.Messaging
{
	[Namespace(false), External]
	public partial class MessagePort : EventTarget
	{
		internal extern MessagePort();

		public extern void AddEventListener(MessagePortEvents type, Action listener);

		public extern void AddEventListener(MessagePortEvents type, Action listener, bool capture);

		public extern void AddEventListener(MessagePortEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(MessagePortEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(MessagePortEvents type, HtmlEventHandlerWithTarget<MessagePort> listener);

		public extern void AddEventListener(MessagePortEvents type, HtmlEventHandlerWithTarget<MessagePort> listener, bool capture);

		public extern void AddEventListener(MessagePortEvents type, IEventListener listener);

		public extern void AddEventListener(MessagePortEvents type, IEventListener listener, bool capture);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<MessagePort> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<MessagePort> listener, bool capture);

		public extern void Close();

		[Name("onmessage")]
		public HtmlEventHandler OnMessage;

		public extern void PostMessage(object message);

		public extern void PostMessage(object message, object[] transferable);

		public extern void RemoveEventListener(MessagePortEvents type, Action listener);

		public extern void RemoveEventListener(MessagePortEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(MessagePortEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(MessagePortEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(MessagePortEvents type, HtmlEventHandlerWithTarget<MessagePort> listener);

		public extern void RemoveEventListener(MessagePortEvents type, HtmlEventHandlerWithTarget<MessagePort> listener, bool capture);

		public extern void RemoveEventListener(MessagePortEvents type, IEventListener listener);

		public extern void RemoveEventListener(MessagePortEvents type, IEventListener listener, bool capture);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<MessagePort> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<MessagePort> listener, bool capture);

		public extern void Start();
	}
}
