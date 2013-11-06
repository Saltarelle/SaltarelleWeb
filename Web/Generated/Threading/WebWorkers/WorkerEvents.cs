using System.Runtime.CompilerServices;

namespace System.Threading.WebWorkers {
	[Imported, NamedValues]
	public enum WorkerEvents {
		[ScriptName("onerror")]
		Error,
		[ScriptName("onmessage")]
		Message
	}
}
