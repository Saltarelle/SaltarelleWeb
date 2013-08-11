// IRandomSource.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
// 

using System.Collections.TypedArrays;
using System.Runtime.CompilerServices;

namespace System.Security.Cryptography {
	[IgnoreNamespace, Imported]
	public partial interface IRandomSource {
		ArrayBufferView GetRandomValues(ArrayBufferView array);
	}
}
