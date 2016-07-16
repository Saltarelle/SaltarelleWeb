namespace Bridge.Html5
{
	[External, Serializable]
	public partial class TransitionEventInit : EventInit
	{
		public extern double ElapsedTime
		{
			get;
			set;
		}

		public extern string PropertyName
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
