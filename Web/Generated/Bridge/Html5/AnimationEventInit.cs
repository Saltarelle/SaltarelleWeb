namespace Bridge.Html5
{
	[External, Serializable]
	public partial class AnimationEventInit : EventInit
	{
		public extern string AnimationName
		{
			get;
			set;
		}

		public extern double ElapsedTime
		{
			get;
			set;
		}

		public extern string PseudoElement
		{
			get;
			set;
		}
	}
}
