namespace Bridge.Html5
{
	[Namespace("false"), External]
	public partial class MimeTypeArray
	{
		internal extern MimeTypeArray();

		public extern MimeType this[int index]
		{
			get;
		}

		public extern MimeType this[string name]
		{
			get;
		}

		public extern MimeType Item(int index);

		public readonly int Length;

		public extern MimeType NamedItem(string name);
	}
}
