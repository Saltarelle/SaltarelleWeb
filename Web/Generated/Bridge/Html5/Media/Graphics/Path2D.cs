namespace Bridge.Html5.Media.Graphics
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class Path2D
	{
		public extern Path2D();

		public extern Path2D(Path2D other);

		public extern void Arc(double x, double y, double radius, double startAngle, double endAngle);

		public extern void Arc(double x, double y, double radius, double startAngle, double endAngle, bool anticlockwise);

		public extern void ArcTo(double x1, double y1, double x2, double y2, double radius);

		public extern void BezierCurveTo(double cp1x, double cp1y, double cp2x, double cp2y, double x, double y);

		public extern void ClosePath();

		public extern void LineTo(double x, double y);

		public extern void MoveTo(double x, double y);

		public extern void QuadraticCurveTo(double cpx, double cpy, double x, double y);

		public extern void Rect(double x, double y, double w, double h);
	}
}
