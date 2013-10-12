using System.Runtime.CompilerServices;

namespace System.Data.IndexedDB {
	[Imported, NamedValues]
	public enum RequestEvents {
		[ScriptName("onsuccess")]
		Success,
		[ScriptName("onerror")]
		Error
	}
}
