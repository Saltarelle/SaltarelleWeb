namespace Bridge.Html5
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class WheelEvent : MouseEvent
	{
		internal WheelEvent()
		{
		}

		public WheelEvent(string type)
		{
		}

		public WheelEvent(string type, WheelEventInit eventInitDict)
		{
		}

		[FieldProperty]
		public WheelDeltaMode DeltaMode
		{
			get {
				return default(WheelDeltaMode);
			}
		}

		[FieldProperty]
		public double DeltaX
		{
			get {
				return 0;
			}
		}

		[FieldProperty]
		public double DeltaY
		{
			get {
				return 0;
			}
		}

		[FieldProperty]
		public double DeltaZ
		{
			get {
				return 0;
			}
		}

		[Name("DOM_DELTA_LINE")]
		public const int DOM_DELTA_LINE = 1;

		[Name("DOM_DELTA_PAGE")]
		public const int DOM_DELTA_PAGE = 2;

		[Name("DOM_DELTA_PIXEL")]
		public const int DOM_DELTA_PIXEL = 0;
	}
}
