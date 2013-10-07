using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace System.Html {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class DOMRectList {
		internal DOMRectList() {
		}

		[IndexerName("__Item"), IntrinsicProperty]
		public DOMRect this[uint index] {
			get {
				return default(DOMRect);
			}
		}

		[EnumerateAsArray, InlineCode("new {$System.ArrayEnumerator}({this})")]
		public IEnumerator<DOMRect> GetEnumerator() {
			return null;
		}

		public DOMRect Item(uint index) {
			return default(DOMRect);
		}

		[IntrinsicProperty]
		public uint Length {
			get {
				return 0;
			}
		}
	}
}
