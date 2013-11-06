using System.Runtime.CompilerServices;

namespace System.Data.IndexedDB {
	[Imported, NamedValues]
	public enum RequestEvents {
		[ScriptName("onerror")]
		Error,
		[ScriptName("onsuccess")]
		Success
	}
}
