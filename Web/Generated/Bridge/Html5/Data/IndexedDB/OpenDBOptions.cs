namespace Bridge.Html5.Data.IndexedDB
{
	[External, Serializable]
	public partial class OpenDBOptions
	{
		public StorageType Storage
		{
			get;
			set;
		}

		public ulong Version
		{
			get;
			set;
		}
	}
}
