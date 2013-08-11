using System.Runtime.CompilerServices;

namespace System.IO {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class File : Blob {
		internal File() {
		}

		[IntrinsicProperty]
		public DateTime LastModifiedDate {
			get { return default(DateTime); }
		}

		[IntrinsicProperty]
		public string Name {
			get { return null; }
		}
	}
}
