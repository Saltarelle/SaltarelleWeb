using System.Html;
using System.Runtime.CompilerServices;

namespace System.Data.IndexedDB {
	[Imported, Serializable]
	public partial class VersionChangeEventInit : EventInit {
		public ulong? NewVersion {
			get;
			set;
		}

		public ulong OldVersion {
			get;
			set;
		}
	}
}
