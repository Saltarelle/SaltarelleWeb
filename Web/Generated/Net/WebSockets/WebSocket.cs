using System.Collections.TypedArrays;
using System.Html;
using System.IO;
using System.Runtime.CompilerServices;

namespace System.Net.WebSockets {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class WebSocket : EventTarget {
		internal WebSocket() {
		}

		public WebSocket(string url) {
		}

		public WebSocket(string url, string protocols) {
		}

		public WebSocket(string url, string[] protocols) {
		}

		[IntrinsicProperty]
		public BinaryType BinaryType {
			get {
				return default(BinaryType);
			}
			set {
			}
		}

		[IntrinsicProperty]
		public uint BufferedAmount {
			get {
				return 0;
			}
		}

		public void Close() {
		}

		public void Close(ushort code) {
		}

		public void Close(ushort code, string reason) {
		}

		public const ushort CLOSED = 3;

		public const ushort CLOSING = 2;

		public const ushort CONNECTING = 0;

		[IntrinsicProperty]
		public string Extensions {
			get {
				return null;
			}
		}

		[IntrinsicProperty, ScriptName("onclose")]
		public HtmlEventHandler OnClose {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onerror")]
		public HtmlEventHandler OnError {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onmessage")]
		public HtmlEventHandler OnMessage {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onopen")]
		public HtmlEventHandler OnOpen {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		public const ushort OPEN = 1;

		[IntrinsicProperty]
		public string Protocol {
			get {
				return null;
			}
		}

		[IntrinsicProperty]
		public ReadyState ReadyState {
			get {
				return default(ReadyState);
			}
		}

		public void Send(ArrayBuffer data) {
		}

		public void Send(ArrayBufferView data) {
		}

		public void Send(Blob data) {
		}

		public void Send(string data) {
		}

		[IntrinsicProperty]
		public string Url {
			get {
				return null;
			}
		}
	}
}
