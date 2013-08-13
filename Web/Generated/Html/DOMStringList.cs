using System.Collections;
using System.Runtime.CompilerServices;

namespace System.Html {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class DOMStringList {
		internal DOMStringList() {
		}

		[IndexerName("__Item"), IntrinsicProperty]
		public string this[uint index] {
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

		public string Item(uint index) {
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
