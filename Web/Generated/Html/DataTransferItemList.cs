using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;

namespace System.Html {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class DataTransferItemList {
		internal DataTransferItemList() {
		}

		[IndexerName("__Item"), IntrinsicProperty]
		public DataTransferItem this[uint index] {
			get {
				return default(DataTransferItem);
			}
		}

		public DataTransferItem Add(File data) {
			return default(DataTransferItem);
		}

		public DataTransferItem Add(string data, string type) {
			return default(DataTransferItem);
		}

		public void Clear() {
		}

		[EnumerateAsArray, InlineCode("new {$System.ArrayEnumerator}({this})")]
		public IEnumerator<DataTransferItem> GetEnumerator() {
			return null;
		}

		[IntrinsicProperty]
		public uint Length {
			get {
				return 0;
			}
		}

		public void Remove(uint index) {
		}
	}
}
