namespace Bridge.Html5.Media.Graphics.SVG
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class SVGPathSegArcRel : SVGPathSeg
	{
		internal extern SVGPathSegArcRel();

		[FieldProperty]
		public extern double Angle
		{
			get;
			set;
		}

		[FieldProperty]
		public extern bool LargeArcFlag
		{
			get;
			set;
		}

		[FieldProperty]
		public extern double R1
		{
			get;
			set;
		}

		[FieldProperty]
		public extern double R2
		{
			get;
			set;
		}

		[FieldProperty]
		public extern bool SweepFlag
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
	}
}
