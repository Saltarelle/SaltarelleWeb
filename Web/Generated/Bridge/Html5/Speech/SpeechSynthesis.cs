namespace Bridge.Html5.Speech
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class SpeechSynthesis
	{
		internal SpeechSynthesis()
		{
		}

		public void Cancel()
		{
		}

		public SpeechSynthesisVoice[] GetVoices()
		{
			return null;
		}

		public void Pause()
		{
		}

		[FieldProperty]
		public bool Paused
		{
			get {
				return false;
			}
		}

		[FieldProperty]
		public bool Pending
		{
			get {
				return false;
			}
		}

		public void Resume()
		{
		}

		public void Speak(SpeechSynthesisUtterance utterance)
		{
		}

		[FieldProperty]
		public bool Speaking
		{
			get {
				return false;
			}
		}
	}
}
