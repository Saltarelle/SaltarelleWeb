using Bridge.Html5.Xml;

namespace Bridge.Html5.Speech
{
	[External, Serializable]
	public partial class SpeechRecognitionEventInit : EventInit
	{
		public extern DocumentBase Emma
		{
			get;
			set;
		}

		public extern string Interpretation
		{
			get;
			set;
		}

		public extern int ResultIndex
		{
			get;
			set;
		}

		public extern object Results
		{
			get;
			set;
		}
	}
}
