// MediaElementReadyState.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
// 

using System.Runtime.CompilerServices;

namespace System.Html {
	[Imported]
	public enum MediaElementReadyState {
		HaveNothing = 0,
		HaveMetadata = 1,
		HaveCurrentData = 2,
		HaveFutureData = 3,
		HaveEnoughData = 4,
	}
}