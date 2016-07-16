namespace Bridge.Html5
{
	[External, Serializable]
	public partial class WheelEventInit : MouseEventInit
	{
		public extern int DeltaMode
		{
			get;
			set;
		}

		public extern double DeltaX
		{
			get;
			set;
		}

		public extern double DeltaY
		{
			get;
			set;
		}

		public extern double DeltaZ
		{
			get;
			set;
		}
	}
}
