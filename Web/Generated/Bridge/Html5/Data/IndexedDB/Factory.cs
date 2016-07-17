namespace Bridge.Html5.Data.IndexedDB
{
	[Namespace(false), External, Name("IDBFactory")]
	public partial class Factory
	{
		internal extern Factory();

		public extern short Cmp(object first, object second);

		public extern OpenDBRequest DeleteDatabase(string name);

		public extern OpenDBRequest DeleteDatabase(string name, OpenDBOptions options);

		public extern OpenDBRequest Open(string name);

		public extern OpenDBRequest Open(string name, OpenDBOptions options);

		public extern OpenDBRequest Open(string name, ulong version);
	}
}
