namespace Bridge.Html5
{
	[External, Serializable]
	public partial class HashChangeEventInit : EventInit
	{
		public extern string NewURL
		{
			get;
			set;
		}

		public extern string OldURL
		{
			get;
			set;
		}
	}
}
