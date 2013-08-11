using System.Runtime.CompilerServices;

namespace System.Html.Media.Graphics.SVG {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class SVGFECompositeElement : SVGElement {
		internal SVGFECompositeElement() {
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
		public SVGAnimatedString In2 {
			get { return default(SVGAnimatedString); }
		}

		[IntrinsicProperty]
		public SVGAnimatedNumber K1 {
			get { return default(SVGAnimatedNumber); }
		}

		[IntrinsicProperty]
		public SVGAnimatedNumber K2 {
			get { return default(SVGAnimatedNumber); }
		}

		[IntrinsicProperty]
		public SVGAnimatedNumber K3 {
			get { return default(SVGAnimatedNumber); }
		}

		[IntrinsicProperty]
		public SVGAnimatedNumber K4 {
			get { return default(SVGAnimatedNumber); }
		}

		[IntrinsicProperty]
		public SVGAnimatedEnumeration<SVGFECompositeOperator> Operator {
			get { return default(SVGAnimatedEnumeration<SVGFECompositeOperator>); }
		}

		[IntrinsicProperty]
		public SVGAnimatedString Result {
			get { return default(SVGAnimatedString); }
		}

		[ScriptName("SVG_FECOMPOSITE_OPERATOR_ARITHMETIC")]
		public const ushort SVG_FECOMPOSITE_OPERATOR_ARITHMETIC = 6;

		[ScriptName("SVG_FECOMPOSITE_OPERATOR_ATOP")]
		public const ushort SVG_FECOMPOSITE_OPERATOR_ATOP = 4;

		[ScriptName("SVG_FECOMPOSITE_OPERATOR_IN")]
		public const ushort SVG_FECOMPOSITE_OPERATOR_IN = 2;

		[ScriptName("SVG_FECOMPOSITE_OPERATOR_OUT")]
		public const ushort SVG_FECOMPOSITE_OPERATOR_OUT = 3;

		[ScriptName("SVG_FECOMPOSITE_OPERATOR_OVER")]
		public const ushort SVG_FECOMPOSITE_OPERATOR_OVER = 1;

		[ScriptName("SVG_FECOMPOSITE_OPERATOR_UNKNOWN")]
		public const ushort SVG_FECOMPOSITE_OPERATOR_UNKNOWN = 0;

		[ScriptName("SVG_FECOMPOSITE_OPERATOR_XOR")]
		public const ushort SVG_FECOMPOSITE_OPERATOR_XOR = 5;

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
