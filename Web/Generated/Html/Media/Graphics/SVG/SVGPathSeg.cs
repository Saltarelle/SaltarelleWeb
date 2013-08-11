using System.Runtime.CompilerServices;

namespace System.Html.Media.Graphics.SVG {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class SVGPathSeg {
		internal SVGPathSeg() {
		}

		[ScriptName("PATHSEG_ARC_ABS")]
		public const ushort PATHSEG_ARC_ABS = 10;

		[ScriptName("PATHSEG_ARC_REL")]
		public const ushort PATHSEG_ARC_REL = 11;

		[ScriptName("PATHSEG_CLOSEPATH")]
		public const ushort PATHSEG_CLOSEPATH = 1;

		[ScriptName("PATHSEG_CURVETO_CUBIC_ABS")]
		public const ushort PATHSEG_CURVETO_CUBIC_ABS = 6;

		[ScriptName("PATHSEG_CURVETO_CUBIC_REL")]
		public const ushort PATHSEG_CURVETO_CUBIC_REL = 7;

		[ScriptName("PATHSEG_CURVETO_CUBIC_SMOOTH_ABS")]
		public const ushort PATHSEG_CURVETO_CUBIC_SMOOTH_ABS = 16;

		[ScriptName("PATHSEG_CURVETO_CUBIC_SMOOTH_REL")]
		public const ushort PATHSEG_CURVETO_CUBIC_SMOOTH_REL = 17;

		[ScriptName("PATHSEG_CURVETO_QUADRATIC_ABS")]
		public const ushort PATHSEG_CURVETO_QUADRATIC_ABS = 8;

		[ScriptName("PATHSEG_CURVETO_QUADRATIC_REL")]
		public const ushort PATHSEG_CURVETO_QUADRATIC_REL = 9;

		[ScriptName("PATHSEG_CURVETO_QUADRATIC_SMOOTH_ABS")]
		public const ushort PATHSEG_CURVETO_QUADRATIC_SMOOTH_ABS = 18;

		[ScriptName("PATHSEG_CURVETO_QUADRATIC_SMOOTH_REL")]
		public const ushort PATHSEG_CURVETO_QUADRATIC_SMOOTH_REL = 19;

		[ScriptName("PATHSEG_LINETO_ABS")]
		public const ushort PATHSEG_LINETO_ABS = 4;

		[ScriptName("PATHSEG_LINETO_HORIZONTAL_ABS")]
		public const ushort PATHSEG_LINETO_HORIZONTAL_ABS = 12;

		[ScriptName("PATHSEG_LINETO_HORIZONTAL_REL")]
		public const ushort PATHSEG_LINETO_HORIZONTAL_REL = 13;

		[ScriptName("PATHSEG_LINETO_REL")]
		public const ushort PATHSEG_LINETO_REL = 5;

		[ScriptName("PATHSEG_LINETO_VERTICAL_ABS")]
		public const ushort PATHSEG_LINETO_VERTICAL_ABS = 14;

		[ScriptName("PATHSEG_LINETO_VERTICAL_REL")]
		public const ushort PATHSEG_LINETO_VERTICAL_REL = 15;

		[ScriptName("PATHSEG_MOVETO_ABS")]
		public const ushort PATHSEG_MOVETO_ABS = 2;

		[ScriptName("PATHSEG_MOVETO_REL")]
		public const ushort PATHSEG_MOVETO_REL = 3;

		[ScriptName("PATHSEG_UNKNOWN")]
		public const ushort PATHSEG_UNKNOWN = 0;

		[IntrinsicProperty]
		public SVGPathSegType PathSegType {
			get { return default(SVGPathSegType); }
		}

		[IntrinsicProperty]
		public string PathSegTypeAsLetter {
			get { return null; }
		}
	}
}
