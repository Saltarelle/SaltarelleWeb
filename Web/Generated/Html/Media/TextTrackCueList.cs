using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace System.Html.Media {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class TextTrackCueList {
		internal TextTrackCueList() {
		}

		[IndexerName("__Item"), IntrinsicProperty]
		public TextTrackCue this[uint index] {
			get { return default(TextTrackCue); }
		}

		public TextTrackCue GetCueById(string id) {
			return default(TextTrackCue);
		}

		[EnumerateAsArray, InlineCode("new {$System.ArrayEnumerator}({this})")]
		public IEnumerator<TextTrackCue> GetEnumerator() {
			return default(IEnumerator<TextTrackCue>);
		}

		[IntrinsicProperty]
		public uint Length {
			get { return 0; }
		}
	}
}
