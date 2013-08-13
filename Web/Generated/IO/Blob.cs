using System.Collections.TypedArrays;
using System.Runtime.CompilerServices;

namespace System.IO {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class Blob {
		public Blob() {
		}

		public Blob(TypeOption<ArrayBuffer, ArrayBufferView, Blob, string>[] blobParts) {
		}

		public Blob(TypeOption<ArrayBuffer, ArrayBufferView, Blob, string>[] blobParts, BlobPropertyBag options) {
		}

		public void Close() {
		}

		[IntrinsicProperty]
		public ulong Size {
			get {
				return 0;
			}
		}

		public Blob Slice() {
			return default(Blob);
		}

		public Blob Slice(long start) {
			return default(Blob);
		}

		public Blob Slice(long start, long end) {
			return default(Blob);
		}

		public Blob Slice(long start, long end, string contentType) {
			return default(Blob);
		}

		[IntrinsicProperty]
		public string Type {
			get {
				return null;
			}
		}
	}
}
