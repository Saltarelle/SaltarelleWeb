namespace Bridge.Html5
{
	[Namespace("false"), External]
	public partial class History
	{
		internal extern History();

		public extern void Back();

		public extern void Forward();

		public extern void Go();

		public extern void Go(int delta);

		public readonly int Length;

		public extern void PushState(object data, string title);

		public extern void PushState(object data, string title, string url);

		public extern void ReplaceState(object data, string title);

		public extern void ReplaceState(object data, string title, string url);

		public readonly object State;
	}
}
