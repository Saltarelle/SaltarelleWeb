namespace Bridge.Html5
{
	[External, Serializable]
	public partial class PageTransitionEventInit : EventInit
	{
		public bool Persisted
		{
			get;
			set;
		}
	}
}
