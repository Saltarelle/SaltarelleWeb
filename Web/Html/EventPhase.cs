// EventPhase.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
// 

using System.Runtime.CompilerServices;

namespace System.Html {
	[Imported]
	public enum EventPhase {
		None           = 0,
		CapturingPhase = 1,
		AtTarget       = 2,
		BubblingPhase  = 3,
	}
}