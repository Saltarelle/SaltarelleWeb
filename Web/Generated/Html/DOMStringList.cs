using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace System.Html {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class DOMStringList {
		internal DOMStringList() {
		}

		[IndexerName("__Item"), IntrinsicProperty]
		public string this[int index] {
			get {
				return null;
			}
		}

		public bool Contains(string @string) {
			return false;
		}

		[EnumerateAsArray, InlineCode("new {$System.ArrayEnumerator}({this})")]
		public IEnumerator<string> GetEnumerator() {
			return null;
		}

		public string Item(int index) {
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
