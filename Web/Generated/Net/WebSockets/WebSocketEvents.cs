using System.Runtime.CompilerServices;

namespace System.Net.WebSockets {
	[Imported, NamedValues]
	public enum WebSocketEvents {
		[ScriptName("onclose")]
		Close,
		[ScriptName("onerror")]
		Error,
		[ScriptName("onmessage")]
		Message,
		[ScriptName("onopen")]
		Open
	}
}
