namespace Bridge.Html5
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class DOMPoint : DOMPointReadOnly
	{
		public extern DOMPoint();

		public extern DOMPoint(DOMPointInit point);

		public extern DOMPoint(double x, double y);

		public extern DOMPoint(double x, double y, double z);

		public extern DOMPoint(double x, double y, double z, double w);

		[FieldProperty]
		public extern double W
		{
			get;
			set;
		}

		[FieldProperty]
		public extern double X
		{
			get;
			set;
		}

		[FieldProperty]
		public extern double Y
		{
			get;
			set;
		}

		[FieldProperty]
		public extern double Z
		{
			get;
			set;
		}
	}
}
