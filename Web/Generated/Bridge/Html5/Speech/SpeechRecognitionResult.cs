namespace Bridge.Html5.Speech
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class SpeechRecognitionResult
	{
		internal extern SpeechRecognitionResult();

		[IndexerName("__Item"), FieldProperty]
		public SpeechRecognitionAlternative this[int index]
		{
			get;
		}

		public readonly bool Final;

		public extern SpeechRecognitionAlternative Item(int index);

		public readonly int Length;
	}
}
