using System.Runtime.CompilerServices;

namespace System.Net.WebSockets {
	[Imported, NamedValues]
	public enum WebSocketEvents {
		[ScriptName("onopen")]
		Open,
		[ScriptName("onerror")]
		Error,
		[ScriptName("onclose")]
		Close,
		[ScriptName("onmessage")]
		Message
	}
}
