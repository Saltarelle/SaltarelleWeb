using System.Runtime.CompilerServices;

namespace System.Data.IndexedDB {
	[Imported, Serializable]
	public partial class IndexParameters {
		public bool MultiEntry {
			get { return false; }
			set { }
		}

		public bool Unique {
			get { return false; }
			set { }
		}
	}
}
