using System.Collections;
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
	}
}
