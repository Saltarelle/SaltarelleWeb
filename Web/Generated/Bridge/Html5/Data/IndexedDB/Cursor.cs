using System;

namespace Bridge.Html5.Data.IndexedDB
{
	[Namespace("false"), External(ObeysTypeSystem = true), Name("IDBCursor")]
	public partial class Cursor
	{
		internal Cursor()
		{
		}

		public void Advance(int count)
		{
		}

		public void Continue(object key)
		{
		}

		public Request Delete()
		{
			return default(Request);
		}

		[FieldProperty]
		public CursorDirection Direction
		{
			get {
				return default(CursorDirection);
			}
		}

		[FieldProperty]
		public object Key
		{
			get {
				return null;
			}
		}

		[FieldProperty]
		public object PrimaryKey
		{
			get {
				return null;
			}
		}

		[FieldProperty]
		public TypeOption<ObjectStore, Index> Source
		{
			get {
				return default(TypeOption<ObjectStore, Index>);
			}
		}

		public Request Update(object value)
		{
			return default(Request);
		}
	}
}
