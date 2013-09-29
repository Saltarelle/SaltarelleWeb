using System.Runtime.CompilerServices;

namespace System.Data.IndexedDB {
	[Imported, Serializable]
	public partial class OpenDBOptions {
		public StorageType Storage {
			get;
			set;
		}

		public ulong Version {
			get;
			set;
		}
	}
}
