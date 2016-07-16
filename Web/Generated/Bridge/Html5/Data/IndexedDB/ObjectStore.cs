namespace Bridge.Html5.Data.IndexedDB
{
	[Namespace("false"), External(ObeysTypeSystem = true), Name("IDBObjectStore")]
	public partial class ObjectStore
	{
		internal extern ObjectStore();

		public extern Request Add(object value, object key);

		[FieldProperty]
		public extern bool AutoIncrement
		{
			get;
		}

		public extern Request Clear();

		public extern Request Count(object key);

		public extern Index CreateIndex(string name, string keyPath);

		public extern Index CreateIndex(string name, string keyPath, IndexParameters optionalParameters);

		public extern Index CreateIndex(string name, string[] keyPath);

		public extern Index CreateIndex(string name, string[] keyPath, IndexParameters optionalParameters);

		public extern Request Delete(object key);

		public extern void DeleteIndex(string indexName);

		public extern Request Get(object key);

		public extern Request GetAll(object key);

		public extern Request GetAll(object key, int limit);

		public extern Request GetAllKeys(object key);

		public extern Request GetAllKeys(object key, int limit);

		public extern Index Index(string name);

		[FieldProperty]
		public extern DOMStringList IndexNames
		{
			get;
		}

		[FieldProperty]
		public extern object KeyPath
		{
			get;
		}

		[FieldProperty]
		public extern string Name
		{
			get;
		}

		public extern Request OpenCursor(object range);

		public extern Request OpenCursor(object range, CursorDirection direction);

		public extern Request OpenKeyCursor(object range);

		public extern Request OpenKeyCursor(object range, CursorDirection direction);

		public extern Request Put(object value, object key);

		[FieldProperty]
		public extern Transaction Transaction
		{
			get;
		}
	}
}
