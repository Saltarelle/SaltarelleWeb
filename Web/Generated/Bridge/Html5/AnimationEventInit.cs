namespace Bridge.Html5
{
	[External, Serializable]
	public partial class AnimationEventInit : EventInit
	{
		public string AnimationName
		{
			get;
			set;
		}

		public double ElapsedTime
		{
			get;
			set;
		}

		public string PseudoElement
		{
			get;
			set;
		}
	}
}
