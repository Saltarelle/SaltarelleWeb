using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace System.Html {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class CSSValueList : CSSValue {
		internal CSSValueList() {
		}

		[IndexerName("__Item"), IntrinsicProperty]
		public CSSValue this[int index] {
			get {
				return default(CSSValue);
			}
		}

		[EnumerateAsArray, InlineCode("new {$System.ArrayEnumerator}({this})")]
		public IEnumerator<CSSValue> GetEnumerator() {
			return null;
		}

		public CSSValue Item(int index) {
			return default(CSSValue);
		}

		[IntrinsicProperty]
		public int Length {
			get {
				return 0;
			}
		}
	}
}
