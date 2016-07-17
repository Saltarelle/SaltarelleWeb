namespace Bridge.Html5
{
	[Namespace("false"), External]
	public partial class Plugin
	{
		internal extern Plugin();

		public extern MimeType this[int index]
		{
			get;
		}

		public extern MimeType this[string name]
		{
			get;
		}

		public readonly string Description;

		public readonly string Filename;

		public extern MimeType Item(int index);

		public readonly int Length;

		public readonly string Name;

		public extern MimeType NamedItem(string name);

		public readonly string Version;
	}
}
