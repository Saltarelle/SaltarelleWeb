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

		[FieldProperty]
		public extern CursorDirection Direction
		{
			get;
		}

		[FieldProperty]
		public extern object Key
		{
			get;
		}

		[FieldProperty]
		public extern object PrimaryKey
		{
			get;
		}

		[FieldProperty]
		public extern TypeOption<ObjectStore, Index> Source
		{
			get;
		}

		public extern Request Update(object value);
	}
}
