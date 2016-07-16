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

		[FieldProperty]
		public extern WorkerLocation Location
		{
			get;
		}

		[FieldProperty]
		public extern WorkerNavigator Navigator
		{
			get;
		}

		[FieldProperty, Name("onclose")]
		public extern HtmlEventHandler OnClose
		{
			get;
			set;
		}

		[FieldProperty, Name("onerror")]
		public extern ErrorEventHandler OnError
		{
			get;
			set;
		}

		[FieldProperty, Name("onoffline")]
		public extern HtmlEventHandler OnOffline
		{
			get;
			set;
		}

		[FieldProperty, Name("ononline")]
		public extern HtmlEventHandler OnOnline
		{
			get;
			set;
		}

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

		[FieldProperty]
		public extern WorkerGlobalScope Self
		{
			get;
		}

		public extern string ToNativeLineEndings(string @string);
	}
}
