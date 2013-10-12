using System.Runtime.CompilerServices;

namespace System.Data.IndexedDB {
	[Imported, NamedValues]
	public enum TransactionEvents {
		[ScriptName("onabort")]
		Abort,
		[ScriptName("oncomplete")]
		Complete,
		[ScriptName("onerror")]
		Error
	}
}
