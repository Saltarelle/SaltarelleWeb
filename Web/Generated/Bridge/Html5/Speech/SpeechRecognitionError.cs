namespace Bridge.Html5.Speech
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class SpeechRecognitionError : Event
	{
		internal SpeechRecognitionError()
		{
		}

		public SpeechRecognitionError(string type)
		{
		}

		public SpeechRecognitionError(string type, SpeechRecognitionErrorInit eventInitDict)
		{
		}

		[FieldProperty]
		public SpeechRecognitionErrorCode Error
		{
			get {
				return default(SpeechRecognitionErrorCode);
			}
		}

		[FieldProperty]
		public string Message
		{
			get {
				return null;
			}
		}
	}
}
