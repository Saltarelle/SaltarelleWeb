using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace System.Html.Media.Audio {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class SourceBufferList : EventTarget {
		internal SourceBufferList() {
		}

		[IndexerName("__Item"), IntrinsicProperty]
		public SourceBuffer this[uint index] {
			get {
				return default(SourceBuffer);
			}
		}

		public void AddEventListener(SourceBufferListEvents type, Action listener) {
		}

		public void AddEventListener(SourceBufferListEvents type, Action listener, bool capture) {
		}

		public void AddEventListener(SourceBufferListEvents type, HtmlEventHandler listener) {
		}

		public void AddEventListener(SourceBufferListEvents type, HtmlEventHandler listener, bool capture) {
		}

		public void AddEventListener(SourceBufferListEvents type, HtmlEventHandlerWithTarget<SourceBufferList> listener) {
		}

		public void AddEventListener(SourceBufferListEvents type, HtmlEventHandlerWithTarget<SourceBufferList> listener, bool capture) {
		}

		public void AddEventListener(SourceBufferListEvents type, IEventListener listener) {
		}

		public void AddEventListener(SourceBufferListEvents type, IEventListener listener, bool capture) {
		}

		public void AddEventListener(string type, HtmlEventHandlerWithTarget<SourceBufferList> listener) {
		}

		public void AddEventListener(string type, HtmlEventHandlerWithTarget<SourceBufferList> listener, bool capture) {
		}

		[EnumerateAsArray, InlineCode("new {$System.ArrayEnumerator}({this})")]
		public IEnumerator<SourceBuffer> GetEnumerator() {
			return null;
		}

		[IntrinsicProperty]
		public uint Length {
			get {
				return 0;
			}
		}

		public void RemoveEventListener(SourceBufferListEvents type, Action listener) {
		}

		public void RemoveEventListener(SourceBufferListEvents type, Action listener, bool capture) {
		}

		public void RemoveEventListener(SourceBufferListEvents type, HtmlEventHandler listener) {
		}

		public void RemoveEventListener(SourceBufferListEvents type, HtmlEventHandler listener, bool capture) {
		}

		public void RemoveEventListener(SourceBufferListEvents type, HtmlEventHandlerWithTarget<SourceBufferList> listener) {
		}

		public void RemoveEventListener(SourceBufferListEvents type, HtmlEventHandlerWithTarget<SourceBufferList> listener, bool capture) {
		}

		public void RemoveEventListener(SourceBufferListEvents type, IEventListener listener) {
		}

		public void RemoveEventListener(SourceBufferListEvents type, IEventListener listener, bool capture) {
		}

		public void RemoveEventListener(string type, HtmlEventHandlerWithTarget<SourceBufferList> listener) {
		}

		public void RemoveEventListener(string type, HtmlEventHandlerWithTarget<SourceBufferList> listener, bool capture) {
		}
	}
}
