namespace Bridge.Html5.Threading.WebWorkers
{
	[External, GlobalMethods]
	public static partial class SharedWorkerGlobalScope
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

		[FieldProperty]
		public static extern WorkerLocation Location
		{
			get;
		}

		[FieldProperty]
		public static extern string Name
		{
			get;
		}

		[FieldProperty]
		public static extern WorkerNavigator Navigator
		{
			get;
		}

		[FieldProperty, Name("onclose")]
		public static extern HtmlEventHandler OnClose
		{
			get;
			set;
		}

		[FieldProperty, Name("onconnect")]
		public static extern HtmlEventHandler OnConnect
		{
			get;
			set;
		}

		[FieldProperty, Name("onerror")]
		public static extern ErrorEventHandler OnError
		{
			get;
			set;
		}

		[FieldProperty, Name("onoffline")]
		public static extern HtmlEventHandler OnOffline
		{
			get;
			set;
		}

		[FieldProperty, Name("ononline")]
		public static extern HtmlEventHandler OnOnline
		{
			get;
			set;
		}

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

		[FieldProperty]
		public static extern WorkerGlobalScope Self
		{
			get;
		}

		public static extern string ToNativeLineEndings(string @string);
	}
}
