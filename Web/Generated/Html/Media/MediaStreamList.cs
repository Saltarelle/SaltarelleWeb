using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace System.Html.Media {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true), ScriptName("Object")]
	public partial class MediaStreamList {
		internal MediaStreamList() {
		}

		[IndexerName("__Item"), IntrinsicProperty]
		public MediaStream this[uint index] {
			get {
				return default(MediaStream);
			}
		}

		[EnumerateAsArray, InlineCode("new {$System.ArrayEnumerator}({this})")]
		public IEnumerator<MediaStream> GetEnumerator() {
			return null;
		}

		[IntrinsicProperty]
		public uint Length {
			get {
				return 0;
			}
		}
	}
}
