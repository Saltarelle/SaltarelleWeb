using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace System.IO {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class FileList {
		internal FileList() {
		}

		[IndexerName("__Item"), IntrinsicProperty]
		public File this[int index] {
			get {
				return default(File);
			}
		}

		[EnumerateAsArray, InlineCode("new {$System.ArrayEnumerator}({this})")]
		public IEnumerator<File> GetEnumerator() {
			return null;
		}

		public File Item(int index) {
			return default(File);
		}

		[IntrinsicProperty]
		public int Length {
			get {
				return 0;
			}
		}
	}
}
