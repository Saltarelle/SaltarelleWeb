using System.Runtime.CompilerServices;

namespace System.Html.Speech {
	[Imported, NamedValues]
	public enum SpeechRecognitionEvents {
		[ScriptName("onaudioend")]
		Audioend,
		[ScriptName("onaudiostart")]
		Audiostart,
		[ScriptName("onend")]
		End,
		[ScriptName("onerror")]
		Error,
		[ScriptName("onnomatch")]
		Nomatch,
		[ScriptName("onresult")]
		Result,
		[ScriptName("onsoundend")]
		Soundend,
		[ScriptName("onsoundstart")]
		Soundstart,
		[ScriptName("onspeechend")]
		Speechend,
		[ScriptName("onspeechstart")]
		Speechstart,
		[ScriptName("onstart")]
		Start
	}
}
