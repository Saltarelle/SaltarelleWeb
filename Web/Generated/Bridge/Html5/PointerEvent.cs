namespace Bridge.Html5
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class PointerEvent : MouseEvent
	{
		internal extern PointerEvent();

		public extern PointerEvent(string type);

		public extern PointerEvent(string type, PointerEventInit eventInitDict);

		[FieldProperty]
		public extern int Height
		{
			get;
		}

		[FieldProperty]
		public extern bool IsPrimary
		{
			get;
		}

		[FieldProperty]
		public extern int PointerId
		{
			get;
		}

		[FieldProperty]
		public extern string PointerType
		{
			get;
		}

		[FieldProperty]
		public extern double Pressure
		{
			get;
		}

		[FieldProperty]
		public extern int TiltX
		{
			get;
		}

		[FieldProperty]
		public extern int TiltY
		{
			get;
		}

		[FieldProperty]
		public extern int Width
		{
			get;
		}
	}
}
