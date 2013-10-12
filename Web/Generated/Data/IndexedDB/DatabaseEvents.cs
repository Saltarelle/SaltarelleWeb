using System.Runtime.CompilerServices;

namespace System.Data.IndexedDB {
	[Imported, NamedValues]
	public enum DatabaseEvents {
		[ScriptName("onabort")]
		Abort,
		[ScriptName("onerror")]
		Error,
		[ScriptName("onversionchange")]
		Versionchange
	}
}
