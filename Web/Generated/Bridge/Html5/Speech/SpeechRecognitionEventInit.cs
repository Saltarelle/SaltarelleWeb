using Bridge.Html5.Elements;

namespace Bridge.Html5.Speech
{
	[External]
	public partial class SpeechRecognitionEventInit : EventInit
	{
		public DocumentBase Emma;

		public string Interpretation;

		public int ResultIndex;

		public object Results;
	}
}
