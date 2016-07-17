namespace Bridge.Html5.Speech
{
	[External, Name("String"), Enum(Emit.StringNameLowerCase)]
	public enum SpeechRecognitionErrorCode
	{
		Aborted,
		[Name("audio-capture")]
		AudioCapture,
		[Name("bad-grammar")]
		BadGrammar,
		[Name("language-not-supported")]
		LanguageNotSupported,
		Network,
		[Name("no-speech")]
		NoSpeech,
		[Name("not-allowed")]
		NotAllowed,
		[Name("service-not-allowed")]
		ServiceNotAllowed
	}
}
