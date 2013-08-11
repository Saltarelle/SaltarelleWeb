using System.Html;
using System.Runtime.CompilerServices;

namespace System.IO {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class BlobEvent : Event {
		internal BlobEvent() {
		}

		public BlobEvent(string type) {
		}

		public BlobEvent(string type, BlobEventInit eventInitDict) {
		}

		[IntrinsicProperty]
		public Blob Data {
			get { return default(Blob); }
		}
	}
}
