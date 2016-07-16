using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace System.Html {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class TouchList {
		internal TouchList() {
		}

		[IndexerName("__Item"), IntrinsicProperty]
		public Touch this[int index] {
			get {
				return default(Touch);
			}
		}

		[EnumerateAsArray, InlineCode("new {$System.ArrayEnumerator}({this})")]
		public IEnumerator<Touch> GetEnumerator() {
			return null;
		}

		public Touch IdentifiedTouch(int identifier) {
			return default(Touch);
		}

		public Touch Item(int index) {
			return default(Touch);
		}

		[IntrinsicProperty]
		public int Length {
			get {
				return 0;
			}
		}
	}
}
