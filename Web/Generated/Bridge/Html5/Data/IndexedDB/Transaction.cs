namespace Bridge.Html5.Data.IndexedDB
{
	[Namespace(false), External, Name("IDBTransaction")]
	public partial class Transaction : EventTarget
	{
		internal extern Transaction();

		public extern void Abort();

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<Transaction> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<Transaction> listener, bool capture);

		public extern void AddEventListener(TransactionEvents type, Action listener);

		public extern void AddEventListener(TransactionEvents type, Action listener, bool capture);

		public extern void AddEventListener(TransactionEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(TransactionEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(TransactionEvents type, HtmlEventHandlerWithTarget<Transaction> listener);

		public extern void AddEventListener(TransactionEvents type, HtmlEventHandlerWithTarget<Transaction> listener, bool capture);

		public extern void AddEventListener(TransactionEvents type, IEventListener listener);

		public extern void AddEventListener(TransactionEvents type, IEventListener listener, bool capture);

		public readonly Database Db;

		public readonly DOMError Error;

		public readonly TransactionMode Mode;

		public extern ObjectStore ObjectStore(string name);

		public readonly DOMStringList ObjectStoreNames;

		[Name("onabort")]
		public HtmlEventHandler OnAbort;

		[Name("oncomplete")]
		public HtmlEventHandler OnComplete;

		[Name("onerror")]
		public HtmlEventHandler OnError;

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<Transaction> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<Transaction> listener, bool capture);

		public extern void RemoveEventListener(TransactionEvents type, Action listener);

		public extern void RemoveEventListener(TransactionEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(TransactionEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(TransactionEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(TransactionEvents type, HtmlEventHandlerWithTarget<Transaction> listener);

		public extern void RemoveEventListener(TransactionEvents type, HtmlEventHandlerWithTarget<Transaction> listener, bool capture);

		public extern void RemoveEventListener(TransactionEvents type, IEventListener listener);

		public extern void RemoveEventListener(TransactionEvents type, IEventListener listener, bool capture);
	}
}
