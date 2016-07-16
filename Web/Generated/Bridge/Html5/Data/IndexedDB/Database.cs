namespace Bridge.Html5.Data.IndexedDB
{
	[Namespace("false"), External(ObeysTypeSystem = true), Name("IDBDatabase")]
	public partial class Database : EventTarget
	{
		internal extern Database();

		public extern void AddEventListener(DatabaseEvents type, Action listener);

		public extern void AddEventListener(DatabaseEvents type, Action listener, bool capture);

		public extern void AddEventListener(DatabaseEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(DatabaseEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(DatabaseEvents type, HtmlEventHandlerWithTarget<Database> listener);

		public extern void AddEventListener(DatabaseEvents type, HtmlEventHandlerWithTarget<Database> listener, bool capture);

		public extern void AddEventListener(DatabaseEvents type, IEventListener listener);

		public extern void AddEventListener(DatabaseEvents type, IEventListener listener, bool capture);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<Database> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<Database> listener, bool capture);

		public extern void Close();

		public extern ObjectStore CreateObjectStore(string name);

		public extern ObjectStore CreateObjectStore(string name, ObjectStoreParameters optionalParameters);

		public extern void DeleteObjectStore(string name);

		[FieldProperty]
		public extern string Name
		{
			get;
		}

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

		[FieldProperty, Name("onerror")]
		public extern HtmlEventHandler OnError
		{
			get;
			set;
		}

		[FieldProperty, Name("onversionchange")]
		public extern HtmlEventHandler OnVersionchange
		{
			get;
			set;
		}

		public extern void RemoveEventListener(DatabaseEvents type, Action listener);

		public extern void RemoveEventListener(DatabaseEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(DatabaseEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(DatabaseEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(DatabaseEvents type, HtmlEventHandlerWithTarget<Database> listener);

		public extern void RemoveEventListener(DatabaseEvents type, HtmlEventHandlerWithTarget<Database> listener, bool capture);

		public extern void RemoveEventListener(DatabaseEvents type, IEventListener listener);

		public extern void RemoveEventListener(DatabaseEvents type, IEventListener listener, bool capture);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<Database> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<Database> listener, bool capture);

		[FieldProperty]
		public extern StorageType Storage
		{
			get;
		}

		public extern Transaction Transaction(string storeName);

		public extern Transaction Transaction(string storeName, TransactionMode mode);

		public extern Transaction Transaction(string[] storeNames);

		public extern Transaction Transaction(string[] storeNames, TransactionMode mode);

		[FieldProperty]
		public extern ulong Version
		{
			get;
		}
	}
}
