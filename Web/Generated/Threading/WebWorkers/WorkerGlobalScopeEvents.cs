using System.Runtime.CompilerServices;

namespace System.Threading.WebWorkers {
	[Imported, NamedValues]
	public enum WorkerGlobalScopeEvents {
		Close,
		Error,
		Offline,
		Online
	}
}
