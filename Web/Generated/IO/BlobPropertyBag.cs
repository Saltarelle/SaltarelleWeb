using System.Runtime.CompilerServices;

namespace System.IO {
	[Imported, Serializable]
	public partial class BlobPropertyBag {
		public EndingTypes Endings {
			get;
			set;
		}

		public string Type {
			get;
			set;
		}
	}
}
