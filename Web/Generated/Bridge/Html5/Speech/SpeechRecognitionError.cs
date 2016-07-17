namespace Bridge.Html5.Speech
{
	[Namespace(false), External]
	public partial class SpeechRecognitionError : Event
	{
		internal extern SpeechRecognitionError();

		public extern SpeechRecognitionError(string type);

		public extern SpeechRecognitionError(string type, SpeechRecognitionErrorInit eventInitDict);

		public readonly SpeechRecognitionErrorCode Error;

		public readonly string Message;
	}
}
