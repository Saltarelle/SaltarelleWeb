using Bridge.Html5.Xml;

namespace Bridge.Html5.Speech
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class SpeechRecognitionEvent : Event
	{
		internal extern SpeechRecognitionEvent();

		public extern SpeechRecognitionEvent(string type);

		public extern SpeechRecognitionEvent(string type, SpeechRecognitionEventInit eventInitDict);

		public readonly DocumentBase Emma;

		public readonly string Interpretation;

		public readonly int ResultIndex;

		public readonly object Results;
	}
}
