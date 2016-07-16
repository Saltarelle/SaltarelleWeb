namespace Bridge.Html5
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class MimeType
	{
		internal extern MimeType();

		[FieldProperty]
		public extern string Description
		{
			get;
		}

		[FieldProperty]
		public extern Plugin EnabledPlugin
		{
			get;
		}

		[FieldProperty]
		public extern string Suffixes
		{
			get;
		}

		[FieldProperty]
		public extern string Type
		{
			get;
		}
	}
}
