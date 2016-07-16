namespace Bridge.Html5
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class PointerEvent : MouseEvent
	{
		internal PointerEvent()
		{
		}

		public PointerEvent(string type)
		{
		}

		public PointerEvent(string type, PointerEventInit eventInitDict)
		{
		}

		[FieldProperty]
		public int Height
		{
			get {
				return 0;
			}
		}

		[FieldProperty]
		public bool IsPrimary
		{
			get {
				return false;
			}
		}

		[FieldProperty]
		public int PointerId
		{
			get {
				return 0;
			}
		}

		[FieldProperty]
		public string PointerType
		{
			get {
				return null;
			}
		}

		[FieldProperty]
		public double Pressure
		{
			get {
				return 0;
			}
		}

		[FieldProperty]
		public int TiltX
		{
			get {
				return 0;
			}
		}

		[FieldProperty]
		public int TiltY
		{
			get {
				return 0;
			}
		}

		[FieldProperty]
		public int Width
		{
			get {
				return 0;
			}
		}
	}
}
