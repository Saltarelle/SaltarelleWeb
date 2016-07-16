namespace Bridge.Html5
{
	[External, Serializable]
	public partial class UIEventInit : EventInit
	{
		public extern int Detail
		{
			get;
			set;
		}

		public extern WindowInstance View
		{
			get;
			set;
		}
	}
}
