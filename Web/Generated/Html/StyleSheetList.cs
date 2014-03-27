using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace System.Html {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class StyleSheetList {
		internal StyleSheetList() {
		}

		[IndexerName("__Item"), IntrinsicProperty]
		public StyleSheet this[int index] {
			get {
				return default(StyleSheet);
			}
		}

		[EnumerateAsArray, InlineCode("new {$System.ArrayEnumerator}({this})")]
		public IEnumerator<StyleSheet> GetEnumerator() {
			return null;
		}

		public StyleSheet Item(int index) {
			return default(StyleSheet);
		}

		[IntrinsicProperty]
		public int Length {
			get {
				return 0;
			}
		}
	}
}
