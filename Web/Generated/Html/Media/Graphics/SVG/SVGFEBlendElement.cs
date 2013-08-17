using System.Runtime.CompilerServices;

namespace System.Html.Media.Graphics.SVG {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class SVGFEBlendElement : SVGElement {
		internal SVGFEBlendElement() {
		}

		void AddEventListener(string type, HtmlEventHandlerWithTarget<SVGFEBlendElement> listener) {
		}

		void AddEventListener(string type, HtmlEventHandlerWithTarget<SVGFEBlendElement> listener, bool capture) {
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
		public SVGAnimatedEnumeration<SVGFEBlendMode> Mode {
			get {
				return default(SVGAnimatedEnumeration<SVGFEBlendMode>);
			}
		}

		void RemoveEventListener(string type, HtmlEventHandlerWithTarget<SVGFEBlendElement> listener) {
		}

		void RemoveEventListener(string type, HtmlEventHandlerWithTarget<SVGFEBlendElement> listener, bool capture) {
		}

		[IntrinsicProperty]
		public SVGAnimatedString Result {
			get {
				return default(SVGAnimatedString);
			}
		}

		[ScriptName("SVG_FEBLEND_MODE_DARKEN")]
		public const ushort SVG_FEBLEND_MODE_DARKEN = 4;

		[ScriptName("SVG_FEBLEND_MODE_LIGHTEN")]
		public const ushort SVG_FEBLEND_MODE_LIGHTEN = 5;

		[ScriptName("SVG_FEBLEND_MODE_MULTIPLY")]
		public const ushort SVG_FEBLEND_MODE_MULTIPLY = 2;

		[ScriptName("SVG_FEBLEND_MODE_NORMAL")]
		public const ushort SVG_FEBLEND_MODE_NORMAL = 1;

		[ScriptName("SVG_FEBLEND_MODE_SCREEN")]
		public const ushort SVG_FEBLEND_MODE_SCREEN = 3;

		[ScriptName("SVG_FEBLEND_MODE_UNKNOWN")]
		public const ushort SVG_FEBLEND_MODE_UNKNOWN = 0;

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
