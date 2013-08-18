using System.Runtime.CompilerServices;

namespace System.Html.Media {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class TextTrack : EventTarget {
		internal TextTrack() {
		}

		[IntrinsicProperty]
		public TextTrackCueList ActiveCues {
			get {
				return default(TextTrackCueList);
			}
		}

		public void AddCue(TextTrackCue cue) {
		}

		public void AddEventListener(string type, HtmlEventHandlerWithTarget<TextTrack> listener) {
		}

		public void AddEventListener(string type, HtmlEventHandlerWithTarget<TextTrack> listener, bool capture) {
		}

		public void AddEventListener(TextTrackEvents type, Action listener) {
		}

		public void AddEventListener(TextTrackEvents type, Action listener, bool capture) {
		}

		public void AddEventListener(TextTrackEvents type, HtmlEventHandler listener) {
		}

		public void AddEventListener(TextTrackEvents type, HtmlEventHandler listener, bool capture) {
		}

		public void AddEventListener(TextTrackEvents type, HtmlEventHandlerWithTarget<TextTrack> listener) {
		}

		public void AddEventListener(TextTrackEvents type, HtmlEventHandlerWithTarget<TextTrack> listener, bool capture) {
		}

		public void AddEventListener(TextTrackEvents type, IEventListener listener) {
		}

		public void AddEventListener(TextTrackEvents type, IEventListener listener, bool capture) {
		}

		[IntrinsicProperty]
		public TextTrackCueList Cues {
			get {
				return default(TextTrackCueList);
			}
		}

		[IntrinsicProperty]
		public string Id {
			get {
				return null;
			}
		}

		[IntrinsicProperty]
		public string InBandMetadataTrackDispatchType {
			get {
				return null;
			}
		}

		[IntrinsicProperty]
		public TextTrackKind Kind {
			get {
				return default(TextTrackKind);
			}
		}

		[IntrinsicProperty]
		public string Label {
			get {
				return null;
			}
		}

		[IntrinsicProperty]
		public string Language {
			get {
				return null;
			}
		}

		[IntrinsicProperty]
		public TextTrackMode Mode {
			get {
				return default(TextTrackMode);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("oncuechange")]
		public HtmlEventHandler OnCuechange {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		public void RemoveCue(TextTrackCue cue) {
		}

		public void RemoveEventListener(string type, HtmlEventHandlerWithTarget<TextTrack> listener) {
		}

		public void RemoveEventListener(string type, HtmlEventHandlerWithTarget<TextTrack> listener, bool capture) {
		}

		public void RemoveEventListener(TextTrackEvents type, Action listener) {
		}

		public void RemoveEventListener(TextTrackEvents type, Action listener, bool capture) {
		}

		public void RemoveEventListener(TextTrackEvents type, HtmlEventHandler listener) {
		}

		public void RemoveEventListener(TextTrackEvents type, HtmlEventHandler listener, bool capture) {
		}

		public void RemoveEventListener(TextTrackEvents type, HtmlEventHandlerWithTarget<TextTrack> listener) {
		}

		public void RemoveEventListener(TextTrackEvents type, HtmlEventHandlerWithTarget<TextTrack> listener, bool capture) {
		}

		public void RemoveEventListener(TextTrackEvents type, IEventListener listener) {
		}

		public void RemoveEventListener(TextTrackEvents type, IEventListener listener, bool capture) {
		}
	}
}
