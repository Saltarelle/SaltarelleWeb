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

		void AddEventListener(string type, HtmlEventHandlerWithTarget<SourceBufferList> listener) {
		}

		void AddEventListener(string type, HtmlEventHandlerWithTarget<SourceBufferList> listener, bool capture) {
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

		void RemoveEventListener(string type, HtmlEventHandlerWithTarget<SourceBufferList> listener) {
		}

		void RemoveEventListener(string type, HtmlEventHandlerWithTarget<SourceBufferList> listener, bool capture) {
		}
	}
}
