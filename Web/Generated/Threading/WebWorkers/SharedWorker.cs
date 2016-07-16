using System.Html;
using System.Net.Messaging;
using System.Runtime.CompilerServices;

namespace System.Threading.WebWorkers {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class SharedWorker : EventTarget {
		internal SharedWorker() {
		}

		public SharedWorker(string scriptURL) {
		}

		public SharedWorker(string scriptURL, string name) {
		}

		public void AddEventListener(SharedWorkerEvents type, Action listener) {
		}

		public void AddEventListener(SharedWorkerEvents type, Action listener, bool capture) {
		}

		public void AddEventListener(SharedWorkerEvents type, HtmlEventHandler listener) {
		}

		public void AddEventListener(SharedWorkerEvents type, HtmlEventHandler listener, bool capture) {
		}

		public void AddEventListener(SharedWorkerEvents type, HtmlEventHandlerWithTarget<SharedWorker> listener) {
		}

		public void AddEventListener(SharedWorkerEvents type, HtmlEventHandlerWithTarget<SharedWorker> listener, bool capture) {
		}

		public void AddEventListener(SharedWorkerEvents type, IEventListener listener) {
		}

		public void AddEventListener(SharedWorkerEvents type, IEventListener listener, bool capture) {
		}

		public void AddEventListener(string type, HtmlEventHandlerWithTarget<SharedWorker> listener) {
		}

		public void AddEventListener(string type, HtmlEventHandlerWithTarget<SharedWorker> listener, bool capture) {
		}

		[IntrinsicProperty, ScriptName("onerror")]
		public HtmlEventHandler OnError {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty]
		public MessagePort Port {
			get {
				return default(MessagePort);
			}
		}

		public void RemoveEventListener(SharedWorkerEvents type, Action listener) {
		}

		public void RemoveEventListener(SharedWorkerEvents type, Action listener, bool capture) {
		}

		public void RemoveEventListener(SharedWorkerEvents type, HtmlEventHandler listener) {
		}

		public void RemoveEventListener(SharedWorkerEvents type, HtmlEventHandler listener, bool capture) {
		}

		public void RemoveEventListener(SharedWorkerEvents type, HtmlEventHandlerWithTarget<SharedWorker> listener) {
		}

		public void RemoveEventListener(SharedWorkerEvents type, HtmlEventHandlerWithTarget<SharedWorker> listener, bool capture) {
		}

		public void RemoveEventListener(SharedWorkerEvents type, IEventListener listener) {
		}

		public void RemoveEventListener(SharedWorkerEvents type, IEventListener listener, bool capture) {
		}

		public void RemoveEventListener(string type, HtmlEventHandlerWithTarget<SharedWorker> listener) {
		}

		public void RemoveEventListener(string type, HtmlEventHandlerWithTarget<SharedWorker> listener, bool capture) {
		}
	}
}
