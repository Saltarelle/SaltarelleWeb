namespace Bridge.Html5
{
	[Namespace(false), External]
	public partial class DOMPoint : DOMPointReadOnly
	{
		public extern DOMPoint();

		public extern DOMPoint(DOMPointInit point);

		public extern DOMPoint(double x, double y);

		public extern DOMPoint(double x, double y, double z);

		public extern DOMPoint(double x, double y, double z, double w);

		public double W;

		public double X;

		public double Y;

		public double Z;
	}
}
