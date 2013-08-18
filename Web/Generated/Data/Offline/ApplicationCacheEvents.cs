using System.Runtime.CompilerServices;

namespace System.Data.Offline {
	[Imported, NamedValues]
	public enum ApplicationCacheEvents {
		[ScriptName("onchecking")]
		Checking,
		[ScriptName("onerror")]
		Error,
		[ScriptName("onnoupdate")]
		Noupdate,
		[ScriptName("ondownloading")]
		Downloading,
		[ScriptName("onprogress")]
		Progress,
		[ScriptName("onupdateready")]
		Updateready,
		[ScriptName("oncached")]
		Cached,
		[ScriptName("onobsolete")]
		Obsolete
	}
}
