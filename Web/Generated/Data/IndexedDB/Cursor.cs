﻿using System.Runtime.CompilerServices;

namespace System.Data.IndexedDB {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true), ScriptName("IDBCursor")]
	public partial class Cursor {
		internal Cursor() {
		}

		public void Advance(uint count) {
		}

		public void Continue(object key) {
		}

		public Request Delete() {
			return default(Request);
		}

		[IntrinsicProperty]
		public CursorDirection Direction {
			get {
				return default(CursorDirection);
			}
		}

		[IntrinsicProperty]
		public object Key {
			get {
				return null;
			}
		}

		[IntrinsicProperty]
		public object PrimaryKey {
			get {
				return null;
			}
		}

		[IntrinsicProperty]
		public TypeOption<ObjectStore, Index> Source {
			get {
				return default(TypeOption<ObjectStore, Index>);
			}
		}

		public Request Update(object value) {
			return default(Request);
		}
	}
}
