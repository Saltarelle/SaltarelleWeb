namespace Bridge.Html5.Speech
{
	[Namespace(false), External]
	public partial class SpeechSynthesisEvent : Event
	{
		internal extern SpeechSynthesisEvent();

		public extern SpeechSynthesisEvent(string type);

		public extern SpeechSynthesisEvent(string type, SpeechSynthesisEventInit eventInitDict);

		public readonly int CharIndex;

		public readonly double ElapsedTime;

		public readonly string Name;
	}
}
