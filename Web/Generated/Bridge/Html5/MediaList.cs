namespace Bridge.Html5
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class MediaList
	{
		internal extern MediaList();

		[IndexerName("__Item"), FieldProperty]
		public string this[int index]
		{
			get;
		}

		public extern void AppendMedium(string newMedium);

		public extern void DeleteMedium(string oldMedium);

		public extern string Item(int index);

		public readonly int Length;

		public string MediaText;
	}
}
