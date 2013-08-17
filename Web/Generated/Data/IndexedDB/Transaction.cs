using System.Html;
using System.Runtime.CompilerServices;

namespace System.Data.IndexedDB {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true), ScriptName("IDBTransaction")]
	public partial class Transaction : EventTarget {
		internal Transaction() {
		}

		public void Abort() {
		}

		void AddEventListener(string type, HtmlEventHandlerWithTarget<Transaction> listener) {
		}

		void AddEventListener(string type, HtmlEventHandlerWithTarget<Transaction> listener, bool capture) {
		}

		[IntrinsicProperty]
		public Database Db {
			get {
				return default(Database);
			}
		}

		[IntrinsicProperty]
		public DOMError Error {
			get {
				return default(DOMError);
			}
		}

		[IntrinsicProperty]
		public TransactionMode Mode {
			get {
				return default(TransactionMode);
			}
		}

		public ObjectStore ObjectStore(string name) {
			return default(ObjectStore);
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

		[IntrinsicProperty, ScriptName("oncomplete")]
		public HtmlEventHandler OnComplete {
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

		void RemoveEventListener(string type, HtmlEventHandlerWithTarget<Transaction> listener) {
		}

		void RemoveEventListener(string type, HtmlEventHandlerWithTarget<Transaction> listener, bool capture) {
		}
	}
}
