namespace Bridge.Html5.IO
{
	[Namespace("false"), External]
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
