namespace Bridge.Html5
{
	[Namespace("false"), External]
	public partial class MediaList
	{
		internal extern MediaList();

		public extern string this[int index]
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
