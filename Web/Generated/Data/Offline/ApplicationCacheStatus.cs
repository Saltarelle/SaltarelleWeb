using System.Runtime.CompilerServices;

namespace System.Data.Offline {
	[Imported]
	public enum ApplicationCacheStatus {
		Checking = 2,
		Downloading = 3,
		Idle = 1,
		Obsolete = 5,
		Uncached = 0,
		Updateready = 4
	}
}
