namespace Bridge.Html5
{
	[External, Serializable]
	public partial class PointerEventInit : MouseEventInit
	{
		public int Height
		{
			get;
			set;
		}

		public bool IsPrimary
		{
			get;
			set;
		}

		public int PointerId
		{
			get;
			set;
		}

		public string PointerType
		{
			get;
			set;
		}

		public double Pressure
		{
			get;
			set;
		}

		public int TiltX
		{
			get;
			set;
		}

		public int TiltY
		{
			get;
			set;
		}

		public int Width
		{
			get;
			set;
		}
	}
}
