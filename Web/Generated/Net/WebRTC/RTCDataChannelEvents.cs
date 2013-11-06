using System.Runtime.CompilerServices;

namespace System.Net.WebRTC {
	[Imported, NamedValues]
	public enum RTCDataChannelEvents {
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
