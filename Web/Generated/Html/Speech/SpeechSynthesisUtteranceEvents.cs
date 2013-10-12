using System.Runtime.CompilerServices;

namespace System.Html.Speech {
	[Imported, NamedValues]
	public enum SpeechSynthesisUtteranceEvents {
		[ScriptName("onstart")]
		Start,
		[ScriptName("onend")]
		End,
		[ScriptName("onerror")]
		Error,
		[ScriptName("onpause")]
		Pause,
		[ScriptName("onresume")]
		Resume,
		[ScriptName("onmark")]
		Mark,
		[ScriptName("onboundary")]
		Boundary
	}
}
