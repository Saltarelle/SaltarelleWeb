namespace Bridge.Html5
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class History
	{
		internal extern History();

		public extern void Back();

		public extern void Forward();

		public extern void Go();

		public extern void Go(int delta);

		[FieldProperty]
		public extern int Length
		{
			get;
		}

		public extern void PushState(object data, string title);

		public extern void PushState(object data, string title, string url);

		public extern void ReplaceState(object data, string title);

		public extern void ReplaceState(object data, string title, string url);

		[FieldProperty]
		public extern object State
		{
			get;
		}
	}
}
