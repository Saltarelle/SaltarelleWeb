using System.Runtime.CompilerServices;

namespace System.Media.Recording {
	[Imported, NamedValues]
	public enum MediaRecorderEvents {
		[ScriptName("ondataavailable")]
		Dataavailable,
		[ScriptName("onerror")]
		Error,
		[ScriptName("onstop")]
		Stop,
		[ScriptName("onwarning")]
		Warning
	}
}
