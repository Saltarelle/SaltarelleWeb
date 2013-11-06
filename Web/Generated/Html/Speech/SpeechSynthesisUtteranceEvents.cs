using System.Runtime.CompilerServices;

namespace System.Html.Speech {
	[Imported, NamedValues]
	public enum SpeechSynthesisUtteranceEvents {
		[ScriptName("onboundary")]
		Boundary,
		[ScriptName("onend")]
		End,
		[ScriptName("onerror")]
		Error,
		[ScriptName("onmark")]
		Mark,
		[ScriptName("onpause")]
		Pause,
		[ScriptName("onresume")]
		Resume,
		[ScriptName("onstart")]
		Start
	}
}
