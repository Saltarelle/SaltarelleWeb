// SpeechRecognitionErrorCode.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
// 

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
