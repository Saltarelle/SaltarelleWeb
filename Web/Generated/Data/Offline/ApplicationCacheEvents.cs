using System.Runtime.CompilerServices;

namespace System.Data.Offline {
	[Imported, NamedValues]
	public enum ApplicationCacheEvents {
		Cached,
		Checking,
		Downloading,
		Error,
		Noupdate,
		Obsolete,
		Progress,
		Updateready
	}
}
