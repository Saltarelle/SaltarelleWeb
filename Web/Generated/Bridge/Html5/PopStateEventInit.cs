namespace Bridge.Html5
{
	[External, Serializable]
	public partial class PopStateEventInit : EventInit
	{
		public extern object State
		{
			get;
			set;
		}
	}
}
