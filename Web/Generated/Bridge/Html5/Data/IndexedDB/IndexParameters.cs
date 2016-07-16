namespace Bridge.Html5.Data.IndexedDB
{
	[External, Serializable]
	public partial class IndexParameters
	{
		public extern bool MultiEntry
		{
			get;
			set;
		}

		public extern bool Unique
		{
			get;
			set;
		}
	}
}
