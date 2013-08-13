using System.Runtime.CompilerServices;

namespace System.Data.IndexedDB {
	[Imported, NamedValues]
	public enum TransactionMode {
		Readonly,
		Readwrite,
		Versionchange
	}
}
