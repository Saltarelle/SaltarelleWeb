using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace System.Html.Media {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class TextTrackList : EventTarget {
		internal TextTrackList() {
		}

		[IndexerName("__Item"), IntrinsicProperty]
		public TextTrack this[uint index] {
			get {
				return default(TextTrack);
			}
		}

		public void AddEventListener(string type, HtmlEventHandlerWithTarget<TextTrackList> listener) {
		}

		public void AddEventListener(string type, HtmlEventHandlerWithTarget<TextTrackList> listener, bool capture) {
		}

		public void AddEventListener(TextTrackListEvents type, Action listener) {
		}

		public void AddEventListener(TextTrackListEvents type, Action listener, bool capture) {
		}

		public void AddEventListener(TextTrackListEvents type, HtmlEventHandler listener) {
		}

		public void AddEventListener(TextTrackListEvents type, HtmlEventHandler listener, bool capture) {
		}

		public void AddEventListener(TextTrackListEvents type, HtmlEventHandlerWithTarget<TextTrackList> listener) {
		}

		public void AddEventListener(TextTrackListEvents type, HtmlEventHandlerWithTarget<TextTrackList> listener, bool capture) {
		}

		public void AddEventListener(TextTrackListEvents type, IEventListener listener) {
		}

		public void AddEventListener(TextTrackListEvents type, IEventListener listener, bool capture) {
		}

		[EnumerateAsArray, InlineCode("new {$System.ArrayEnumerator}({this})")]
		public IEnumerator<TextTrack> GetEnumerator() {
			return null;
		}

		public TextTrack GetTrackById(string id) {
			return default(TextTrack);
		}

		[IntrinsicProperty]
		public uint Length {
			get {
				return 0;
			}
		}

		[IntrinsicProperty, ScriptName("onaddtrack")]
		public HtmlEventHandler OnAddtrack {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onremovetrack")]
		public HtmlEventHandler OnRemovetrack {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		public void RemoveEventListener(string type, HtmlEventHandlerWithTarget<TextTrackList> listener) {
		}

		public void RemoveEventListener(string type, HtmlEventHandlerWithTarget<TextTrackList> listener, bool capture) {
		}

		public void RemoveEventListener(TextTrackListEvents type, Action listener) {
		}

		public void RemoveEventListener(TextTrackListEvents type, Action listener, bool capture) {
		}

		public void RemoveEventListener(TextTrackListEvents type, HtmlEventHandler listener) {
		}

		public void RemoveEventListener(TextTrackListEvents type, HtmlEventHandler listener, bool capture) {
		}

		public void RemoveEventListener(TextTrackListEvents type, HtmlEventHandlerWithTarget<TextTrackList> listener) {
		}

		public void RemoveEventListener(TextTrackListEvents type, HtmlEventHandlerWithTarget<TextTrackList> listener, bool capture) {
		}

		public void RemoveEventListener(TextTrackListEvents type, IEventListener listener) {
		}

		public void RemoveEventListener(TextTrackListEvents type, IEventListener listener, bool capture) {
		}
	}
}
