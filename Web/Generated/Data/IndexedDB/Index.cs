using System.Runtime.CompilerServices;

namespace System.Data.IndexedDB {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true), ScriptName("IDBIndex")]
	public partial class Index {
		internal Index() {
		}

		public Request Count(object key) {
			return default(Request);
		}

		public Request Get(object key) {
			return default(Request);
		}

		public Request GetKey(object key) {
			return default(Request);
		}

		[IntrinsicProperty]
		public object KeyPath {
			get {
				return null;
			}
		}

		[IntrinsicProperty]
		public bool MultiEntry {
			get {
				return false;
			}
		}

		[IntrinsicProperty]
		public string Name {
			get {
				return null;
			}
		}

		[IntrinsicProperty]
		public ObjectStore ObjectStore {
			get {
				return default(ObjectStore);
			}
		}

		public Request OpenCursor(object range) {
			return default(Request);
		}

		public Request OpenCursor(object range, CursorDirection direction) {
			return default(Request);
		}

		public Request OpenKeyCursor(object range) {
			return default(Request);
		}

		public Request OpenKeyCursor(object range, CursorDirection direction) {
			return default(Request);
		}

		[IntrinsicProperty]
		public string StoreName {
			get {
				return null;
			}
		}

		[IntrinsicProperty]
		public bool Unique {
			get {
				return false;
			}
		}
	}
}
