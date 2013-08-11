// ObjectStoreParameters.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
// 

using System.Runtime.CompilerServices;

namespace System.Data.IndexedDB {
	[Imported, Serializable]
	public partial class ObjectStoreParameters {
		public bool AutoIncrement {
			get { return false; }
			set { }
		}

		public object KeyPath {
			get { return null; }
			set { }
		}
	}
}
