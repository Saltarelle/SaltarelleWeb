using System.Html;
using System.Runtime.CompilerServices;

namespace System.IO {
	[Imported, Serializable]
	public partial class BlobEventInit : EventInit {
		public Blob Data {
			get;
			set;
		}
	}
}
