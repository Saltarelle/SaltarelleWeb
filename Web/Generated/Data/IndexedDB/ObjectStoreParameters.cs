using System.Runtime.CompilerServices;

namespace System.Data.IndexedDB {
	[Imported, Serializable]
	public partial class ObjectStoreParameters {
		public bool AutoIncrement {
			get;
			set;
		}

		public object KeyPath {
			get;
			set;
		}
	}
}
