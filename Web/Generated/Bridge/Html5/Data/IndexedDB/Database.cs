namespace Bridge.Html5.Data.IndexedDB
{
	[Namespace("false"), External, Name("IDBDatabase")]
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

		public readonly string Name;

		public readonly DOMStringList ObjectStoreNames;

		[Name("onabort")]
		public HtmlEventHandler OnAbort;

		[Name("onerror")]
		public HtmlEventHandler OnError;

		[Name("onversionchange")]
		public HtmlEventHandler OnVersionchange;

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

		public readonly StorageType Storage;

		public extern Transaction Transaction(string storeName);

		public extern Transaction Transaction(string storeName, TransactionMode mode);

		public extern Transaction Transaction(string[] storeNames);

		public extern Transaction Transaction(string[] storeNames, TransactionMode mode);

		public readonly ulong Version;
	}
}
