namespace Bridge.Html5.Data.IndexedDB
{
	[Namespace("false"), External(ObeysTypeSystem = true), Name("IDBTransaction")]
	public partial class Transaction : EventTarget
	{
		internal Transaction()
		{
		}

		public void Abort()
		{
		}

		public void AddEventListener(string type, HtmlEventHandlerWithTarget<Transaction> listener)
		{
		}

		public void AddEventListener(string type, HtmlEventHandlerWithTarget<Transaction> listener, bool capture)
		{
		}

		public void AddEventListener(TransactionEvents type, Action listener)
		{
		}

		public void AddEventListener(TransactionEvents type, Action listener, bool capture)
		{
		}

		public void AddEventListener(TransactionEvents type, HtmlEventHandler listener)
		{
		}

		public void AddEventListener(TransactionEvents type, HtmlEventHandler listener, bool capture)
		{
		}

		public void AddEventListener(TransactionEvents type, HtmlEventHandlerWithTarget<Transaction> listener)
		{
		}

		public void AddEventListener(TransactionEvents type, HtmlEventHandlerWithTarget<Transaction> listener, bool capture)
		{
		}

		public void AddEventListener(TransactionEvents type, IEventListener listener)
		{
		}

		public void AddEventListener(TransactionEvents type, IEventListener listener, bool capture)
		{
		}

		[FieldProperty]
		public Database Db
		{
			get {
				return default(Database);
			}
		}

		[FieldProperty]
		public DOMError Error
		{
			get {
				return default(DOMError);
			}
		}

		[FieldProperty]
		public TransactionMode Mode
		{
			get {
				return default(TransactionMode);
			}
		}

		public ObjectStore ObjectStore(string name)
		{
			return default(ObjectStore);
		}

		[FieldProperty]
		public DOMStringList ObjectStoreNames
		{
			get {
				return default(DOMStringList);
			}
		}

		[FieldProperty, Name("onabort")]
		public HtmlEventHandler OnAbort
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("oncomplete")]
		public HtmlEventHandler OnComplete
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onerror")]
		public HtmlEventHandler OnError
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		public void RemoveEventListener(string type, HtmlEventHandlerWithTarget<Transaction> listener)
		{
		}

		public void RemoveEventListener(string type, HtmlEventHandlerWithTarget<Transaction> listener, bool capture)
		{
		}

		public void RemoveEventListener(TransactionEvents type, Action listener)
		{
		}

		public void RemoveEventListener(TransactionEvents type, Action listener, bool capture)
		{
		}

		public void RemoveEventListener(TransactionEvents type, HtmlEventHandler listener)
		{
		}

		public void RemoveEventListener(TransactionEvents type, HtmlEventHandler listener, bool capture)
		{
		}

		public void RemoveEventListener(TransactionEvents type, HtmlEventHandlerWithTarget<Transaction> listener)
		{
		}

		public void RemoveEventListener(TransactionEvents type, HtmlEventHandlerWithTarget<Transaction> listener, bool capture)
		{
		}

		public void RemoveEventListener(TransactionEvents type, IEventListener listener)
		{
		}

		public void RemoveEventListener(TransactionEvents type, IEventListener listener, bool capture)
		{
		}
	}
}
