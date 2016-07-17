namespace Bridge.Html5
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class PointerEvent : MouseEvent
	{
		internal extern PointerEvent();

		public extern PointerEvent(string type);

		public extern PointerEvent(string type, PointerEventInit eventInitDict);

		public readonly int Height;

		public readonly bool IsPrimary;

		public readonly int PointerId;

		public readonly string PointerType;

		public readonly double Pressure;

		public readonly int TiltX;

		public readonly int TiltY;

		public readonly int Width;
	}
}
