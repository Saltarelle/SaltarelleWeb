using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace System.Html.Media {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class TextTrackCueList {
		internal TextTrackCueList() {
		}

		[IndexerName("__Item"), IntrinsicProperty]
		public VTTCue this[int index] {
			get {
				return default(VTTCue);
			}
		}

		public VTTCue GetCueById(string id) {
			return default(VTTCue);
		}

		[EnumerateAsArray, InlineCode("new {$System.ArrayEnumerator}({this})")]
		public IEnumerator<VTTCue> GetEnumerator() {
			return null;
		}

		[IntrinsicProperty]
		public int Length {
			get {
				return 0;
			}
		}
	}
}
