namespace Bridge.Html5
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class MediaQueryList
	{
		internal MediaQueryList()
		{
		}

		public void AddListener(MediaQueryListListener listener)
		{
		}

		[FieldProperty]
		public bool Matches
		{
			get {
				return false;
			}
		}

		[FieldProperty]
		public string Media
		{
			get {
				return null;
			}
		}

		public void RemoveListener(MediaQueryListListener listener)
		{
		}
	}
}
