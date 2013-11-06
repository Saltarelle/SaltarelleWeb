using System.Html;
using System.Runtime.CompilerServices;

namespace System.Threading.WebWorkers {
	[Imported, GlobalMethods]
	public static partial class DedicatedWorkerGlobalScope {
		public static void AddEventListener(string type, HtmlEventHandlerWithTarget<WorkerGlobalScope> listener) {
		}

		public static void AddEventListener(string type, HtmlEventHandlerWithTarget<WorkerGlobalScope> listener, bool capture) {
		}

		public static void AddEventListener(string type, IEventListener listener) {
		}

		public static void AddEventListener(string type, IEventListener listener, bool capture) {
		}

		public static void AddEventListener(string type, IEventListener listener, bool capture, bool? wantsUntrusted) {
		}

		public static void AddEventListener(WorkerGlobalScopeEvents type, Action listener) {
		}

		public static void AddEventListener(WorkerGlobalScopeEvents type, Action listener, bool capture) {
		}

		public static void AddEventListener(WorkerGlobalScopeEvents type, HtmlEventHandler listener) {
		}

		public static void AddEventListener(WorkerGlobalScopeEvents type, HtmlEventHandler listener, bool capture) {
		}

		public static void AddEventListener(WorkerGlobalScopeEvents type, HtmlEventHandlerWithTarget<WorkerGlobalScope> listener) {
		}

		public static void AddEventListener(WorkerGlobalScopeEvents type, HtmlEventHandlerWithTarget<WorkerGlobalScope> listener, bool capture) {
		}

		public static void AddEventListener(WorkerGlobalScopeEvents type, IEventListener listener) {
		}

		public static void AddEventListener(WorkerGlobalScopeEvents type, IEventListener listener, bool capture) {
		}

		public static string Atob(string atob) {
			return null;
		}

		public static string Btoa(string btoa) {
			return null;
		}

		public static void ClearInterval(int handle) {
		}

		public static void ClearTimeout(int handle) {
		}

		public static void Close() {
		}

		public static bool DispatchEvent(Event @event) {
			return false;
		}

		public static void Dump() {
		}

		public static void Dump(string str) {
		}

		[ExpandParams]
		public static void ImportScripts(params string[] urls) {
		}

		[IntrinsicProperty]
		public static WorkerLocation Location {
			get {
				return default(WorkerLocation);
			}
		}

		[IntrinsicProperty]
		public static WorkerNavigator Navigator {
			get {
				return default(WorkerNavigator);
			}
		}

		[IntrinsicProperty, ScriptName("onclose")]
		public static HtmlEventHandler OnClose {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onerror")]
		public static ErrorEventHandler OnError {
			get {
				return default(ErrorEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onmessage")]
		public static HtmlEventHandler OnMessage {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		public static void PostMessage(object message) {
		}

		public static void PostMessage(object message, object[] transfer) {
		}

		public static void RemoveEventListener(string type, HtmlEventHandlerWithTarget<WorkerGlobalScope> listener) {
		}

		public static void RemoveEventListener(string type, HtmlEventHandlerWithTarget<WorkerGlobalScope> listener, bool capture) {
		}

		public static void RemoveEventListener(string type, IEventListener listener) {
		}

		public static void RemoveEventListener(string type, IEventListener listener, bool capture) {
		}

		public static void RemoveEventListener(WorkerGlobalScopeEvents type, Action listener) {
		}

		public static void RemoveEventListener(WorkerGlobalScopeEvents type, Action listener, bool capture) {
		}

		public static void RemoveEventListener(WorkerGlobalScopeEvents type, HtmlEventHandler listener) {
		}

		public static void RemoveEventListener(WorkerGlobalScopeEvents type, HtmlEventHandler listener, bool capture) {
		}

		public static void RemoveEventListener(WorkerGlobalScopeEvents type, HtmlEventHandlerWithTarget<WorkerGlobalScope> listener) {
		}

		public static void RemoveEventListener(WorkerGlobalScopeEvents type, HtmlEventHandlerWithTarget<WorkerGlobalScope> listener, bool capture) {
		}

		public static void RemoveEventListener(WorkerGlobalScopeEvents type, IEventListener listener) {
		}

		public static void RemoveEventListener(WorkerGlobalScopeEvents type, IEventListener listener, bool capture) {
		}

		[IntrinsicProperty]
		public static WorkerGlobalScope Self {
			get {
				return default(WorkerGlobalScope);
			}
		}

		public static int SetInterval(Function handler) {
			return 0;
		}

		[ExpandParams]
		public static int SetInterval(Function handler, int timeout, params object[] arguments) {
			return 0;
		}

		public static int SetInterval(string handler) {
			return 0;
		}

		public static int SetInterval(string handler, int timeout) {
			return 0;
		}

		public static int SetTimeout(Function handler) {
			return 0;
		}

		[ExpandParams]
		public static int SetTimeout(Function handler, int timeout, params object[] arguments) {
			return 0;
		}

		public static int SetTimeout(string handler) {
			return 0;
		}

		public static int SetTimeout(string handler, int timeout) {
			return 0;
		}

		public static string ToNativeLineEndings(string @string) {
			return null;
		}
	}
}
