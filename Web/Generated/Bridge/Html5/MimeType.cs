namespace Bridge.Html5
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class MimeType
	{
		internal MimeType()
		{
		}

		[FieldProperty]
		public string Description
		{
			get {
				return null;
			}
		}

		[FieldProperty]
		public Plugin EnabledPlugin
		{
			get {
				return default(Plugin);
			}
		}

		[FieldProperty]
		public string Suffixes
		{
			get {
				return null;
			}
		}

		[FieldProperty]
		public string Type
		{
			get {
				return null;
			}
		}
	}
}
