namespace Bridge.Html5.Data.IndexedDB
{
	[External, Serializable]
	public partial class VersionChangeEventInit : EventInit
	{
		public ulong? NewVersion;

		public ulong OldVersion;
	}
}
