// VersionChangeEventInit.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
// 

using System.Html;
using System.Runtime.CompilerServices;

namespace System.Data.IndexedDB {
	[Imported, Serializable]
	public partial class VersionChangeEventInit : EventInit {
		public ulong? NewVersion {
			get { return null; }
			set { }
		}

		public ulong OldVersion {
			get { return 0; }
			set { }
		}
	}
}
