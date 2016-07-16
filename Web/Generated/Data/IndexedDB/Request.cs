using System.Html;
using System.Runtime.CompilerServices;

namespace System.Data.IndexedDB {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true), ScriptName("IDBRequest")]
	public partial class Request : EventTarget {
		internal Request() {
		}

		public void AddEventListener(RequestEvents type, Action listener) {
		}

		public void AddEventListener(RequestEvents type, Action listener, bool capture) {
		}

		public void AddEventListener(RequestEvents type, HtmlEventHandler listener) {
		}

		public void AddEventListener(RequestEvents type, HtmlEventHandler listener, bool capture) {
		}

		public void AddEventListener(RequestEvents type, HtmlEventHandlerWithTarget<Request> listener) {
		}

		public void AddEventListener(RequestEvents type, HtmlEventHandlerWithTarget<Request> listener, bool capture) {
		}

		public void AddEventListener(RequestEvents type, IEventListener listener) {
		}

		public void AddEventListener(RequestEvents type, IEventListener listener, bool capture) {
		}

		public void AddEventListener(string type, HtmlEventHandlerWithTarget<Request> listener) {
		}

		public void AddEventListener(string type, HtmlEventHandlerWithTarget<Request> listener, bool capture) {
		}

		[IntrinsicProperty]
		public DOMError Error {
			get {
				return default(DOMError);
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

		[IntrinsicProperty, ScriptName("onsuccess")]
		public HtmlEventHandler OnSuccess {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty]
		public RequestReadyState ReadyState {
			get {
				return default(RequestReadyState);
			}
		}

		public void RemoveEventListener(RequestEvents type, Action listener) {
		}

		public void RemoveEventListener(RequestEvents type, Action listener, bool capture) {
		}

		public void RemoveEventListener(RequestEvents type, HtmlEventHandler listener) {
		}

		public void RemoveEventListener(RequestEvents type, HtmlEventHandler listener, bool capture) {
		}

		public void RemoveEventListener(RequestEvents type, HtmlEventHandlerWithTarget<Request> listener) {
		}

		public void RemoveEventListener(RequestEvents type, HtmlEventHandlerWithTarget<Request> listener, bool capture) {
		}

		public void RemoveEventListener(RequestEvents type, IEventListener listener) {
		}

		public void RemoveEventListener(RequestEvents type, IEventListener listener, bool capture) {
		}

		public void RemoveEventListener(string type, HtmlEventHandlerWithTarget<Request> listener) {
		}

		public void RemoveEventListener(string type, HtmlEventHandlerWithTarget<Request> listener, bool capture) {
		}

		[IntrinsicProperty]
		public object Result {
			get {
				return null;
			}
		}

		[IntrinsicProperty]
		public TypeOption<ObjectStore, Index, Cursor> Source {
			get {
				return default(TypeOption<ObjectStore, Index, Cursor>);
			}
		}

		[IntrinsicProperty]
		public Transaction Transaction {
			get {
				return default(Transaction);
			}
		}
	}
}
