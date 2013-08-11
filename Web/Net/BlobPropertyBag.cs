// BlobPropertyBag.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
// 

using System.Runtime.CompilerServices;

namespace System.Net {
	[IgnoreNamespace, Imported]
	public class BlobPropertyBag {
		[InlineCode("{{}}")]
		public BlobPropertyBag() {
		}

		[InlineCode("{{ 'type': {type} }}")]
		public BlobPropertyBag(string type) {
		}

		[IntrinsicProperty]
		public string Type { get; set; }
	}
}