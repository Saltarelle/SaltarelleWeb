namespace Bridge.Html5.Speech
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class SpeechSynthesisEvent : Event
	{
		internal extern SpeechSynthesisEvent();

		public extern SpeechSynthesisEvent(string type);

		public extern SpeechSynthesisEvent(string type, SpeechSynthesisEventInit eventInitDict);

		[FieldProperty]
		public extern int CharIndex
		{
			get;
		}

		[FieldProperty]
		public extern double ElapsedTime
		{
			get;
		}

		[FieldProperty]
		public extern string Name
		{
			get;
		}
	}
}
