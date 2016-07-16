namespace Bridge.Html5.Media.Graphics.SVG
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class SVGPathSegCurvetoCubicRel : SVGPathSeg
	{
		internal extern SVGPathSegCurvetoCubicRel();

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
		public extern double Y1
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
