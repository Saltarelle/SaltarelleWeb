using System.Html;
using System.Runtime.CompilerServices;

namespace System.Net.ServerEvents {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class EventSource : EventTarget {
		internal EventSource() {
		}

		public EventSource(string url) {
		}

		public EventSource(string url, EventSourceInit eventSourceInitDict) {
		}

		public void Close() {
		}

		public const ushort CLOSED = 2;

		public const ushort CONNECTING = 0;

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
		public ushort ReadyState {
			get {
				return 0;
			}
		}

		[IntrinsicProperty]
		public string Url {
			get {
				return null;
			}
		}

		[IntrinsicProperty]
		public bool WithCredentials {
			get {
				return false;
			}
		}
	}
}
