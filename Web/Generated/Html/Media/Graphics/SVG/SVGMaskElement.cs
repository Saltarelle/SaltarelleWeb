using System.Runtime.CompilerServices;

namespace System.Html.Media.Graphics.SVG {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class SVGMaskElement : SVGElement {
		internal SVGMaskElement() {
		}

		[IntrinsicProperty]
		public SVGAnimatedLength Height {
			get {
				return default(SVGAnimatedLength);
			}
		}

		[IntrinsicProperty]
		public SVGAnimatedEnumeration<SVGUnitType> MaskContentUnits {
			get {
				return default(SVGAnimatedEnumeration<SVGUnitType>);
			}
		}

		[IntrinsicProperty]
		public SVGAnimatedEnumeration<SVGUnitType> MaskUnits {
			get {
				return default(SVGAnimatedEnumeration<SVGUnitType>);
			}
		}

		[ScriptName("SVG_MASKTYPE_ALPHA")]
		public const ushort SVG_MASKTYPE_ALPHA = 1;

		[ScriptName("SVG_MASKTYPE_LUMINANCE")]
		public const ushort SVG_MASKTYPE_LUMINANCE = 0;

		[ScriptName("SVG_UNIT_TYPE_OBJECTBOUNDINGBOX")]
		public const ushort SVG_UNIT_TYPE_OBJECTBOUNDINGBOX = 2;

		[ScriptName("SVG_UNIT_TYPE_UNKNOWN")]
		public const ushort SVG_UNIT_TYPE_UNKNOWN = 0;

		[ScriptName("SVG_UNIT_TYPE_USERSPACEONUSE")]
		public const ushort SVG_UNIT_TYPE_USERSPACEONUSE = 1;

		[IntrinsicProperty]
		public SVGAnimatedLength Width {
			get {
				return default(SVGAnimatedLength);
			}
		}

		[IntrinsicProperty]
		public SVGAnimatedLength X {
			get {
				return default(SVGAnimatedLength);
			}
		}

		[IntrinsicProperty]
		public SVGAnimatedLength Y {
			get {
				return default(SVGAnimatedLength);
			}
		}
	}
}
