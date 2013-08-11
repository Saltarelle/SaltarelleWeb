// File.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
// 

using System.Runtime.CompilerServices;

namespace System.IO {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class File : Blob {
		internal File() {
		}

		[IntrinsicProperty]
		public DateTime LastModifiedDate {
			get { return default(DateTime); }
		}

		[IntrinsicProperty]
		public string Name {
			get { return null; }
		}
	}
}
