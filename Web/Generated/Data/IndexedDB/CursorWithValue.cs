using System.Runtime.CompilerServices;

namespace System.Data.IndexedDB {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true), ScriptName("IDBCursorWithValue")]
	public partial class CursorWithValue : Cursor {
		internal CursorWithValue() {
		}

		[IntrinsicProperty]
		public object Value {
			get {
				return null;
			}
		}
	}
}
