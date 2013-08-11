using System.Collections.TypedArrays;
using System.Runtime.CompilerServices;

namespace System.IO {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class FileReaderSync {
		public FileReaderSync() {
		}

		public ArrayBuffer ReadAsArrayBuffer(Blob blob) {
			return default(ArrayBuffer);
		}

		public string ReadAsBinaryString(Blob blob) {
			return null;
		}

		public string ReadAsDataURL(Blob blob) {
			return null;
		}

		public string ReadAsText(Blob blob) {
			return null;
		}

		public string ReadAsText(Blob blob, string encoding) {
			return null;
		}
	}
}
