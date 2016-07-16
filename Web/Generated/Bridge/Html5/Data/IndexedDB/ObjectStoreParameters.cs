namespace Bridge.Html5.Data.IndexedDB
{
	[External, Serializable]
	public partial class ObjectStoreParameters
	{
		public bool AutoIncrement
		{
			get;
			set;
		}

		public object KeyPath
		{
			get;
			set;
		}
	}
}
