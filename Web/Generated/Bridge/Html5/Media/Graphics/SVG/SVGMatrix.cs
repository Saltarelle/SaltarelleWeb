namespace Bridge.Html5.Media.Graphics.SVG
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class SVGMatrix
	{
		internal extern SVGMatrix();

		[FieldProperty]
		public extern double A
		{
			get;
			set;
		}

		[FieldProperty]
		public extern double B
		{
			get;
			set;
		}

		[FieldProperty]
		public extern double C
		{
			get;
			set;
		}

		[FieldProperty]
		public extern double D
		{
			get;
			set;
		}

		[FieldProperty]
		public extern double E
		{
			get;
			set;
		}

		[FieldProperty]
		public extern double F
		{
			get;
			set;
		}

		public extern SVGMatrix FlipX();

		public extern SVGMatrix FlipY();

		public extern SVGMatrix Inverse();

		public extern SVGMatrix Multiply(SVGMatrix secondMatrix);

		public extern SVGMatrix Rotate(double angle);

		public extern SVGMatrix RotateFromVector(double x, double y);

		public extern SVGMatrix Scale(double scaleFactor);

		public extern SVGMatrix ScaleNonUniform(double scaleFactorX, double scaleFactorY);

		public extern SVGMatrix SkewX(double angle);

		public extern SVGMatrix SkewY(double angle);

		public extern SVGMatrix Translate(double x, double y);
	}
}
