using System.Runtime.CompilerServices;

namespace System.Html.Speech {
	[Imported, NamedValues]
	public enum SpeechRecognitionEvents {
		[ScriptName("onaudiostart")]
		Audiostart,
		[ScriptName("onsoundstart")]
		Soundstart,
		[ScriptName("onspeechstart")]
		Speechstart,
		[ScriptName("onspeechend")]
		Speechend,
		[ScriptName("onsoundend")]
		Soundend,
		[ScriptName("onaudioend")]
		Audioend,
		[ScriptName("onresult")]
		Result,
		[ScriptName("onnomatch")]
		Nomatch,
		[ScriptName("onerror")]
		Error,
		[ScriptName("onstart")]
		Start,
		[ScriptName("onend")]
		End
	}
}
