namespace Bridge.Html5.Speech
{
	[External, Name("String"), Enum(Emit.StringNameLowerCase)]
	public enum SpeechRecognitionErrorCode
	{
		[Name("no-speech")]
		NoSpeech,
		Aborted,
		[Name("audio-capture")]
		AudioCapture,
		Network,
		[Name("not-allowed")]
		NotAllowed,
		[Name("service-not-allowed")]
		ServiceNotAllowed,
		[Name("bad-grammar")]
		BadGrammar,
		[Name("language-not-supported")]
		LanguageNotSupported
	}
}
