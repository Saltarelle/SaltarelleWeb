using Bridge.Html5.Collections.TypedArrays;
using Bridge.Html5.IO;

namespace Bridge.Html5.Net.WebSockets
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class WebSocket : EventTarget
	{
		internal extern WebSocket();

		public extern WebSocket(string url);

		public extern WebSocket(string url, string protocols);

		public extern WebSocket(string url, string[] protocols);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<WebSocket> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<WebSocket> listener, bool capture);

		public extern void AddEventListener(WebSocketEvents type, Action listener);

		public extern void AddEventListener(WebSocketEvents type, Action listener, bool capture);

		public extern void AddEventListener(WebSocketEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(WebSocketEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(WebSocketEvents type, HtmlEventHandlerWithTarget<WebSocket> listener);

		public extern void AddEventListener(WebSocketEvents type, HtmlEventHandlerWithTarget<WebSocket> listener, bool capture);

		public extern void AddEventListener(WebSocketEvents type, IEventListener listener);

		public extern void AddEventListener(WebSocketEvents type, IEventListener listener, bool capture);

		[FieldProperty]
		public extern BinaryType BinaryType
		{
			get;
			set;
		}

		[FieldProperty]
		public extern int BufferedAmount
		{
			get;
		}

		public extern void Close();

		public extern void Close(ushort code);

		public extern void Close(ushort code, string reason);

		public const ushort CLOSED = 3;

		public const ushort CLOSING = 2;

		public const ushort CONNECTING = 0;

		[FieldProperty]
		public extern string Extensions
		{
			get;
		}

		[FieldProperty, Name("onclose")]
		public extern HtmlEventHandler OnClose
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
		public extern string Protocol
		{
			get;
		}

		[FieldProperty]
		public extern ReadyState ReadyState
		{
			get;
		}

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<WebSocket> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<WebSocket> listener, bool capture);

		public extern void RemoveEventListener(WebSocketEvents type, Action listener);

		public extern void RemoveEventListener(WebSocketEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(WebSocketEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(WebSocketEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(WebSocketEvents type, HtmlEventHandlerWithTarget<WebSocket> listener);

		public extern void RemoveEventListener(WebSocketEvents type, HtmlEventHandlerWithTarget<WebSocket> listener, bool capture);

		public extern void RemoveEventListener(WebSocketEvents type, IEventListener listener);

		public extern void RemoveEventListener(WebSocketEvents type, IEventListener listener, bool capture);

		public extern void Send(ArrayBuffer data);

		public extern void Send(ArrayBufferView data);

		public extern void Send(Blob data);

		public extern void Send(string data);

		[FieldProperty]
		public extern string Url
		{
			get;
		}
	}
}
