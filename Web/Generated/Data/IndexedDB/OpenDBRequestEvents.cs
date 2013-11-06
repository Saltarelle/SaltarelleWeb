using System.Runtime.CompilerServices;

namespace System.Data.IndexedDB {
	[Imported, NamedValues]
	public enum OpenDBRequestEvents {
		[ScriptName("onblocked")]
		Blocked,
		[ScriptName("onerror")]
		Error,
		[ScriptName("onsuccess")]
		Success,
		[ScriptName("onupgradeneeded")]
		Upgradeneeded
	}
}
