using System.Runtime.CompilerServices;

namespace System.Data.Offline {
	[Imported, NamedValues]
	public enum ApplicationCacheEvents {
		[ScriptName("oncached")]
		Cached,
		[ScriptName("onchecking")]
		Checking,
		[ScriptName("ondownloading")]
		Downloading,
		[ScriptName("onerror")]
		Error,
		[ScriptName("onnoupdate")]
		Noupdate,
		[ScriptName("onobsolete")]
		Obsolete,
		[ScriptName("onprogress")]
		Progress,
		[ScriptName("onupdateready")]
		Updateready
	}
}
