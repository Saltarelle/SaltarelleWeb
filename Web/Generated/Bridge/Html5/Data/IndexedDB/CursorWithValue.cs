namespace Bridge.Html5.Data.IndexedDB
{
	[Namespace("false"), External(ObeysTypeSystem = true), Name("IDBCursorWithValue")]
	public partial class CursorWithValue : Cursor
	{
		internal CursorWithValue()
		{
		}

		[FieldProperty]
		public object Value
		{
			get {
				return null;
			}
		}
	}
}
