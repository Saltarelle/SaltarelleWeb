namespace Bridge.Html5.Threading.WebWorkers
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class WorkerGlobalScope : EventTarget, IWindowTimers, IWindowBase64
	{
		internal WorkerGlobalScope()
		{
		}

		public void AddEventListener(string type, HtmlEventHandlerWithTarget<WorkerGlobalScope> listener)
		{
		}

		public void AddEventListener(string type, HtmlEventHandlerWithTarget<WorkerGlobalScope> listener, bool capture)
		{
		}

		public void AddEventListener(WorkerGlobalScopeEvents type, Action listener)
		{
		}

		public void AddEventListener(WorkerGlobalScopeEvents type, Action listener, bool capture)
		{
		}

		public void AddEventListener(WorkerGlobalScopeEvents type, HtmlEventHandler listener)
		{
		}

		public void AddEventListener(WorkerGlobalScopeEvents type, HtmlEventHandler listener, bool capture)
		{
		}

		public void AddEventListener(WorkerGlobalScopeEvents type, HtmlEventHandlerWithTarget<WorkerGlobalScope> listener)
		{
		}

		public void AddEventListener(WorkerGlobalScopeEvents type, HtmlEventHandlerWithTarget<WorkerGlobalScope> listener, bool capture)
		{
		}

		public void AddEventListener(WorkerGlobalScopeEvents type, IEventListener listener)
		{
		}

		public void AddEventListener(WorkerGlobalScopeEvents type, IEventListener listener, bool capture)
		{
		}

		public string Atob(string atob)
		{
			return null;
		}

		public string Btoa(string btoa)
		{
			return null;
		}

		public void Close()
		{
		}

		public void Dump()
		{
		}

		public void Dump(string str)
		{
		}

		[ExpandParams]
		public void ImportScripts(params string[] urls)
		{
		}

		[FieldProperty]
		public WorkerLocation Location
		{
			get {
				return default(WorkerLocation);
			}
		}

		[FieldProperty]
		public WorkerNavigator Navigator
		{
			get {
				return default(WorkerNavigator);
			}
		}

		[FieldProperty, Name("onclose")]
		public HtmlEventHandler OnClose
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onerror")]
		public ErrorEventHandler OnError
		{
			get {
				return default(ErrorEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onoffline")]
		public HtmlEventHandler OnOffline
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("ononline")]
		public HtmlEventHandler OnOnline
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		public void RemoveEventListener(string type, HtmlEventHandlerWithTarget<WorkerGlobalScope> listener)
		{
		}

		public void RemoveEventListener(string type, HtmlEventHandlerWithTarget<WorkerGlobalScope> listener, bool capture)
		{
		}

		public void RemoveEventListener(WorkerGlobalScopeEvents type, Action listener)
		{
		}

		public void RemoveEventListener(WorkerGlobalScopeEvents type, Action listener, bool capture)
		{
		}

		public void RemoveEventListener(WorkerGlobalScopeEvents type, HtmlEventHandler listener)
		{
		}

		public void RemoveEventListener(WorkerGlobalScopeEvents type, HtmlEventHandler listener, bool capture)
		{
		}

		public void RemoveEventListener(WorkerGlobalScopeEvents type, HtmlEventHandlerWithTarget<WorkerGlobalScope> listener)
		{
		}

		public void RemoveEventListener(WorkerGlobalScopeEvents type, HtmlEventHandlerWithTarget<WorkerGlobalScope> listener, bool capture)
		{
		}

		public void RemoveEventListener(WorkerGlobalScopeEvents type, IEventListener listener)
		{
		}

		public void RemoveEventListener(WorkerGlobalScopeEvents type, IEventListener listener, bool capture)
		{
		}

		[FieldProperty]
		public WorkerGlobalScope Self
		{
			get {
				return default(WorkerGlobalScope);
			}
		}

		public string ToNativeLineEndings(string @string)
		{
			return null;
		}
	}
}
