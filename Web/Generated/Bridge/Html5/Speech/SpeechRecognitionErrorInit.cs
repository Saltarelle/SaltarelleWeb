namespace Bridge.Html5.Speech
{
	[External, Serializable]
	public partial class SpeechRecognitionErrorInit : EventInit
	{
		public SpeechRecognitionErrorCode Error;

		public string Message;
	}
}
