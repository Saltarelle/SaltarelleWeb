namespace Bridge.Html5.Media.Graphics.SVG
{
	[Namespace(false), External]
	public partial class SVGPoint
	{
		internal extern SVGPoint();

		public extern SVGPoint MatrixTransform(SVGMatrix matrix);

		public double X;

		public double Y;
	}
}
