namespace Bridge.Html5.Speech
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class SpeechRecognitionError : Event
	{
		internal extern SpeechRecognitionError();

		public extern SpeechRecognitionError(string type);

		public extern SpeechRecognitionError(string type, SpeechRecognitionErrorInit eventInitDict);

		[FieldProperty]
		public extern SpeechRecognitionErrorCode Error
		{
			get;
		}

		[FieldProperty]
		public extern string Message
		{
			get;
		}
	}
}
