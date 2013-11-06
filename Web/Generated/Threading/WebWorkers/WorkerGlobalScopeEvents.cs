using System.Runtime.CompilerServices;

namespace System.Threading.WebWorkers {
	[Imported, NamedValues]
	public enum WorkerGlobalScopeEvents {
		[ScriptName("onclose")]
		Close,
		[ScriptName("onerror")]
		Error
	}
}
