namespace Bridge.Html5
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class DOMPoint : DOMPointReadOnly
	{
		public DOMPoint()
		{
		}

		public DOMPoint(DOMPointInit point)
		{
		}

		public DOMPoint(double x, double y)
		{
		}

		public DOMPoint(double x, double y, double z)
		{
		}

		public DOMPoint(double x, double y, double z, double w)
		{
		}

		[FieldProperty]
		public double W
		{
			get {
				return 0;
			}
			set {
			}
		}

		[FieldProperty]
		public double X
		{
			get {
				return 0;
			}
			set {
			}
		}

		[FieldProperty]
		public double Y
		{
			get {
				return 0;
			}
			set {
			}
		}

		[FieldProperty]
		public double Z
		{
			get {
				return 0;
			}
			set {
			}
		}
	}
}
