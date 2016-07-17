namespace Bridge.Html5
{
	[Namespace(false), External]
	public partial class MediaQueryList
	{
		internal extern MediaQueryList();

		public extern void AddListener(MediaQueryListListener listener);

		public readonly bool Matches;

		public readonly string Media;

		public extern void RemoveListener(MediaQueryListListener listener);
	}
}
