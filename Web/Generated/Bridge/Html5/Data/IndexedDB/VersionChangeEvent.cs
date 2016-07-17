namespace Bridge.Html5.Data.IndexedDB
{
	[Namespace("false"), External, Name("IDBVersionChangeEvent")]
	public partial class VersionChangeEvent : Event
	{
		internal extern VersionChangeEvent();

		public extern VersionChangeEvent(string type);

		public extern VersionChangeEvent(string type, VersionChangeEventInit eventInitDict);

		public readonly ulong? NewVersion;

		public readonly ulong OldVersion;
	}
}
