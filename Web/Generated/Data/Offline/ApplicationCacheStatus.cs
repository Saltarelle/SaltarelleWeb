// ApplicationCacheStatus.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
// 

using System.Runtime.CompilerServices;

namespace System.Data.Offline {
	[Imported]
	public enum ApplicationCacheStatus {
		Uncached = 0,
		Idle = 1,
		Checking = 2,
		Downloading = 3,
		Updateready = 4,
		Obsolete = 5,
	}
}
