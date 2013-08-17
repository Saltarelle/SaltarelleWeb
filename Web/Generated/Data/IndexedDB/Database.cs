using System.Html;
using System.Runtime.CompilerServices;

namespace System.Data.IndexedDB {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true), ScriptName("IDBDatabase")]
	public partial class Database : EventTarget {
		internal Database() {
		}

		void AddEventListener(string type, HtmlEventHandlerWithTarget<Database> listener) {
		}

		void AddEventListener(string type, HtmlEventHandlerWithTarget<Database> listener, bool capture) {
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

		void RemoveEventListener(string type, HtmlEventHandlerWithTarget<Database> listener) {
		}

		void RemoveEventListener(string type, HtmlEventHandlerWithTarget<Database> listener, bool capture) {
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
