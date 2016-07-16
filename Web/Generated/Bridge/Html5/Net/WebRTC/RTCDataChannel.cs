using Bridge.Html5.Collections.TypedArrays;
using Bridge.Html5.IO;

namespace Bridge.Html5.Net.WebRTC
{
	[Namespace("false"), External(ObeysTypeSystem = true), Name("DataChannel")]
	public partial class RTCDataChannel : EventTarget
	{
		internal RTCDataChannel()
		{
		}

		public void AddEventListener(RTCDataChannelEvents type, Action listener)
		{
		}

		public void AddEventListener(RTCDataChannelEvents type, Action listener, bool capture)
		{
		}

		public void AddEventListener(RTCDataChannelEvents type, HtmlEventHandler listener)
		{
		}

		public void AddEventListener(RTCDataChannelEvents type, HtmlEventHandler listener, bool capture)
		{
		}

		public void AddEventListener(RTCDataChannelEvents type, HtmlEventHandlerWithTarget<RTCDataChannel> listener)
		{
		}

		public void AddEventListener(RTCDataChannelEvents type, HtmlEventHandlerWithTarget<RTCDataChannel> listener, bool capture)
		{
		}

		public void AddEventListener(RTCDataChannelEvents type, IEventListener listener)
		{
		}

		public void AddEventListener(RTCDataChannelEvents type, IEventListener listener, bool capture)
		{
		}

		public void AddEventListener(string type, HtmlEventHandlerWithTarget<RTCDataChannel> listener)
		{
		}

		public void AddEventListener(string type, HtmlEventHandlerWithTarget<RTCDataChannel> listener, bool capture)
		{
		}

		[FieldProperty]
		public RTCDataChannelType BinaryType
		{
			get {
				return default(RTCDataChannelType);
			}
			set {
			}
		}

		[FieldProperty]
		public int BufferedAmount
		{
			get {
				return 0;
			}
		}

		public void Close()
		{
		}

		[FieldProperty]
		public ushort Id
		{
			get {
				return 0;
			}
		}

		[FieldProperty]
		public string Label
		{
			get {
				return null;
			}
		}

		[FieldProperty, Name("onclose")]
		public HtmlEventHandler OnClose
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

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

		[FieldProperty]
		public bool Ordered
		{
			get {
				return false;
			}
		}

		[FieldProperty]
		public string Protocol
		{
			get {
				return null;
			}
		}

		[FieldProperty]
		public RTCDataChannelState ReadyState
		{
			get {
				return default(RTCDataChannelState);
			}
		}

		[FieldProperty]
		public bool Reliable
		{
			get {
				return false;
			}
		}

		public void RemoveEventListener(RTCDataChannelEvents type, Action listener)
		{
		}

		public void RemoveEventListener(RTCDataChannelEvents type, Action listener, bool capture)
		{
		}

		public void RemoveEventListener(RTCDataChannelEvents type, HtmlEventHandler listener)
		{
		}

		public void RemoveEventListener(RTCDataChannelEvents type, HtmlEventHandler listener, bool capture)
		{
		}

		public void RemoveEventListener(RTCDataChannelEvents type, HtmlEventHandlerWithTarget<RTCDataChannel> listener)
		{
		}

		public void RemoveEventListener(RTCDataChannelEvents type, HtmlEventHandlerWithTarget<RTCDataChannel> listener, bool capture)
		{
		}

		public void RemoveEventListener(RTCDataChannelEvents type, IEventListener listener)
		{
		}

		public void RemoveEventListener(RTCDataChannelEvents type, IEventListener listener, bool capture)
		{
		}

		public void RemoveEventListener(string type, HtmlEventHandlerWithTarget<RTCDataChannel> listener)
		{
		}

		public void RemoveEventListener(string type, HtmlEventHandlerWithTarget<RTCDataChannel> listener, bool capture)
		{
		}

		public void Send(ArrayBuffer data)
		{
		}

		public void Send(ArrayBufferView data)
		{
		}

		public void Send(Blob data)
		{
		}

		public void Send(string data)
		{
		}

		[FieldProperty]
		public ushort Stream
		{
			get {
				return 0;
			}
		}
	}
}
