// DataTransferItem.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
// 

using System.IO;
using System.Runtime.CompilerServices;

namespace System.Html {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class DataTransferItem {
		internal DataTransferItem() {
		}

		public File GetAsFile() {
			return default(File);
		}

		public void GetAsString(Action<string> callback) {
		}

		[IntrinsicProperty]
		public DataTransferItemKind Kind {
			get { return default(DataTransferItemKind); }
		}

		[IntrinsicProperty]
		public string Type {
			get { return null; }
		}
	}
}
