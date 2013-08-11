// ReadyState.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
// 

using System.Runtime.CompilerServices;

namespace System.Net {
	[Imported]
	public enum ReadyState {
		Unsent = 0,
		Opened = 1,
		HeadersReceived = 2,
		Loading = 3,
		Done = 4,
	}
}
