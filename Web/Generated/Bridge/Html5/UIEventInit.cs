namespace Bridge.Html5
{
	[External, Serializable]
	public partial class UIEventInit : EventInit
	{
		public int Detail
		{
			get;
			set;
		}

		public WindowInstance View
		{
			get;
			set;
		}
	}
}
