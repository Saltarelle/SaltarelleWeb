namespace Bridge.Html5.Data.WebStorage
{
	[External, Serializable]
	public partial class StorageEventInit : EventInit
	{
		public extern string Key
		{
			get;
			set;
		}

		public extern string NewValue
		{
			get;
			set;
		}

		public extern string OldValue
		{
			get;
			set;
		}

		public extern Storage StorageArea
		{
			get;
			set;
		}

		public extern string Url
		{
			get;
			set;
		}
	}
}
