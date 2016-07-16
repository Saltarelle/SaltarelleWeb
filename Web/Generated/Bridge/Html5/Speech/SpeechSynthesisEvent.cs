namespace Bridge.Html5.Speech
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class SpeechSynthesisEvent : Event
	{
		internal SpeechSynthesisEvent()
		{
		}

		public SpeechSynthesisEvent(string type)
		{
		}

		public SpeechSynthesisEvent(string type, SpeechSynthesisEventInit eventInitDict)
		{
		}

		[FieldProperty]
		public int CharIndex
		{
			get {
				return 0;
			}
		}

		[FieldProperty]
		public double ElapsedTime
		{
			get {
				return 0;
			}
		}

		[FieldProperty]
		public string Name
		{
			get {
				return null;
			}
		}
	}
}
