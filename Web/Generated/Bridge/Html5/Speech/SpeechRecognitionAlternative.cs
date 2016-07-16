namespace Bridge.Html5.Speech
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class SpeechRecognitionAlternative
	{
		internal extern SpeechRecognitionAlternative();

		[FieldProperty]
		public extern double Confidence
		{
			get;
		}

		[FieldProperty]
		public extern string Transcript
		{
			get;
		}
	}
}
