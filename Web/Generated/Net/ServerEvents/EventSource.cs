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

		public void AddEventListener(EventSourceEvents type, Action listener) {
		}

		public void AddEventListener(EventSourceEvents type, Action listener, bool capture) {
		}

		public void AddEventListener(EventSourceEvents type, HtmlEventHandler listener) {
		}

		public void AddEventListener(EventSourceEvents type, HtmlEventHandler listener, bool capture) {
		}

		public void AddEventListener(EventSourceEvents type, HtmlEventHandlerWithTarget<EventSource> listener) {
		}

		public void AddEventListener(EventSourceEvents type, HtmlEventHandlerWithTarget<EventSource> listener, bool capture) {
		}

		public void AddEventListener(EventSourceEvents type, IEventListener listener) {
		}

		public void AddEventListener(EventSourceEvents type, IEventListener listener, bool capture) {
		}

		public void AddEventListener(string type, HtmlEventHandlerWithTarget<EventSource> listener) {
		}

		public void AddEventListener(string type, HtmlEventHandlerWithTarget<EventSource> listener, bool capture) {
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

		public void RemoveEventListener(EventSourceEvents type, Action listener) {
		}

		public void RemoveEventListener(EventSourceEvents type, Action listener, bool capture) {
		}

		public void RemoveEventListener(EventSourceEvents type, HtmlEventHandler listener) {
		}

		public void RemoveEventListener(EventSourceEvents type, HtmlEventHandler listener, bool capture) {
		}

		public void RemoveEventListener(EventSourceEvents type, HtmlEventHandlerWithTarget<EventSource> listener) {
		}

		public void RemoveEventListener(EventSourceEvents type, HtmlEventHandlerWithTarget<EventSource> listener, bool capture) {
		}

		public void RemoveEventListener(EventSourceEvents type, IEventListener listener) {
		}

		public void RemoveEventListener(EventSourceEvents type, IEventListener listener, bool capture) {
		}

		public void RemoveEventListener(string type, HtmlEventHandlerWithTarget<EventSource> listener) {
		}

		public void RemoveEventListener(string type, HtmlEventHandlerWithTarget<EventSource> listener, bool capture) {
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
