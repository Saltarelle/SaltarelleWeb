using System.Runtime.CompilerServices;

namespace System.Html.Speech {
	[Imported, NamedValues]
	public enum SpeechRecognitionErrorCode {
		[ScriptName("no-speech")]
		NoSpeech,
		Aborted,
		[ScriptName("audio-capture")]
		AudioCapture,
		Network,
		[ScriptName("not-allowed")]
		NotAllowed,
		[ScriptName("service-not-allowed")]
		ServiceNotAllowed,
		[ScriptName("bad-grammar")]
		BadGrammar,
		[ScriptName("language-not-supported")]
		LanguageNotSupported,
	}
}
