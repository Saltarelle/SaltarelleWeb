namespace Bridge.Html5.Speech
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class SpeechSynthesisVoice
	{
		internal SpeechSynthesisVoice()
		{
		}

		[FieldProperty]
		public bool Default
		{
			get {
				return false;
			}
		}

		[FieldProperty]
		public string Lang
		{
			get {
				return null;
			}
		}

		[FieldProperty]
		public bool LocalService
		{
			get {
				return false;
			}
		}

		[FieldProperty]
		public string Name
		{
			get {
				return null;
			}
		}

		[FieldProperty]
		public string VoiceURI
		{
			get {
				return null;
			}
		}
	}
}
