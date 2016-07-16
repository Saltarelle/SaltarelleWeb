namespace Bridge.Html5
{
	[External, Serializable]
	public partial class HashChangeEventInit : EventInit
	{
		public string NewURL
		{
			get;
			set;
		}

		public string OldURL
		{
			get;
			set;
		}
	}
}
