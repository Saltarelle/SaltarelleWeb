namespace Bridge.Html5.Threading.WebWorkers
{
	[External, GlobalMethods]
	public static partial class DedicatedWorkerGlobalScope
	{
		public static extern void AddEventListener(string type, HtmlEventHandlerWithTarget<WorkerGlobalScope> listener);

		public static extern void AddEventListener(string type, HtmlEventHandlerWithTarget<WorkerGlobalScope> listener, bool capture);

		public static extern void AddEventListener(string type, IEventListener listener);

		public static extern void AddEventListener(string type, IEventListener listener, bool capture);

		public static extern void AddEventListener(string type, IEventListener listener, bool capture, bool? wantsUntrusted);

		public static extern void AddEventListener(WorkerGlobalScopeEvents type, Action listener);

		public static extern void AddEventListener(WorkerGlobalScopeEvents type, Action listener, bool capture);

		public static extern void AddEventListener(WorkerGlobalScopeEvents type, HtmlEventHandler listener);

		public static extern void AddEventListener(WorkerGlobalScopeEvents type, HtmlEventHandler listener, bool capture);

		public static extern void AddEventListener(WorkerGlobalScopeEvents type, HtmlEventHandlerWithTarget<WorkerGlobalScope> listener);

		public static extern void AddEventListener(WorkerGlobalScopeEvents type, HtmlEventHandlerWithTarget<WorkerGlobalScope> listener, bool capture);

		public static extern void AddEventListener(WorkerGlobalScopeEvents type, IEventListener listener);

		public static extern void AddEventListener(WorkerGlobalScopeEvents type, IEventListener listener, bool capture);

		public static extern string Atob(string atob);

		public static extern string Btoa(string btoa);

		public static extern void Close();

		public static extern bool DispatchEvent(Event @event);

		public static extern void Dump();

		public static extern void Dump(string str);

		[ExpandParams]
		public static extern void ImportScripts(params string[] urls);

		public static readonly WorkerLocation Location;

		public static readonly WorkerNavigator Navigator;

		[Name("onclose")]
		public static HtmlEventHandler OnClose;

		[Name("onerror")]
		public static ErrorEventHandler OnError;

		[Name("onmessage")]
		public static HtmlEventHandler OnMessage;

		[Name("onoffline")]
		public static HtmlEventHandler OnOffline;

		[Name("ononline")]
		public static HtmlEventHandler OnOnline;

		public static extern void PostMessage(object message);

		public static extern void PostMessage(object message, object[] transfer);

		public static extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<WorkerGlobalScope> listener);

		public static extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<WorkerGlobalScope> listener, bool capture);

		public static extern void RemoveEventListener(string type, IEventListener listener);

		public static extern void RemoveEventListener(string type, IEventListener listener, bool capture);

		public static extern void RemoveEventListener(WorkerGlobalScopeEvents type, Action listener);

		public static extern void RemoveEventListener(WorkerGlobalScopeEvents type, Action listener, bool capture);

		public static extern void RemoveEventListener(WorkerGlobalScopeEvents type, HtmlEventHandler listener);

		public static extern void RemoveEventListener(WorkerGlobalScopeEvents type, HtmlEventHandler listener, bool capture);

		public static extern void RemoveEventListener(WorkerGlobalScopeEvents type, HtmlEventHandlerWithTarget<WorkerGlobalScope> listener);

		public static extern void RemoveEventListener(WorkerGlobalScopeEvents type, HtmlEventHandlerWithTarget<WorkerGlobalScope> listener, bool capture);

		public static extern void RemoveEventListener(WorkerGlobalScopeEvents type, IEventListener listener);

		public static extern void RemoveEventListener(WorkerGlobalScopeEvents type, IEventListener listener, bool capture);

		public static readonly WorkerGlobalScope Self;

		public static extern string ToNativeLineEndings(string @string);
	}
}
