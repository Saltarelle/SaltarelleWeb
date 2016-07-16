namespace Bridge.Html5.Data.IndexedDB
{
	[Namespace("false"), External(ObeysTypeSystem = true), Name("IDBTransaction")]
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

		[FieldProperty]
		public extern Database Db
		{
			get;
		}

		[FieldProperty]
		public extern DOMError Error
		{
			get;
		}

		[FieldProperty]
		public extern TransactionMode Mode
		{
			get;
		}

		public extern ObjectStore ObjectStore(string name);

		[FieldProperty]
		public extern DOMStringList ObjectStoreNames
		{
			get;
		}

		[FieldProperty, Name("onabort")]
		public extern HtmlEventHandler OnAbort
		{
			get;
			set;
		}

		[FieldProperty, Name("oncomplete")]
		public extern HtmlEventHandler OnComplete
		{
			get;
			set;
		}

		[FieldProperty, Name("onerror")]
		public extern HtmlEventHandler OnError
		{
			get;
			set;
		}

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
