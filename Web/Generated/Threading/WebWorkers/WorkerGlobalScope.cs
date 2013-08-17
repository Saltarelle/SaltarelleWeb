using System.Html;
using System.Runtime.CompilerServices;

namespace System.Threading.WebWorkers {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true), ScriptName("EventTarget")]
	public partial class WorkerGlobalScope : EventTarget, IWindowTimers, IWindowBase64 {
		internal WorkerGlobalScope() {
		}

		void AddEventListener(string type, HtmlEventHandlerWithTarget<WorkerGlobalScope> listener) {
		}

		void AddEventListener(string type, HtmlEventHandlerWithTarget<WorkerGlobalScope> listener, bool capture) {
		}

		public string Atob(string stringToEncode) {
			return null;
		}

		public string Btoa(string encodedString) {
			return null;
		}

		public void ClearInterval(int intervalId) {
		}

		public void ClearTimeout(int timeoutId) {
		}

		public void Close() {
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

		[IntrinsicProperty, ScriptName("onerror")]
		public ErrorEventHandler OnError {
			get {
				return default(ErrorEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onoffline")]
		public HtmlEventHandler OnOffline {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("ononline")]
		public HtmlEventHandler OnOnline {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		void RemoveEventListener(string type, HtmlEventHandlerWithTarget<WorkerGlobalScope> listener) {
		}

		void RemoveEventListener(string type, HtmlEventHandlerWithTarget<WorkerGlobalScope> listener, bool capture) {
		}

		[IntrinsicProperty]
		public WorkerGlobalScope Self {
			get {
				return default(WorkerGlobalScope);
			}
		}

		public int SetInterval(Function func) {
			return 0;
		}

		[ExpandParams]
		public int SetInterval(Function func, int delay, params object[] args) {
			return 0;
		}

		public int SetInterval(string code) {
			return 0;
		}

		public int SetInterval(string code, int delay) {
			return 0;
		}

		public int SetTimeout(Function func) {
			return 0;
		}

		[ExpandParams]
		public int SetTimeout(Function func, int delay, params object[] args) {
			return 0;
		}

		public int SetTimeout(string code) {
			return 0;
		}

		public int SetTimeout(string code, int delay) {
			return 0;
		}

		public string ToNativeLineEndings(string @string) {
			return null;
		}
	}
}
