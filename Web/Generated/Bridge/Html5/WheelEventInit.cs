namespace Bridge.Html5
{
	[External, Serializable]
	public partial class WheelEventInit : MouseEventInit
	{
		public int DeltaMode
		{
			get;
			set;
		}

		public double DeltaX
		{
			get;
			set;
		}

		public double DeltaY
		{
			get;
			set;
		}

		public double DeltaZ
		{
			get;
			set;
		}
	}
}
