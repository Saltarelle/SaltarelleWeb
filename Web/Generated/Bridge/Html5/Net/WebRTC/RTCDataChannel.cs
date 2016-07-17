using Bridge.Html5.Collections.TypedArrays;
using Bridge.Html5.IO;

namespace Bridge.Html5.Net.WebRTC
{
	[Namespace("false"), External, Name("DataChannel")]
	public partial class RTCDataChannel : EventTarget
	{
		internal extern RTCDataChannel();

		public extern void AddEventListener(RTCDataChannelEvents type, Action listener);

		public extern void AddEventListener(RTCDataChannelEvents type, Action listener, bool capture);

		public extern void AddEventListener(RTCDataChannelEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(RTCDataChannelEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(RTCDataChannelEvents type, HtmlEventHandlerWithTarget<RTCDataChannel> listener);

		public extern void AddEventListener(RTCDataChannelEvents type, HtmlEventHandlerWithTarget<RTCDataChannel> listener, bool capture);

		public extern void AddEventListener(RTCDataChannelEvents type, IEventListener listener);

		public extern void AddEventListener(RTCDataChannelEvents type, IEventListener listener, bool capture);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<RTCDataChannel> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<RTCDataChannel> listener, bool capture);

		public RTCDataChannelType BinaryType;

		public readonly int BufferedAmount;

		public extern void Close();

		public readonly ushort Id;

		public readonly string Label;

		[Name("onclose")]
		public HtmlEventHandler OnClose;

		[Name("onerror")]
		public HtmlEventHandler OnError;

		[Name("onmessage")]
		public HtmlEventHandler OnMessage;

		[Name("onopen")]
		public HtmlEventHandler OnOpen;

		public readonly bool Ordered;

		public readonly string Protocol;

		public readonly RTCDataChannelState ReadyState;

		public readonly bool Reliable;

		public extern void RemoveEventListener(RTCDataChannelEvents type, Action listener);

		public extern void RemoveEventListener(RTCDataChannelEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(RTCDataChannelEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(RTCDataChannelEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(RTCDataChannelEvents type, HtmlEventHandlerWithTarget<RTCDataChannel> listener);

		public extern void RemoveEventListener(RTCDataChannelEvents type, HtmlEventHandlerWithTarget<RTCDataChannel> listener, bool capture);

		public extern void RemoveEventListener(RTCDataChannelEvents type, IEventListener listener);

		public extern void RemoveEventListener(RTCDataChannelEvents type, IEventListener listener, bool capture);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<RTCDataChannel> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<RTCDataChannel> listener, bool capture);

		public extern void Send(ArrayBuffer data);

		public extern void Send(ArrayBufferView data);

		public extern void Send(Blob data);

		public extern void Send(string data);

		public readonly ushort Stream;
	}
}
