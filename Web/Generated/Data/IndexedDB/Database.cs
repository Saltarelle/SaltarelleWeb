using System.Html;
using System.Runtime.CompilerServices;

namespace System.Data.IndexedDB {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true), ScriptName("IDBDatabase")]
	public partial class Database : EventTarget {
		internal Database() {
		}

		public void AddEventListener(DatabaseEvents type, Action listener) {
		}

		public void AddEventListener(DatabaseEvents type, Action listener, bool capture) {
		}

		public void AddEventListener(DatabaseEvents type, HtmlEventHandler listener) {
		}

		public void AddEventListener(DatabaseEvents type, HtmlEventHandler listener, bool capture) {
		}

		public void AddEventListener(DatabaseEvents type, HtmlEventHandlerWithTarget<Database> listener) {
		}

		public void AddEventListener(DatabaseEvents type, HtmlEventHandlerWithTarget<Database> listener, bool capture) {
		}

		public void AddEventListener(DatabaseEvents type, IEventListener listener) {
		}

		public void AddEventListener(DatabaseEvents type, IEventListener listener, bool capture) {
		}

		public void AddEventListener(string type, HtmlEventHandlerWithTarget<Database> listener) {
		}

		public void AddEventListener(string type, HtmlEventHandlerWithTarget<Database> listener, bool capture) {
		}

		public void Close() {
		}

		public ObjectStore CreateObjectStore(string name) {
			return default(ObjectStore);
		}

		public ObjectStore CreateObjectStore(string name, ObjectStoreParameters optionalParameters) {
			return default(ObjectStore);
		}

		public void DeleteObjectStore(string name) {
		}

		[IntrinsicProperty]
		public string Name {
			get {
				return null;
			}
		}

		[IntrinsicProperty]
		public DOMStringList ObjectStoreNames {
			get {
				return default(DOMStringList);
			}
		}

		[IntrinsicProperty, ScriptName("onabort")]
		public HtmlEventHandler OnAbort {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onerror")]
		public HtmlEventHandler OnError {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onversionchange")]
		public HtmlEventHandler OnVersionchange {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		public void RemoveEventListener(DatabaseEvents type, Action listener) {
		}

		public void RemoveEventListener(DatabaseEvents type, Action listener, bool capture) {
		}

		public void RemoveEventListener(DatabaseEvents type, HtmlEventHandler listener) {
		}

		public void RemoveEventListener(DatabaseEvents type, HtmlEventHandler listener, bool capture) {
		}

		public void RemoveEventListener(DatabaseEvents type, HtmlEventHandlerWithTarget<Database> listener) {
		}

		public void RemoveEventListener(DatabaseEvents type, HtmlEventHandlerWithTarget<Database> listener, bool capture) {
		}

		public void RemoveEventListener(DatabaseEvents type, IEventListener listener) {
		}

		public void RemoveEventListener(DatabaseEvents type, IEventListener listener, bool capture) {
		}

		public void RemoveEventListener(string type, HtmlEventHandlerWithTarget<Database> listener) {
		}

		public void RemoveEventListener(string type, HtmlEventHandlerWithTarget<Database> listener, bool capture) {
		}

		[IntrinsicProperty]
		public StorageType Storage {
			get {
				return default(StorageType);
			}
		}

		public Transaction Transaction(string storeName) {
			return default(Transaction);
		}

		public Transaction Transaction(string storeName, TransactionMode mode) {
			return default(Transaction);
		}

		public Transaction Transaction(string[] storeNames) {
			return default(Transaction);
		}

		public Transaction Transaction(string[] storeNames, TransactionMode mode) {
			return default(Transaction);
		}

		[IntrinsicProperty]
		public ulong Version {
			get {
				return 0;
			}
		}
	}
}
