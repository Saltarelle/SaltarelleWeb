using System.Html;
using System.Runtime.CompilerServices;

namespace System.Threading.WebWorkers {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class Worker : EventTarget {
		internal Worker() {
		}

		public Worker(string scriptURL) {
		}

		void AddEventListener(string type, HtmlEventHandlerWithTarget<Worker> listener) {
		}

		void AddEventListener(string type, HtmlEventHandlerWithTarget<Worker> listener, bool capture) {
		}

		[IntrinsicProperty, ScriptName("onerror")]
		public HtmlEventHandler OnError {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onmessage")]
		public HtmlEventHandler OnMessage {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		public void PostMessage(object message) {
		}

		public void PostMessage(object message, ITransferable[] transfer) {
		}

		void RemoveEventListener(string type, HtmlEventHandlerWithTarget<Worker> listener) {
		}

		void RemoveEventListener(string type, HtmlEventHandlerWithTarget<Worker> listener, bool capture) {
		}

		public void Terminate() {
		}
	}
}
