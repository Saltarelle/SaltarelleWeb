using Bridge.Html5.Xml;

namespace Bridge.Html5.Speech
{
	[External, Serializable]
	public partial class SpeechRecognitionEventInit : EventInit
	{
		public DocumentBase Emma;

		public string Interpretation;

		public int ResultIndex;

		public object Results;
	}
}
