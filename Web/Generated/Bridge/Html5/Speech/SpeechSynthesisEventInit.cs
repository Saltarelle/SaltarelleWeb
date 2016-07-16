namespace Bridge.Html5.Speech
{
	[External, Serializable]
	public partial class SpeechSynthesisEventInit : EventInit
	{
		public extern int CharIndex
		{
			get;
			set;
		}

		public extern double ElapsedTime
		{
			get;
			set;
		}

		public extern string Name
		{
			get;
			set;
		}
	}
}
