namespace Bridge.Html5.IO
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class FileList
	{
		internal extern FileList();

		[IndexerName("__Item"), FieldProperty]
		public File this[int index]
		{
			get;
		}

		public extern File Item(int index);

		public readonly int Length;
	}
}
