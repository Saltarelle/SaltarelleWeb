using System.Runtime.CompilerServices;

namespace System.Net.WebRTC {
	[Imported, NamedValues]
	public enum RTCDataChannelEvents {
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
