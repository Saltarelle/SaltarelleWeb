using Bridge.Html5.Xml;

namespace Bridge.Html5.Speech
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class SpeechRecognitionEvent : Event
	{
		internal SpeechRecognitionEvent()
		{
		}

		public SpeechRecognitionEvent(string type)
		{
		}

		public SpeechRecognitionEvent(string type, SpeechRecognitionEventInit eventInitDict)
		{
		}

		[FieldProperty]
		public DocumentBase Emma
		{
			get {
				return default(DocumentBase);
			}
		}

		[FieldProperty]
		public string Interpretation
		{
			get {
				return null;
			}
		}

		[FieldProperty]
		public int ResultIndex
		{
			get {
				return 0;
			}
		}

		[FieldProperty]
		public object Results
		{
			get {
				return null;
			}
		}
	}
}
