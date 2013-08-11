// Crypto.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
// 

using System.Collections.TypedArrays;
using System.Runtime.CompilerServices;

namespace System.Security.Cryptography {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class Crypto : IRandomSource {
		internal Crypto() {
		}

		public ArrayBufferView GetRandomValues(ArrayBufferView array) {
			return default(ArrayBufferView);
		}
	}
}
