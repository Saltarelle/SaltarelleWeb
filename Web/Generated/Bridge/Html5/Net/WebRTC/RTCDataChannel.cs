using Bridge.Html5.Collections.TypedArrays;
using Bridge.Html5.IO;

namespace Bridge.Html5.Net.WebRTC
{
	[Namespace("false"), External(ObeysTypeSystem = true), Name("DataChannel")]
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

		[FieldProperty]
		public extern RTCDataChannelType BinaryType
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

		[FieldProperty]
		public extern ushort Id
		{
			get;
		}

		[FieldProperty]
		public extern string Label
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

		[FieldProperty]
		public extern bool Ordered
		{
			get;
		}

		[FieldProperty]
		public extern string Protocol
		{
			get;
		}

		[FieldProperty]
		public extern RTCDataChannelState ReadyState
		{
			get;
		}

		[FieldProperty]
		public extern bool Reliable
		{
			get;
		}

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

		[FieldProperty]
		public extern ushort Stream
		{
			get;
		}
	}
}
