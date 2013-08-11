// DOMError.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
// 

using System.Runtime.CompilerServices;

namespace System.Html {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class DOMError {
		internal DOMError() {
		}

		public DOMError(string name) {
		}

		public DOMError(string name, string message) {
		}

		[IntrinsicProperty]
		public string Message {
			get { return null; }
		}

		[IntrinsicProperty]
		public string Name {
			get { return null; }
		}
	}
}
