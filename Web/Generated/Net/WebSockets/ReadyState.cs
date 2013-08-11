// ReadyState.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
// 

using System.Runtime.CompilerServices;

namespace System.Net.WebSockets {
	[Imported]
	public enum ReadyState {
		Connecting = 0,
		Open = 1,
		Closing = 2,
		Closed = 3,
	}
}
