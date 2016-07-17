namespace Bridge.Html5.Threading.WebWorkers
{
	[Namespace("false"), External]
	public partial class Worker : EventTarget
	{
		internal extern Worker();

		public extern Worker(string scriptURL);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<Worker> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<Worker> listener, bool capture);

		public extern void AddEventListener(WorkerEvents type, Action listener);

		public extern void AddEventListener(WorkerEvents type, Action listener, bool capture);

		public extern void AddEventListener(WorkerEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(WorkerEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(WorkerEvents type, HtmlEventHandlerWithTarget<Worker> listener);

		public extern void AddEventListener(WorkerEvents type, HtmlEventHandlerWithTarget<Worker> listener, bool capture);

		public extern void AddEventListener(WorkerEvents type, IEventListener listener);

		public extern void AddEventListener(WorkerEvents type, IEventListener listener, bool capture);

		[Name("onerror")]
		public HtmlEventHandler OnError;

		[Name("onmessage")]
		public HtmlEventHandler OnMessage;

		public extern void PostMessage(object message);

		public extern void PostMessage(object message, object[] transfer);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<Worker> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<Worker> listener, bool capture);

		public extern void RemoveEventListener(WorkerEvents type, Action listener);

		public extern void RemoveEventListener(WorkerEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(WorkerEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(WorkerEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(WorkerEvents type, HtmlEventHandlerWithTarget<Worker> listener);

		public extern void RemoveEventListener(WorkerEvents type, HtmlEventHandlerWithTarget<Worker> listener, bool capture);

		public extern void RemoveEventListener(WorkerEvents type, IEventListener listener);

		public extern void RemoveEventListener(WorkerEvents type, IEventListener listener, bool capture);

		public extern void Terminate();
	}
}
