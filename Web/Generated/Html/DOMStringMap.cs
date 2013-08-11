// DOMStringMap.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
// 

using System.Runtime.CompilerServices;

namespace System.Html {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class DOMStringMap {
		internal DOMStringMap() {
		}

		[IndexerName("__Item"), IntrinsicProperty]
		public string this[string name] {
			get { return null; }
			set { }
		}

		[InlineCode("delete {this}[{name}]")]
		public void Delete(string name) {
		}
	}
}
