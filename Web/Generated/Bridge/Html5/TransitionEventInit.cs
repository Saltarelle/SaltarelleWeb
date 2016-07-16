namespace Bridge.Html5
{
	[External, Serializable]
	public partial class TransitionEventInit : EventInit
	{
		public double ElapsedTime
		{
			get;
			set;
		}

		public string PropertyName
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
