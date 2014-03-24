using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace System.Html {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class MediaList {
		internal MediaList() {
		}

		[IndexerName("__Item"), IntrinsicProperty]
		public string this[int index] {
			get {
				return null;
			}
		}

		public void AppendMedium(string newMedium) {
		}

		public void DeleteMedium(string oldMedium) {
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

		[IntrinsicProperty]
		public string MediaText {
			get {
				return null;
			}
			set {
			}
		}
	}
}
