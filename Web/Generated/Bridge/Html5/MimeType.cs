namespace Bridge.Html5
{
	[Namespace(false), External]
	public partial class MimeType
	{
		internal extern MimeType();

		public readonly string Description;

		public readonly Plugin EnabledPlugin;

		public readonly string Suffixes;

		public readonly string Type;
	}
}
