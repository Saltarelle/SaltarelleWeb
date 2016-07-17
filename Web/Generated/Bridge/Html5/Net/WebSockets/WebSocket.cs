using Bridge.Html5.Collections.TypedArrays;
using Bridge.Html5.IO;

namespace Bridge.Html5.Net.WebSockets
{
	[Namespace(false), External]
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

		public BinaryType BinaryType;

		public readonly int BufferedAmount;

		public extern void Close();

		public extern void Close(ushort code);

		public extern void Close(ushort code, string reason);

		public const ushort CLOSED = 3;

		public const ushort CLOSING = 2;

		public const ushort CONNECTING = 0;

		public readonly string Extensions;

		[Name("onclose")]
		public HtmlEventHandler OnClose;

		[Name("onerror")]
		public HtmlEventHandler OnError;

		[Name("onmessage")]
		public HtmlEventHandler OnMessage;

		[Name("onopen")]
		public HtmlEventHandler OnOpen;

		public const ushort OPEN = 1;

		public readonly string Protocol;

		public readonly ReadyState ReadyState;

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

		public readonly string Url;
	}
}
