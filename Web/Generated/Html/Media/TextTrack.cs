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
	}
}
