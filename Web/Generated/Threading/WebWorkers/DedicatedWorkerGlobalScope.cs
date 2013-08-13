using System.Html;
using System.Runtime.CompilerServices;

namespace System.Threading.WebWorkers {
	[Imported, GlobalMethods]
	public static partial class DedicatedWorkerGlobalScope {
		public static void AddEventListener(string type, IEventListener listener) {
		}

		public static void AddEventListener(string type, IEventListener listener, bool capture) {
		}

		public static void AddEventListener(string type, IEventListener listener, bool capture, bool? wantsUntrusted) {
		}

		public static string Atob(string stringToEncode) {
			return null;
		}

		public static string Btoa(string encodedString) {
			return null;
		}

		public static void ClearInterval(int intervalId) {
		}

		public static void ClearTimeout(int timeoutId) {
		}

		public static void Close() {
		}

		public static bool DispatchEvent(Event @event) {
			return false;
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

		[IntrinsicProperty, ScriptName("onoffline")]
		public static HtmlEventHandler OnOffline {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("ononline")]
		public static HtmlEventHandler OnOnline {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		public static void PostMessage(object message) {
		}

		public static void PostMessage(object message, ITransferable[] transfer) {
		}

		public static void RemoveEventListener(string type, IEventListener listener) {
		}

		public static void RemoveEventListener(string type, IEventListener listener, bool capture) {
		}

		[IntrinsicProperty]
		public static WorkerGlobalScope Self {
			get {
				return default(WorkerGlobalScope);
			}
		}

		public static int SetInterval(Function func) {
			return 0;
		}

		[ExpandParams]
		public static int SetInterval(Function func, int delay, params object[] args) {
			return 0;
		}

		public static int SetInterval(string code) {
			return 0;
		}

		public static int SetInterval(string code, int delay) {
			return 0;
		}

		public static int SetTimeout(Function func) {
			return 0;
		}

		[ExpandParams]
		public static int SetTimeout(Function func, int delay, params object[] args) {
			return 0;
		}

		public static int SetTimeout(string code) {
			return 0;
		}

		public static int SetTimeout(string code, int delay) {
			return 0;
		}

		public static string ToNativeLineEndings(string @string) {
			return null;
		}
	}
}
