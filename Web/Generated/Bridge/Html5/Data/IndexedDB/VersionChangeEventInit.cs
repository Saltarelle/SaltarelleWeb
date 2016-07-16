namespace Bridge.Html5.Data.IndexedDB
{
	[External, Serializable]
	public partial class VersionChangeEventInit : EventInit
	{
		public extern ulong? NewVersion
		{
			get;
			set;
		}

		public extern ulong OldVersion
		{
			get;
			set;
		}
	}
}
