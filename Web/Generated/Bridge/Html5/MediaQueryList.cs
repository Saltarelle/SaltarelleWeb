namespace Bridge.Html5
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class MediaQueryList
	{
		internal extern MediaQueryList();

		public extern void AddListener(MediaQueryListListener listener);

		[FieldProperty]
		public extern bool Matches
		{
			get;
		}

		[FieldProperty]
		public extern string Media
		{
			get;
		}

		public extern void RemoveListener(MediaQueryListListener listener);
	}
}
