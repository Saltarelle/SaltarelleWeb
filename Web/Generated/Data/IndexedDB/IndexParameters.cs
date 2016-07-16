using System.Runtime.CompilerServices;

namespace System.Data.IndexedDB {
	[Imported, Serializable]
	public partial class IndexParameters {
		public bool MultiEntry {
			get;
			set;
		}

		public bool Unique {
			get;
			set;
		}
	}
}
