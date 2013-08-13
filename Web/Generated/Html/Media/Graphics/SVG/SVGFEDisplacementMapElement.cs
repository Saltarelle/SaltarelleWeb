using System.Runtime.CompilerServices;

namespace System.Html.Media.Graphics.SVG {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class SVGFEDisplacementMapElement : SVGElement {
		internal SVGFEDisplacementMapElement() {
		}

		[IntrinsicProperty]
		public SVGAnimatedLength Height {
			get {
				return default(SVGAnimatedLength);
			}
		}

		[IntrinsicProperty]
		public SVGAnimatedString In1 {
			get {
				return default(SVGAnimatedString);
			}
		}

		[IntrinsicProperty]
		public SVGAnimatedString In2 {
			get {
				return default(SVGAnimatedString);
			}
		}

		[IntrinsicProperty]
		public SVGAnimatedString Result {
			get {
				return default(SVGAnimatedString);
			}
		}

		[IntrinsicProperty]
		public SVGAnimatedNumber Scale {
			get {
				return default(SVGAnimatedNumber);
			}
		}

		[ScriptName("SVG_CHANNEL_A")]
		public const ushort SVG_CHANNEL_A = 4;

		[ScriptName("SVG_CHANNEL_B")]
		public const ushort SVG_CHANNEL_B = 3;

		[ScriptName("SVG_CHANNEL_G")]
		public const ushort SVG_CHANNEL_G = 2;

		[ScriptName("SVG_CHANNEL_R")]
		public const ushort SVG_CHANNEL_R = 1;

		[ScriptName("SVG_CHANNEL_UNKNOWN")]
		public const ushort SVG_CHANNEL_UNKNOWN = 0;

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
		public SVGAnimatedEnumeration<SVGFEDisplacementMapChannelSelector> XChannelSelector {
			get {
				return default(SVGAnimatedEnumeration<SVGFEDisplacementMapChannelSelector>);
			}
		}

		[IntrinsicProperty]
		public SVGAnimatedLength Y {
			get {
				return default(SVGAnimatedLength);
			}
		}

		[IntrinsicProperty]
		public SVGAnimatedEnumeration<SVGFEDisplacementMapChannelSelector> YChannelSelector {
			get {
				return default(SVGAnimatedEnumeration<SVGFEDisplacementMapChannelSelector>);
			}
		}
	}
}
