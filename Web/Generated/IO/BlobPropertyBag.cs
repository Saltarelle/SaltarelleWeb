// BlobPropertyBag.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
// 

using System.Runtime.CompilerServices;

namespace System.IO {
	[Imported, Serializable]
	public partial class BlobPropertyBag {
		public EndingTypes Endings {
			get { return default(EndingTypes); }
			set { }
		}

		public string Type {
			get { return null; }
			set { }
		}
	}
}
