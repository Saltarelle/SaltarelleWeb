using System.Html;
using System.Runtime.CompilerServices;

namespace System.Data.IndexedDB {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true), ScriptName("IDBObjectStore")]
	public partial class ObjectStore {
		internal ObjectStore() {
		}

		public Request Add(object value) {
			return default(Request);
		}

		public Request Add(object value, object key) {
			return default(Request);
		}

		[IntrinsicProperty]
		public bool AutoIncrement {
			get { return false; }
		}

		public Request Clear() {
			return default(Request);
		}

		public Request Count() {
			return default(Request);
		}

		public Request Count(object key) {
			return default(Request);
		}

		public Index CreateIndex(string name, string keyPath) {
			return default(Index);
		}

		public Index CreateIndex(string name, string keyPath, IndexParameters optionalParameters) {
			return default(Index);
		}

		public Index CreateIndex(string name, string[] keyPath) {
			return default(Index);
		}

		public Index CreateIndex(string name, string[] keyPath, IndexParameters optionalParameters) {
			return default(Index);
		}

		public Request Delete(object key) {
			return default(Request);
		}

		public void DeleteIndex(string indexName) {
		}

		public Request Get(object key) {
			return default(Request);
		}

		public Index Index(string name) {
			return default(Index);
		}

		[IntrinsicProperty]
		public DOMStringList IndexNames {
			get { return default(DOMStringList); }
		}

		[IntrinsicProperty]
		public object KeyPath {
			get { return null; }
		}

		[IntrinsicProperty]
		public string Name {
			get { return null; }
		}

		public Request OpenCursor() {
			return default(Request);
		}

		public Request OpenCursor(object range) {
			return default(Request);
		}

		public Request OpenCursor(object range, CursorDirection direction) {
			return default(Request);
		}

		public Request Put(object value) {
			return default(Request);
		}

		public Request Put(object value, object key) {
			return default(Request);
		}

		[IntrinsicProperty]
		public Transaction Transaction {
			get { return default(Transaction); }
		}
	}
}
