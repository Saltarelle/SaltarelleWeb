using Bridge.Html5.Xml;

namespace Bridge.Html5.Speech
{
	[External, Serializable]
	public partial class SpeechRecognitionEventInit : EventInit
	{
		public DocumentBase Emma
		{
			get;
			set;
		}

		public string Interpretation
		{
			get;
			set;
		}

		public int ResultIndex
		{
			get;
			set;
		}

		public object Results
		{
			get;
			set;
		}
	}
}
