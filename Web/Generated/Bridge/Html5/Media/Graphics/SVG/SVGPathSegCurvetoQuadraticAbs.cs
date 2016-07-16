namespace Bridge.Html5.Media.Graphics.SVG
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class SVGPathSegCurvetoQuadraticAbs : SVGPathSeg
	{
		internal extern SVGPathSegCurvetoQuadraticAbs();

		[FieldProperty]
		public extern double X
		{
			get;
			set;
		}

		[FieldProperty]
		public extern double X1
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
		public extern double Y1
		{
			get;
			set;
		}
	}
}
