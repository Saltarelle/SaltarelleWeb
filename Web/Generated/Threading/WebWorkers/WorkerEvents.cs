using System.Runtime.CompilerServices;

namespace System.Threading.WebWorkers {
	[Imported, NamedValues]
	public enum WorkerEvents {
		[ScriptName("onmessage")]
		Message,
		[ScriptName("onerror")]
		Error
	}
}
