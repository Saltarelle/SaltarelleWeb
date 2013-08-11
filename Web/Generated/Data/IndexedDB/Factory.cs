// Factory.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
// 

using System.Runtime.CompilerServices;

namespace System.Data.IndexedDB {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true), ScriptName("IDBFactory")]
	public partial class Factory {
		internal Factory() {
		}

		public short Cmp(object first, object second) {
			return 0;
		}

		public OpenDBRequest DeleteDatabase(string name) {
			return default(OpenDBRequest);
		}

		public OpenDBRequest Open(string name) {
			return default(OpenDBRequest);
		}

		public OpenDBRequest Open(string name, ulong version) {
			return default(OpenDBRequest);
		}
	}
}
