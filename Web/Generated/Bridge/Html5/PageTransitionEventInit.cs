namespace Bridge.Html5
{
	[External, Serializable]
	public partial class PageTransitionEventInit : EventInit
	{
		public extern bool Persisted
		{
			get;
			set;
		}
	}
}
