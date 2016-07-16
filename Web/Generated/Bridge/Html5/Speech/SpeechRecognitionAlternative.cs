namespace Bridge.Html5.Speech
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class SpeechRecognitionAlternative
	{
		internal SpeechRecognitionAlternative()
		{
		}

		[FieldProperty]
		public double Confidence
		{
			get {
				return 0;
			}
		}

		[FieldProperty]
		public string Transcript
		{
			get {
				return null;
			}
		}
	}
}
