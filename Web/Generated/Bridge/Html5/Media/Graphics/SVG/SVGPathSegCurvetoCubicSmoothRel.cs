namespace Bridge.Html5.Media.Graphics.SVG
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class SVGPathSegCurvetoCubicSmoothRel : SVGPathSeg
	{
		internal extern SVGPathSegCurvetoCubicSmoothRel();

		[FieldProperty]
		public extern double X
		{
			get;
			set;
		}

		[FieldProperty]
		public extern double X2
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
		public extern double Y2
		{
			get;
			set;
		}
	}
}
