using System.Collections;
using System.Runtime.CompilerServices;

namespace System.Html {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class TouchList {
		internal TouchList() {
		}

		[IndexerName("__Item"), IntrinsicProperty]
		public Touch this[uint index] {
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

		public Touch Item(uint index) {
			return default(Touch);
		}

		[IntrinsicProperty]
		public uint Length {
			get {
				return 0;
			}
		}
	}
}
