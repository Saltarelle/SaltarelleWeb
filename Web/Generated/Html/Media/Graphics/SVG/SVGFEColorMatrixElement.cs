using System.Runtime.CompilerServices;

namespace System.Html.Media.Graphics.SVG {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class SVGFEColorMatrixElement : SVGElement {
		internal SVGFEColorMatrixElement() {
		}

		[IntrinsicProperty]
		public SVGAnimatedLength Height {
			get { return default(SVGAnimatedLength); }
		}

		[IntrinsicProperty]
		public SVGAnimatedString In1 {
			get { return default(SVGAnimatedString); }
		}

		[IntrinsicProperty]
		public SVGAnimatedString Result {
			get { return default(SVGAnimatedString); }
		}

		[ScriptName("SVG_FECOLORMATRIX_TYPE_HUEROTATE")]
		public const ushort SVG_FECOLORMATRIX_TYPE_HUEROTATE = 3;

		[ScriptName("SVG_FECOLORMATRIX_TYPE_LUMINANCETOALPHA")]
		public const ushort SVG_FECOLORMATRIX_TYPE_LUMINANCETOALPHA = 4;

		[ScriptName("SVG_FECOLORMATRIX_TYPE_MATRIX")]
		public const ushort SVG_FECOLORMATRIX_TYPE_MATRIX = 1;

		[ScriptName("SVG_FECOLORMATRIX_TYPE_SATURATE")]
		public const ushort SVG_FECOLORMATRIX_TYPE_SATURATE = 2;

		[ScriptName("SVG_FECOLORMATRIX_TYPE_UNKNOWN")]
		public const ushort SVG_FECOLORMATRIX_TYPE_UNKNOWN = 0;

		[IntrinsicProperty]
		public SVGAnimatedEnumeration<SVGFEColorMatrixType> Type {
			get { return default(SVGAnimatedEnumeration<SVGFEColorMatrixType>); }
		}

		[IntrinsicProperty]
		public SVGAnimatedNumberList Values {
			get { return default(SVGAnimatedNumberList); }
		}

		[IntrinsicProperty]
		public SVGAnimatedLength Width {
			get { return default(SVGAnimatedLength); }
		}

		[IntrinsicProperty]
		public SVGAnimatedLength X {
			get { return default(SVGAnimatedLength); }
		}

		[IntrinsicProperty]
		public SVGAnimatedLength Y {
			get { return default(SVGAnimatedLength); }
		}
	}
}
