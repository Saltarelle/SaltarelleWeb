using System.Runtime.CompilerServices;

namespace System.Data.IndexedDB {
	[Imported, Serializable]
	public partial class ObjectStoreParameters {
		public bool AutoIncrement {
			get { return false; }
			set { }
		}

		public object KeyPath {
			get { return null; }
			set { }
		}
	}
}
