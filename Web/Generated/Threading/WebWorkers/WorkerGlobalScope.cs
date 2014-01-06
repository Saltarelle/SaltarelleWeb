using System.Html;
using System.Runtime.CompilerServices;

namespace System.Threading.WebWorkers {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class WorkerGlobalScope : EventTarget, IWindowTimers, IWindowBase64 {
		internal WorkerGlobalScope() {
		}

		public void AddEventListener(string type, HtmlEventHandlerWithTarget<WorkerGlobalScope> listener) {
		}

		public void AddEventListener(string type, HtmlEventHandlerWithTarget<WorkerGlobalScope> listener, bool capture) {
		}

		public void AddEventListener(WorkerGlobalScopeEvents type, Action listener) {
		}

		public void AddEventListener(WorkerGlobalScopeEvents type, Action listener, bool capture) {
		}

		public void AddEventListener(WorkerGlobalScopeEvents type, HtmlEventHandler listener) {
		}

		public void AddEventListener(WorkerGlobalScopeEvents type, HtmlEventHandler listener, bool capture) {
		}

		public void AddEventListener(WorkerGlobalScopeEvents type, HtmlEventHandlerWithTarget<WorkerGlobalScope> listener) {
		}

		public void AddEventListener(WorkerGlobalScopeEvents type, HtmlEventHandlerWithTarget<WorkerGlobalScope> listener, bool capture) {
		}

		public void AddEventListener(WorkerGlobalScopeEvents type, IEventListener listener) {
		}

		public void AddEventListener(WorkerGlobalScopeEvents type, IEventListener listener, bool capture) {
		}

		public string Atob(string atob) {
			return null;
		}

		public string Btoa(string btoa) {
			return null;
		}

		public void ClearInterval(int handle) {
		}

		public void ClearTimeout(int handle) {
		}

		public void Close() {
		}

		public void Dump() {
		}

		public void Dump(string str) {
		}

		[ExpandParams]
		public void ImportScripts(params string[] urls) {
		}

		[IntrinsicProperty]
		public WorkerLocation Location {
			get {
				return default(WorkerLocation);
			}
		}

		[IntrinsicProperty]
		public WorkerNavigator Navigator {
			get {
				return default(WorkerNavigator);
			}
		}

		[IntrinsicProperty, ScriptName("onclose")]
		public HtmlEventHandler OnClose {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onerror")]
		public ErrorEventHandler OnError {
			get {
				return default(ErrorEventHandler);
			}
			set {
			}
		}

		public void RemoveEventListener(string type, HtmlEventHandlerWithTarget<WorkerGlobalScope> listener) {
		}

		public void RemoveEventListener(string type, HtmlEventHandlerWithTarget<WorkerGlobalScope> listener, bool capture) {
		}

		public void RemoveEventListener(WorkerGlobalScopeEvents type, Action listener) {
		}

		public void RemoveEventListener(WorkerGlobalScopeEvents type, Action listener, bool capture) {
		}

		public void RemoveEventListener(WorkerGlobalScopeEvents type, HtmlEventHandler listener) {
		}

		public void RemoveEventListener(WorkerGlobalScopeEvents type, HtmlEventHandler listener, bool capture) {
		}

		public void RemoveEventListener(WorkerGlobalScopeEvents type, HtmlEventHandlerWithTarget<WorkerGlobalScope> listener) {
		}

		public void RemoveEventListener(WorkerGlobalScopeEvents type, HtmlEventHandlerWithTarget<WorkerGlobalScope> listener, bool capture) {
		}

		public void RemoveEventListener(WorkerGlobalScopeEvents type, IEventListener listener) {
		}

		public void RemoveEventListener(WorkerGlobalScopeEvents type, IEventListener listener, bool capture) {
		}

		[IntrinsicProperty]
		public WorkerGlobalScope Self {
			get {
				return default(WorkerGlobalScope);
			}
		}

		public string ToNativeLineEndings(string @string) {
			return null;
		}
	}
}
