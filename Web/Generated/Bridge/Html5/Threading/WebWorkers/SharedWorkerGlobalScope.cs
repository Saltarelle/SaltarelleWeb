namespace Bridge.Html5.Threading.WebWorkers
{
	[External, GlobalMethods]
	public static partial class SharedWorkerGlobalScope
	{
		public static void AddEventListener(string type, HtmlEventHandlerWithTarget<WorkerGlobalScope> listener)
		{
		}

		public static void AddEventListener(string type, HtmlEventHandlerWithTarget<WorkerGlobalScope> listener, bool capture)
		{
		}

		public static void AddEventListener(string type, IEventListener listener)
		{
		}

		public static void AddEventListener(string type, IEventListener listener, bool capture)
		{
		}

		public static void AddEventListener(string type, IEventListener listener, bool capture, bool? wantsUntrusted)
		{
		}

		public static void AddEventListener(WorkerGlobalScopeEvents type, Action listener)
		{
		}

		public static void AddEventListener(WorkerGlobalScopeEvents type, Action listener, bool capture)
		{
		}

		public static void AddEventListener(WorkerGlobalScopeEvents type, HtmlEventHandler listener)
		{
		}

		public static void AddEventListener(WorkerGlobalScopeEvents type, HtmlEventHandler listener, bool capture)
		{
		}

		public static void AddEventListener(WorkerGlobalScopeEvents type, HtmlEventHandlerWithTarget<WorkerGlobalScope> listener)
		{
		}

		public static void AddEventListener(WorkerGlobalScopeEvents type, HtmlEventHandlerWithTarget<WorkerGlobalScope> listener, bool capture)
		{
		}

		public static void AddEventListener(WorkerGlobalScopeEvents type, IEventListener listener)
		{
		}

		public static void AddEventListener(WorkerGlobalScopeEvents type, IEventListener listener, bool capture)
		{
		}

		public static string Atob(string atob)
		{
			return null;
		}

		public static string Btoa(string btoa)
		{
			return null;
		}

		public static void Close()
		{
		}

		public static bool DispatchEvent(Event @event)
		{
			return false;
		}

		public static void Dump()
		{
		}

		public static void Dump(string str)
		{
		}

		[ExpandParams]
		public static void ImportScripts(params string[] urls)
		{
		}

		[FieldProperty]
		public static WorkerLocation Location
		{
			get {
				return default(WorkerLocation);
			}
		}

		[FieldProperty]
		public static string Name
		{
			get {
				return null;
			}
		}

		[FieldProperty]
		public static WorkerNavigator Navigator
		{
			get {
				return default(WorkerNavigator);
			}
		}

		[FieldProperty, Name("onclose")]
		public static HtmlEventHandler OnClose
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onconnect")]
		public static HtmlEventHandler OnConnect
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onerror")]
		public static ErrorEventHandler OnError
		{
			get {
				return default(ErrorEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onoffline")]
		public static HtmlEventHandler OnOffline
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("ononline")]
		public static HtmlEventHandler OnOnline
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		public static void RemoveEventListener(string type, HtmlEventHandlerWithTarget<WorkerGlobalScope> listener)
		{
		}

		public static void RemoveEventListener(string type, HtmlEventHandlerWithTarget<WorkerGlobalScope> listener, bool capture)
		{
		}

		public static void RemoveEventListener(string type, IEventListener listener)
		{
		}

		public static void RemoveEventListener(string type, IEventListener listener, bool capture)
		{
		}

		public static void RemoveEventListener(WorkerGlobalScopeEvents type, Action listener)
		{
		}

		public static void RemoveEventListener(WorkerGlobalScopeEvents type, Action listener, bool capture)
		{
		}

		public static void RemoveEventListener(WorkerGlobalScopeEvents type, HtmlEventHandler listener)
		{
		}

		public static void RemoveEventListener(WorkerGlobalScopeEvents type, HtmlEventHandler listener, bool capture)
		{
		}

		public static void RemoveEventListener(WorkerGlobalScopeEvents type, HtmlEventHandlerWithTarget<WorkerGlobalScope> listener)
		{
		}

		public static void RemoveEventListener(WorkerGlobalScopeEvents type, HtmlEventHandlerWithTarget<WorkerGlobalScope> listener, bool capture)
		{
		}

		public static void RemoveEventListener(WorkerGlobalScopeEvents type, IEventListener listener)
		{
		}

		public static void RemoveEventListener(WorkerGlobalScopeEvents type, IEventListener listener, bool capture)
		{
		}

		[FieldProperty]
		public static WorkerGlobalScope Self
		{
			get {
				return default(WorkerGlobalScope);
			}
		}

		public static string ToNativeLineEndings(string @string)
		{
			return null;
		}
	}
}
