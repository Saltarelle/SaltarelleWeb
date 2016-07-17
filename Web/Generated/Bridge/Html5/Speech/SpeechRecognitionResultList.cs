namespace Bridge.Html5.Speech
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class SpeechRecognitionResultList
	{
		internal extern SpeechRecognitionResultList();

		[IndexerName("__Item"), FieldProperty]
		public SpeechRecognitionResult this[int index]
		{
			get;
		}

		public extern SpeechRecognitionResult Item(int index);

		public readonly int Length;
	}
}
