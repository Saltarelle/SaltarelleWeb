namespace Bridge.Html5.Data.IndexedDB
{
	[External, Serializable]
	public partial class OpenDBOptions
	{
		public extern StorageType Storage
		{
			get;
			set;
		}

		public extern ulong Version
		{
			get;
			set;
		}
	}
}
