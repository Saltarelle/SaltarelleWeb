namespace Bridge.Html5.Speech
{
	[External, Serializable]
	public partial class SpeechSynthesisEventInit : EventInit
	{
		public int CharIndex
		{
			get;
			set;
		}

		public double ElapsedTime
		{
			get;
			set;
		}

		public string Name
		{
			get;
			set;
		}
	}
}
