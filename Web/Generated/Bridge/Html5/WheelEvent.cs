namespace Bridge.Html5
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class WheelEvent : MouseEvent
	{
		internal extern WheelEvent();

		public extern WheelEvent(string type);

		public extern WheelEvent(string type, WheelEventInit eventInitDict);

		public readonly WheelDeltaMode DeltaMode;

		public readonly double DeltaX;

		public readonly double DeltaY;

		public readonly double DeltaZ;

		[Name("DOM_DELTA_LINE")]
		public const int DOM_DELTA_LINE = 1;

		[Name("DOM_DELTA_PAGE")]
		public const int DOM_DELTA_PAGE = 2;

		[Name("DOM_DELTA_PIXEL")]
		public const int DOM_DELTA_PIXEL = 0;
	}
}
