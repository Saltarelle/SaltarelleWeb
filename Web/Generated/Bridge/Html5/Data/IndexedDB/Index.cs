namespace Bridge.Html5.Data.IndexedDB
{
	[Namespace("false"), External(ObeysTypeSystem = true), Name("IDBIndex")]
	public partial class Index
	{
		internal extern Index();

		public extern Request Count(object key);

		public extern Request Get(object key);

		public extern Request GetKey(object key);

		[FieldProperty]
		public extern object KeyPath
		{
			get;
		}

		[FieldProperty]
		public extern bool MultiEntry
		{
			get;
		}

		[FieldProperty]
		public extern string Name
		{
			get;
		}

		[FieldProperty]
		public extern ObjectStore ObjectStore
		{
			get;
		}

		public extern Request OpenCursor(object range);

		public extern Request OpenCursor(object range, CursorDirection direction);

		public extern Request OpenKeyCursor(object range);

		public extern Request OpenKeyCursor(object range, CursorDirection direction);

		[FieldProperty]
		public extern string StoreName
		{
			get;
		}

		[FieldProperty]
		public extern bool Unique
		{
			get;
		}
	}
}
