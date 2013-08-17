using System.Runtime.CompilerServices;

namespace System.Html.Media.Graphics.SVG {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class SVGFETurbulenceElement : SVGElement {
		internal SVGFETurbulenceElement() {
		}

		void AddEventListener(string type, HtmlEventHandlerWithTarget<SVGFETurbulenceElement> listener) {
		}

		void AddEventListener(string type, HtmlEventHandlerWithTarget<SVGFETurbulenceElement> listener, bool capture) {
		}

		[IntrinsicProperty]
		public SVGAnimatedNumber BaseFrequencyX {
			get {
				return default(SVGAnimatedNumber);
			}
		}

		[IntrinsicProperty]
		public SVGAnimatedNumber BaseFrequencyY {
			get {
				return default(SVGAnimatedNumber);
			}
		}

		[IntrinsicProperty]
		public SVGAnimatedLength Height {
			get {
				return default(SVGAnimatedLength);
			}
		}

		[IntrinsicProperty]
		public SVGAnimatedInteger NumOctaves {
			get {
				return default(SVGAnimatedInteger);
			}
		}

		void RemoveEventListener(string type, HtmlEventHandlerWithTarget<SVGFETurbulenceElement> listener) {
		}

		void RemoveEventListener(string type, HtmlEventHandlerWithTarget<SVGFETurbulenceElement> listener, bool capture) {
		}

		[IntrinsicProperty]
		public SVGAnimatedString Result {
			get {
				return default(SVGAnimatedString);
			}
		}

		[IntrinsicProperty]
		public SVGAnimatedNumber Seed {
			get {
				return default(SVGAnimatedNumber);
			}
		}

		[IntrinsicProperty]
		public SVGAnimatedEnumeration<SVGFEStitchType> StitchTiles {
			get {
				return default(SVGAnimatedEnumeration<SVGFEStitchType>);
			}
		}

		[ScriptName("SVG_STITCHTYPE_NOSTITCH")]
		public const ushort SVG_STITCHTYPE_NOSTITCH = 2;

		[ScriptName("SVG_STITCHTYPE_STITCH")]
		public const ushort SVG_STITCHTYPE_STITCH = 1;

		[ScriptName("SVG_STITCHTYPE_UNKNOWN")]
		public const ushort SVG_STITCHTYPE_UNKNOWN = 0;

		[ScriptName("SVG_TURBULENCE_TYPE_FRACTALNOISE")]
		public const ushort SVG_TURBULENCE_TYPE_FRACTALNOISE = 1;

		[ScriptName("SVG_TURBULENCE_TYPE_TURBULENCE")]
		public const ushort SVG_TURBULENCE_TYPE_TURBULENCE = 2;

		[ScriptName("SVG_TURBULENCE_TYPE_UNKNOWN")]
		public const ushort SVG_TURBULENCE_TYPE_UNKNOWN = 0;

		[IntrinsicProperty]
		public SVGAnimatedEnumeration<SVGFETurbulenceType> Type {
			get {
				return default(SVGAnimatedEnumeration<SVGFETurbulenceType>);
			}
		}

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
