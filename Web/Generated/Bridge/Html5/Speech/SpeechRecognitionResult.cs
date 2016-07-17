namespace Bridge.Html5.Speech
{
	[Namespace("false"), External]
	public partial class SpeechRecognitionResult
	{
		internal extern SpeechRecognitionResult();

		public extern SpeechRecognitionAlternative this[int index]
		{
			get;
		}

		public readonly bool Final;

		public extern SpeechRecognitionAlternative Item(int index);

		public readonly int Length;
	}
}
