namespace Bridge.Html5.Speech
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class SpeechSynthesis
	{
		internal extern SpeechSynthesis();

		public extern void Cancel();

		public extern SpeechSynthesisVoice[] GetVoices();

		public extern void Pause();

		[FieldProperty]
		public extern bool Paused
		{
			get;
		}

		[FieldProperty]
		public extern bool Pending
		{
			get;
		}

		public extern void Resume();

		public extern void Speak(SpeechSynthesisUtterance utterance);

		[FieldProperty]
		public extern bool Speaking
		{
			get;
		}
	}
}
