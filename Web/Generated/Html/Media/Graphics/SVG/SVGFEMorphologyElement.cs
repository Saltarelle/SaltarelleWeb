using System.Runtime.CompilerServices;

namespace System.Html.Media.Graphics.SVG {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class SVGFEMorphologyElement : SVGElement {
		internal SVGFEMorphologyElement() {
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
		public SVGAnimatedEnumeration<SVGFEMorphologyOperator> Operator {
			get { return default(SVGAnimatedEnumeration<SVGFEMorphologyOperator>); }
		}

		[IntrinsicProperty]
		public SVGAnimatedNumber RadiusX {
			get { return default(SVGAnimatedNumber); }
		}

		[IntrinsicProperty]
		public SVGAnimatedNumber RadiusY {
			get { return default(SVGAnimatedNumber); }
		}

		[IntrinsicProperty]
		public SVGAnimatedString Result {
			get { return default(SVGAnimatedString); }
		}

		[ScriptName("SVG_MORPHOLOGY_OPERATOR_DILATE")]
		public const ushort SVG_MORPHOLOGY_OPERATOR_DILATE = 2;

		[ScriptName("SVG_MORPHOLOGY_OPERATOR_ERODE")]
		public const ushort SVG_MORPHOLOGY_OPERATOR_ERODE = 1;

		[ScriptName("SVG_MORPHOLOGY_OPERATOR_UNKNOWN")]
		public const ushort SVG_MORPHOLOGY_OPERATOR_UNKNOWN = 0;

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
