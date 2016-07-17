namespace Bridge.Html5.Media
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class TimeRanges
	{
		internal extern TimeRanges();

		public extern double End(int index);

		public readonly int Length;

		public extern double Start(int index);
	}
}
