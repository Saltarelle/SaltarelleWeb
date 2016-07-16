using Bridge.Html5.Xml;

namespace Bridge.Html5.Speech
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class SpeechRecognitionEvent : Event
	{
		internal extern SpeechRecognitionEvent();

		public extern SpeechRecognitionEvent(string type);

		public extern SpeechRecognitionEvent(string type, SpeechRecognitionEventInit eventInitDict);

		[FieldProperty]
		public extern DocumentBase Emma
		{
			get;
		}

		[FieldProperty]
		public extern string Interpretation
		{
			get;
		}

		[FieldProperty]
		public extern int ResultIndex
		{
			get;
		}

		[FieldProperty]
		public extern object Results
		{
			get;
		}
	}
}
