namespace Bridge.Html5.Speech
{
	[External, Serializable]
	public partial class SpeechRecognitionErrorInit : EventInit
	{
		public extern SpeechRecognitionErrorCode Error
		{
			get;
			set;
		}

		public extern string Message
		{
			get;
			set;
		}
	}
}
