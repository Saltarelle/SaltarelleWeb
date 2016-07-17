namespace Bridge.Html5.Speech
{
	[Namespace(false), External]
	public partial class SpeechSynthesis
	{
		internal extern SpeechSynthesis();

		public extern void Cancel();

		public extern SpeechSynthesisVoice[] GetVoices();

		public extern void Pause();

		public readonly bool Paused;

		public readonly bool Pending;

		public extern void Resume();

		public extern void Speak(SpeechSynthesisUtterance utterance);

		public readonly bool Speaking;
	}
}
