namespace Bridge.Html5.Media.Graphics.SVG
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class SVGPathSeg
	{
		internal extern SVGPathSeg();

		[Name("PATHSEG_ARC_ABS")]
		public const ushort PATHSEG_ARC_ABS = 10;

		[Name("PATHSEG_ARC_REL")]
		public const ushort PATHSEG_ARC_REL = 11;

		[Name("PATHSEG_CLOSEPATH")]
		public const ushort PATHSEG_CLOSEPATH = 1;

		[Name("PATHSEG_CURVETO_CUBIC_ABS")]
		public const ushort PATHSEG_CURVETO_CUBIC_ABS = 6;

		[Name("PATHSEG_CURVETO_CUBIC_REL")]
		public const ushort PATHSEG_CURVETO_CUBIC_REL = 7;

		[Name("PATHSEG_CURVETO_CUBIC_SMOOTH_ABS")]
		public const ushort PATHSEG_CURVETO_CUBIC_SMOOTH_ABS = 16;

		[Name("PATHSEG_CURVETO_CUBIC_SMOOTH_REL")]
		public const ushort PATHSEG_CURVETO_CUBIC_SMOOTH_REL = 17;

		[Name("PATHSEG_CURVETO_QUADRATIC_ABS")]
		public const ushort PATHSEG_CURVETO_QUADRATIC_ABS = 8;

		[Name("PATHSEG_CURVETO_QUADRATIC_REL")]
		public const ushort PATHSEG_CURVETO_QUADRATIC_REL = 9;

		[Name("PATHSEG_CURVETO_QUADRATIC_SMOOTH_ABS")]
		public const ushort PATHSEG_CURVETO_QUADRATIC_SMOOTH_ABS = 18;

		[Name("PATHSEG_CURVETO_QUADRATIC_SMOOTH_REL")]
		public const ushort PATHSEG_CURVETO_QUADRATIC_SMOOTH_REL = 19;

		[Name("PATHSEG_LINETO_ABS")]
		public const ushort PATHSEG_LINETO_ABS = 4;

		[Name("PATHSEG_LINETO_HORIZONTAL_ABS")]
		public const ushort PATHSEG_LINETO_HORIZONTAL_ABS = 12;

		[Name("PATHSEG_LINETO_HORIZONTAL_REL")]
		public const ushort PATHSEG_LINETO_HORIZONTAL_REL = 13;

		[Name("PATHSEG_LINETO_REL")]
		public const ushort PATHSEG_LINETO_REL = 5;

		[Name("PATHSEG_LINETO_VERTICAL_ABS")]
		public const ushort PATHSEG_LINETO_VERTICAL_ABS = 14;

		[Name("PATHSEG_LINETO_VERTICAL_REL")]
		public const ushort PATHSEG_LINETO_VERTICAL_REL = 15;

		[Name("PATHSEG_MOVETO_ABS")]
		public const ushort PATHSEG_MOVETO_ABS = 2;

		[Name("PATHSEG_MOVETO_REL")]
		public const ushort PATHSEG_MOVETO_REL = 3;

		[Name("PATHSEG_UNKNOWN")]
		public const ushort PATHSEG_UNKNOWN = 0;

		[FieldProperty]
		public extern SVGPathSegType PathSegType
		{
			get;
		}

		[FieldProperty]
		public extern string PathSegTypeAsLetter
		{
			get;
		}
	}
}
