using Bridge.Html5.Net.Messaging;

namespace Bridge.Html5.Threading.WebWorkers
{
	[Namespace("false"), External]
	public partial class SharedWorker : EventTarget
	{
		internal extern SharedWorker();

		public extern SharedWorker(string scriptURL);

		public extern SharedWorker(string scriptURL, string name);

		public extern void AddEventListener(SharedWorkerEvents type, Action listener);

		public extern void AddEventListener(SharedWorkerEvents type, Action listener, bool capture);

		public extern void AddEventListener(SharedWorkerEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(SharedWorkerEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(SharedWorkerEvents type, HtmlEventHandlerWithTarget<SharedWorker> listener);

		public extern void AddEventListener(SharedWorkerEvents type, HtmlEventHandlerWithTarget<SharedWorker> listener, bool capture);

		public extern void AddEventListener(SharedWorkerEvents type, IEventListener listener);

		public extern void AddEventListener(SharedWorkerEvents type, IEventListener listener, bool capture);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<SharedWorker> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<SharedWorker> listener, bool capture);

		[Name("onerror")]
		public HtmlEventHandler OnError;

		public readonly MessagePort Port;

		public extern void RemoveEventListener(SharedWorkerEvents type, Action listener);

		public extern void RemoveEventListener(SharedWorkerEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(SharedWorkerEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(SharedWorkerEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(SharedWorkerEvents type, HtmlEventHandlerWithTarget<SharedWorker> listener);

		public extern void RemoveEventListener(SharedWorkerEvents type, HtmlEventHandlerWithTarget<SharedWorker> listener, bool capture);

		public extern void RemoveEventListener(SharedWorkerEvents type, IEventListener listener);

		public extern void RemoveEventListener(SharedWorkerEvents type, IEventListener listener, bool capture);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<SharedWorker> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<SharedWorker> listener, bool capture);
	}
}
