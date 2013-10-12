using System.Collections.TypedArrays;
using System.Runtime.CompilerServices;

namespace System.Html.Media.Audio {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class SourceBuffer : EventTarget {
		internal SourceBuffer() {
		}

		public void Abort() {
		}

		public void AddEventListener(SourceBufferEvents type, Action listener) {
		}

		public void AddEventListener(SourceBufferEvents type, Action listener, bool capture) {
		}

		public void AddEventListener(SourceBufferEvents type, HtmlEventHandler listener) {
		}

		public void AddEventListener(SourceBufferEvents type, HtmlEventHandler listener, bool capture) {
		}

		public void AddEventListener(SourceBufferEvents type, HtmlEventHandlerWithTarget<SourceBuffer> listener) {
		}

		public void AddEventListener(SourceBufferEvents type, HtmlEventHandlerWithTarget<SourceBuffer> listener, bool capture) {
		}

		public void AddEventListener(SourceBufferEvents type, IEventListener listener) {
		}

		public void AddEventListener(SourceBufferEvents type, IEventListener listener, bool capture) {
		}

		public void AddEventListener(string type, HtmlEventHandlerWithTarget<SourceBuffer> listener) {
		}

		public void AddEventListener(string type, HtmlEventHandlerWithTarget<SourceBuffer> listener, bool capture) {
		}

		public void AppendBuffer(ArrayBuffer data) {
		}

		public void AppendBuffer(ArrayBufferView data) {
		}

		[IntrinsicProperty]
		public double AppendWindowEnd {
			get {
				return 0;
			}
			set {
			}
		}

		[IntrinsicProperty]
		public double AppendWindowStart {
			get {
				return 0;
			}
			set {
			}
		}

		[IntrinsicProperty]
		public TimeRanges Buffered {
			get {
				return default(TimeRanges);
			}
		}

		[IntrinsicProperty]
		public SourceBufferAppendMode Mode {
			get {
				return default(SourceBufferAppendMode);
			}
			set {
			}
		}

		public void Remove(double start, double end) {
		}

		public void RemoveEventListener(SourceBufferEvents type, Action listener) {
		}

		public void RemoveEventListener(SourceBufferEvents type, Action listener, bool capture) {
		}

		public void RemoveEventListener(SourceBufferEvents type, HtmlEventHandler listener) {
		}

		public void RemoveEventListener(SourceBufferEvents type, HtmlEventHandler listener, bool capture) {
		}

		public void RemoveEventListener(SourceBufferEvents type, HtmlEventHandlerWithTarget<SourceBuffer> listener) {
		}

		public void RemoveEventListener(SourceBufferEvents type, HtmlEventHandlerWithTarget<SourceBuffer> listener, bool capture) {
		}

		public void RemoveEventListener(SourceBufferEvents type, IEventListener listener) {
		}

		public void RemoveEventListener(SourceBufferEvents type, IEventListener listener, bool capture) {
		}

		public void RemoveEventListener(string type, HtmlEventHandlerWithTarget<SourceBuffer> listener) {
		}

		public void RemoveEventListener(string type, HtmlEventHandlerWithTarget<SourceBuffer> listener, bool capture) {
		}

		[IntrinsicProperty]
		public double TimestampOffset {
			get {
				return 0;
			}
			set {
			}
		}

		[IntrinsicProperty]
		public bool Updating {
			get {
				return false;
			}
		}
	}
}
