using System.Runtime.CompilerServices;

namespace System.Net.ServerEvents {
	[Imported, NamedValues]
	public enum EventSourceEvents {
		[ScriptName("onerror")]
		Error,
		[ScriptName("onmessage")]
		Message,
		[ScriptName("onopen")]
		Open
	}
}
