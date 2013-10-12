using System.Runtime.CompilerServices;

namespace System.Data.IndexedDB {
	[Imported, NamedValues]
	public enum OpenDBRequestEvents {
		[ScriptName("onblocked")]
		Blocked,
		[ScriptName("onupgradeneeded")]
		Upgradeneeded,
		[ScriptName("onsuccess")]
		Success,
		[ScriptName("onerror")]
		Error
	}
}
