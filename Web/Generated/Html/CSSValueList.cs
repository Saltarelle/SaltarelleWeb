using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace System.Html {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class CSSValueList : CSSValue {
		internal CSSValueList() {
		}

		[IndexerName("__Item"), IntrinsicProperty]
		public CSSValue this[uint index] {
			get {
				return default(CSSValue);
			}
		}

		[EnumerateAsArray, InlineCode("new {$System.ArrayEnumerator}({this})")]
		public IEnumerator<CSSValue> GetEnumerator() {
			return null;
		}

		public CSSValue Item(uint index) {
			return default(CSSValue);
		}

		[IntrinsicProperty]
		public uint Length {
			get {
				return 0;
			}
		}
	}
}
