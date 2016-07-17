using System;

namespace Bridge.Html5.Data.IndexedDB
{
	[Namespace("false"), External(ObeysTypeSystem = true), Name("IDBCursor")]
	public partial class Cursor
	{
		internal extern Cursor();

		public extern void Advance(int count);

		public extern void Continue(object key);

		public extern Request Delete();

		public readonly CursorDirection Direction;

		public readonly object Key;

		public readonly object PrimaryKey;

		public readonly TypeOption<ObjectStore, Index> Source;

		public extern Request Update(object value);
	}
}
