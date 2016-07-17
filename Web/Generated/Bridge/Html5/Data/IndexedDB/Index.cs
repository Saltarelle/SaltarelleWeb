namespace Bridge.Html5.Data.IndexedDB
{
	[Namespace("false"), External, Name("IDBIndex")]
	public partial class Index
	{
		internal extern Index();

		public extern Request Count(object key);

		public extern Request Get(object key);

		public extern Request GetKey(object key);

		public readonly object KeyPath;

		public readonly bool MultiEntry;

		public readonly string Name;

		public readonly ObjectStore ObjectStore;

		public extern Request OpenCursor(object range);

		public extern Request OpenCursor(object range, CursorDirection direction);

		public extern Request OpenKeyCursor(object range);

		public extern Request OpenKeyCursor(object range, CursorDirection direction);

		public readonly string StoreName;

		public readonly bool Unique;
	}
}
