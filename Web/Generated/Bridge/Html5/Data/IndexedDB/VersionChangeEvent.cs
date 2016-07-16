namespace Bridge.Html5.Data.IndexedDB
{
	[Namespace("false"), External(ObeysTypeSystem = true), Name("IDBVersionChangeEvent")]
	public partial class VersionChangeEvent : Event
	{
		internal VersionChangeEvent()
		{
		}

		public VersionChangeEvent(string type)
		{
		}

		public VersionChangeEvent(string type, VersionChangeEventInit eventInitDict)
		{
		}

		[FieldProperty]
		public ulong? NewVersion
		{
			get {
				return null;
			}
		}

		[FieldProperty]
		public ulong OldVersion
		{
			get {
				return 0;
			}
		}
	}
}
