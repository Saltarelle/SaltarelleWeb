namespace Bridge.Html5.Threading.WebWorkers
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class WorkerGlobalScope : EventTarget, IWindowTimers, IWindowBase64
	{
		internal extern WorkerGlobalScope();

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<WorkerGlobalScope> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<WorkerGlobalScope> listener, bool capture);

		public extern void AddEventListener(WorkerGlobalScopeEvents type, Action listener);

		public extern void AddEventListener(WorkerGlobalScopeEvents type, Action listener, bool capture);

		public extern void AddEventListener(WorkerGlobalScopeEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(WorkerGlobalScopeEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(WorkerGlobalScopeEvents type, HtmlEventHandlerWithTarget<WorkerGlobalScope> listener);

		public extern void AddEventListener(WorkerGlobalScopeEvents type, HtmlEventHandlerWithTarget<WorkerGlobalScope> listener, bool capture);

		public extern void AddEventListener(WorkerGlobalScopeEvents type, IEventListener listener);

		public extern void AddEventListener(WorkerGlobalScopeEvents type, IEventListener listener, bool capture);

		public extern string Atob(string atob);

		public extern string Btoa(string btoa);

		public extern void Close();

		public extern void Dump();

		public extern void Dump(string str);

		[ExpandParams]
		public extern void ImportScripts(params string[] urls);

		public readonly WorkerLocation Location;

		public readonly WorkerNavigator Navigator;

		[Name("onclose")]
		public HtmlEventHandler OnClose;

		[Name("onerror")]
		public ErrorEventHandler OnError;

		[Name("onoffline")]
		public HtmlEventHandler OnOffline;

		[Name("ononline")]
		public HtmlEventHandler OnOnline;

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<WorkerGlobalScope> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<WorkerGlobalScope> listener, bool capture);

		public extern void RemoveEventListener(WorkerGlobalScopeEvents type, Action listener);

		public extern void RemoveEventListener(WorkerGlobalScopeEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(WorkerGlobalScopeEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(WorkerGlobalScopeEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(WorkerGlobalScopeEvents type, HtmlEventHandlerWithTarget<WorkerGlobalScope> listener);

		public extern void RemoveEventListener(WorkerGlobalScopeEvents type, HtmlEventHandlerWithTarget<WorkerGlobalScope> listener, bool capture);

		public extern void RemoveEventListener(WorkerGlobalScopeEvents type, IEventListener listener);

		public extern void RemoveEventListener(WorkerGlobalScopeEvents type, IEventListener listener, bool capture);

		public readonly WorkerGlobalScope Self;

		public extern string ToNativeLineEndings(string @string);
	}
}
