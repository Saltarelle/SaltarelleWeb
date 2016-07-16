namespace Bridge.Html5.Data.IndexedDB
{
	[Namespace("false"), External(ObeysTypeSystem = true), Name("IDBCursorWithValue")]
	public partial class CursorWithValue : Cursor
	{
		internal extern CursorWithValue();

		[FieldProperty]
		public extern object Value
		{
			get;
		}
	}
}
