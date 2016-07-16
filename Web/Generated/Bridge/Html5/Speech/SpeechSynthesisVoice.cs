namespace Bridge.Html5.Speech
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class SpeechSynthesisVoice
	{
		internal extern SpeechSynthesisVoice();

		[FieldProperty]
		public extern bool Default
		{
			get;
		}

		[FieldProperty]
		public extern string Lang
		{
			get;
		}

		[FieldProperty]
		public extern bool LocalService
		{
			get;
		}

		[FieldProperty]
		public extern string Name
		{
			get;
		}

		[FieldProperty]
		public extern string VoiceURI
		{
			get;
		}
	}
}
