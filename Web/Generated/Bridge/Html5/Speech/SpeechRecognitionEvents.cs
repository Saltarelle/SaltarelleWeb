namespace Bridge.Html5.Speech
{
	[External, Name("String"), Enum(Emit.StringNameLowerCase)]
	public enum SpeechRecognitionEvents
	{
		Audioend,
		Audiostart,
		End,
		Error,
		Nomatch,
		Result,
		Soundend,
		Soundstart,
		Speechend,
		Speechstart,
		Start
	}
}
