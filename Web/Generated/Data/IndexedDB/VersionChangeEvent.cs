using System.Html;
using System.Runtime.CompilerServices;

namespace System.Data.IndexedDB {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true), ScriptName("IDBVersionChangeEvent")]
	public partial class VersionChangeEvent : Event {
		internal VersionChangeEvent() {
		}

		public VersionChangeEvent(string type) {
		}

		public VersionChangeEvent(string type, VersionChangeEventInit eventInitDict) {
		}

		[IntrinsicProperty]
		public ulong? NewVersion {
			get { return null; }
		}

		[IntrinsicProperty]
		public ulong OldVersion {
			get { return 0; }
		}
	}
}
