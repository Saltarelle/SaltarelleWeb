// Blob.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
// 

using System.Runtime.CompilerServices;

namespace System.Net {
	[IgnoreNamespace, Imported]
	public class Blob {
		[ScriptName("")]
		public Blob() {
		}

		[ScriptName("")]
		public Blob(Array parts) {
		}

		[ScriptName("")]
		public Blob(Array parts, BlobPropertyBag properties) {
		}

		[IntrinsicProperty]
		public ulong Size { get; private set; }

		public Blob Slice() {
			return null;
		}

		public Blob Slice(long start) {
			return null;
		}

		public Blob Slice(long start, long end) {
			return null;
		}

		public Blob Slice(long start, long end, string contentType) {
			return null;
		}

		[IntrinsicProperty]
		public string Type { get; private set; }
	}
}