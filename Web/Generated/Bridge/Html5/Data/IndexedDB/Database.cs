namespace Bridge.Html5.Data.IndexedDB
{
	[Namespace("false"), External(ObeysTypeSystem = true), Name("IDBDatabase")]
	public partial class Database : EventTarget
	{
		internal Database()
		{
		}

		public void AddEventListener(DatabaseEvents type, Action listener)
		{
		}

		public void AddEventListener(DatabaseEvents type, Action listener, bool capture)
		{
		}

		public void AddEventListener(DatabaseEvents type, HtmlEventHandler listener)
		{
		}

		public void AddEventListener(DatabaseEvents type, HtmlEventHandler listener, bool capture)
		{
		}

		public void AddEventListener(DatabaseEvents type, HtmlEventHandlerWithTarget<Database> listener)
		{
		}

		public void AddEventListener(DatabaseEvents type, HtmlEventHandlerWithTarget<Database> listener, bool capture)
		{
		}

		public void AddEventListener(DatabaseEvents type, IEventListener listener)
		{
		}

		public void AddEventListener(DatabaseEvents type, IEventListener listener, bool capture)
		{
		}

		public void AddEventListener(string type, HtmlEventHandlerWithTarget<Database> listener)
		{
		}

		public void AddEventListener(string type, HtmlEventHandlerWithTarget<Database> listener, bool capture)
		{
		}

		public void Close()
		{
		}

		public ObjectStore CreateObjectStore(string name)
		{
			return default(ObjectStore);
		}

		public ObjectStore CreateObjectStore(string name, ObjectStoreParameters optionalParameters)
		{
			return default(ObjectStore);
		}

		public void DeleteObjectStore(string name)
		{
		}

		[FieldProperty]
		public string Name
		{
			get {
				return null;
			}
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

		[FieldProperty, Name("onerror")]
		public HtmlEventHandler OnError
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onversionchange")]
		public HtmlEventHandler OnVersionchange
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		public void RemoveEventListener(DatabaseEvents type, Action listener)
		{
		}

		public void RemoveEventListener(DatabaseEvents type, Action listener, bool capture)
		{
		}

		public void RemoveEventListener(DatabaseEvents type, HtmlEventHandler listener)
		{
		}

		public void RemoveEventListener(DatabaseEvents type, HtmlEventHandler listener, bool capture)
		{
		}

		public void RemoveEventListener(DatabaseEvents type, HtmlEventHandlerWithTarget<Database> listener)
		{
		}

		public void RemoveEventListener(DatabaseEvents type, HtmlEventHandlerWithTarget<Database> listener, bool capture)
		{
		}

		public void RemoveEventListener(DatabaseEvents type, IEventListener listener)
		{
		}

		public void RemoveEventListener(DatabaseEvents type, IEventListener listener, bool capture)
		{
		}

		public void RemoveEventListener(string type, HtmlEventHandlerWithTarget<Database> listener)
		{
		}

		public void RemoveEventListener(string type, HtmlEventHandlerWithTarget<Database> listener, bool capture)
		{
		}

		[FieldProperty]
		public StorageType Storage
		{
			get {
				return default(StorageType);
			}
		}

		public Transaction Transaction(string storeName)
		{
			return default(Transaction);
		}

		public Transaction Transaction(string storeName, TransactionMode mode)
		{
			return default(Transaction);
		}

		public Transaction Transaction(string[] storeNames)
		{
			return default(Transaction);
		}

		public Transaction Transaction(string[] storeNames, TransactionMode mode)
		{
			return default(Transaction);
		}

		[FieldProperty]
		public ulong Version
		{
			get {
				return 0;
			}
		}
	}
}
