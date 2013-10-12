using System.Runtime.CompilerServices;

namespace System.Threading.WebWorkers {
	[Imported, NamedValues]
	public enum WorkerGlobalScopeEvents {
		[ScriptName("onerror")]
		Error,
		[ScriptName("onoffline")]
		Offline,
		[ScriptName("ononline")]
		OnLine
	}
}
