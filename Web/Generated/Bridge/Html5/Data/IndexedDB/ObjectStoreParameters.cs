namespace Bridge.Html5.Data.IndexedDB
{
	[External, Serializable]
	public partial class ObjectStoreParameters
	{
		public extern bool AutoIncrement
		{
			get;
			set;
		}

		public extern object KeyPath
		{
			get;
			set;
		}
	}
}
