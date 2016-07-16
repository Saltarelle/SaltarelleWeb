namespace Bridge.Html5
{
	[External, Serializable]
	public partial class PointerEventInit : MouseEventInit
	{
		public extern int Height
		{
			get;
			set;
		}

		public extern bool IsPrimary
		{
			get;
			set;
		}

		public extern int PointerId
		{
			get;
			set;
		}

		public extern string PointerType
		{
			get;
			set;
		}

		public extern double Pressure
		{
			get;
			set;
		}

		public extern int TiltX
		{
			get;
			set;
		}

		public extern int TiltY
		{
			get;
			set;
		}

		public extern int Width
		{
			get;
			set;
		}
	}
}
