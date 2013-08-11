using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace System.IO {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class FileList {
		internal FileList() {
		}

		[IndexerName("__Item"), IntrinsicProperty]
		public File this[uint index] {
			get { return default(File); }
		}

		[EnumerateAsArray, InlineCode("new {$System.ArrayEnumerator}({this})")]
		public IEnumerator<File> GetEnumerator() {
			return default(IEnumerator<File>);
		}

		public File Item(uint index) {
			return default(File);
		}

		[IntrinsicProperty]
		public uint Length {
			get { return 0; }
		}
	}
}
