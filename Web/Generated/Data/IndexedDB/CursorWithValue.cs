// CursorWithValue.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
// 

using System.Runtime.CompilerServices;

namespace System.Data.IndexedDB {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true), ScriptName("IDBCursorWithValue")]
	public partial class CursorWithValue : Cursor {
		internal CursorWithValue() {
		}

		[IntrinsicProperty]
		public object Value {
			get { return null; }
		}
	}
}
