using System.Runtime.CompilerServices;

namespace System.Net.ServerEvents {
	[Imported, NamedValues]
	public enum EventSourceEvents {
		[ScriptName("onopen")]
		Open,
		[ScriptName("onmessage")]
		Message,
		[ScriptName("onerror")]
		Error
	}
}
