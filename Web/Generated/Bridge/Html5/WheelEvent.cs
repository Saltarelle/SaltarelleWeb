namespace Bridge.Html5
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class WheelEvent : MouseEvent
	{
		internal extern WheelEvent();

		public extern WheelEvent(string type);

		public extern WheelEvent(string type, WheelEventInit eventInitDict);

		[FieldProperty]
		public extern WheelDeltaMode DeltaMode
		{
			get;
		}

		[FieldProperty]
		public extern double DeltaX
		{
			get;
		}

		[FieldProperty]
		public extern double DeltaY
		{
			get;
		}

		[FieldProperty]
		public extern double DeltaZ
		{
			get;
		}

		[Name("DOM_DELTA_LINE")]
		public const int DOM_DELTA_LINE = 1;

		[Name("DOM_DELTA_PAGE")]
		public const int DOM_DELTA_PAGE = 2;

		[Name("DOM_DELTA_PIXEL")]
		public const int DOM_DELTA_PIXEL = 0;
	}
}
