namespace Bridge.Html5.Data.IndexedDB
{
	[Namespace("false"), External(ObeysTypeSystem = true), Name("IDBObjectStore")]
	public partial class ObjectStore
	{
		internal ObjectStore()
		{
		}

		public Request Add(object value, object key)
		{
			return default(Request);
		}

		[FieldProperty]
		public bool AutoIncrement
		{
			get {
				return false;
			}
		}

		public Request Clear()
		{
			return default(Request);
		}

		public Request Count(object key)
		{
			return default(Request);
		}

		public Index CreateIndex(string name, string keyPath)
		{
			return default(Index);
		}

		public Index CreateIndex(string name, string keyPath, IndexParameters optionalParameters)
		{
			return default(Index);
		}

		public Index CreateIndex(string name, string[] keyPath)
		{
			return default(Index);
		}

		public Index CreateIndex(string name, string[] keyPath, IndexParameters optionalParameters)
		{
			return default(Index);
		}

		public Request Delete(object key)
		{
			return default(Request);
		}

		public void DeleteIndex(string indexName)
		{
		}

		public Request Get(object key)
		{
			return default(Request);
		}

		public Request GetAll(object key)
		{
			return default(Request);
		}

		public Request GetAll(object key, int limit)
		{
			return default(Request);
		}

		public Request GetAllKeys(object key)
		{
			return default(Request);
		}

		public Request GetAllKeys(object key, int limit)
		{
			return default(Request);
		}

		public Index Index(string name)
		{
			return default(Index);
		}

		[FieldProperty]
		public DOMStringList IndexNames
		{
			get {
				return default(DOMStringList);
			}
		}

		[FieldProperty]
		public object KeyPath
		{
			get {
				return null;
			}
		}

		[FieldProperty]
		public string Name
		{
			get {
				return null;
			}
		}

		public Request OpenCursor(object range)
		{
			return default(Request);
		}

		public Request OpenCursor(object range, CursorDirection direction)
		{
			return default(Request);
		}

		public Request OpenKeyCursor(object range)
		{
			return default(Request);
		}

		public Request OpenKeyCursor(object range, CursorDirection direction)
		{
			return default(Request);
		}

		public Request Put(object value, object key)
		{
			return default(Request);
		}

		[FieldProperty]
		public Transaction Transaction
		{
			get {
				return default(Transaction);
			}
		}
	}
}
