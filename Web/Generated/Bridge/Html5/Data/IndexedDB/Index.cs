namespace Bridge.Html5.Data.IndexedDB
{
	[Namespace("false"), External(ObeysTypeSystem = true), Name("IDBIndex")]
	public partial class Index
	{
		internal Index()
		{
		}

		public Request Count(object key)
		{
			return default(Request);
		}

		public Request Get(object key)
		{
			return default(Request);
		}

		public Request GetKey(object key)
		{
			return default(Request);
		}

		[FieldProperty]
		public object KeyPath
		{
			get {
				return null;
			}
		}

		[FieldProperty]
		public bool MultiEntry
		{
			get {
				return false;
			}
		}

		[FieldProperty]
		public string Name
		{
			get {
				return null;
			}
		}

		[FieldProperty]
		public ObjectStore ObjectStore
		{
			get {
				return default(ObjectStore);
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

		[FieldProperty]
		public string StoreName
		{
			get {
				return null;
			}
		}

		[FieldProperty]
		public bool Unique
		{
			get {
				return false;
			}
		}
	}
}
