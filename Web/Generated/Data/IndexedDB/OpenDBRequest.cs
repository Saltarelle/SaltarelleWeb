using System.Html;
using System.Runtime.CompilerServices;

namespace System.Data.IndexedDB {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true), ScriptName("IDBOpenDBRequest")]
	public partial class OpenDBRequest : Request {
		internal OpenDBRequest() {
		}

		void AddEventListener(string type, HtmlEventHandlerWithTarget<OpenDBRequest> listener) {
		}

		void AddEventListener(string type, HtmlEventHandlerWithTarget<OpenDBRequest> listener, bool capture) {
		}

		[IntrinsicProperty, ScriptName("onblocked")]
		public HtmlEventHandler OnBlocked {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onupgradeneeded")]
		public HtmlEventHandler OnUpgradeneeded {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		void RemoveEventListener(string type, HtmlEventHandlerWithTarget<OpenDBRequest> listener) {
		}

		void RemoveEventListener(string type, HtmlEventHandlerWithTarget<OpenDBRequest> listener, bool capture) {
		}
	}
}
