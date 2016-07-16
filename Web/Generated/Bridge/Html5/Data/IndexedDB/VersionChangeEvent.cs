namespace Bridge.Html5.Data.IndexedDB
{
	[Namespace("false"), External(ObeysTypeSystem = true), Name("IDBVersionChangeEvent")]
	public partial class VersionChangeEvent : Event
	{
		internal extern VersionChangeEvent();

		public extern VersionChangeEvent(string type);

		public extern VersionChangeEvent(string type, VersionChangeEventInit eventInitDict);

		[FieldProperty]
		public extern ulong? NewVersion
		{
			get;
		}

		[FieldProperty]
		public extern ulong OldVersion
		{
			get;
		}
	}
}
