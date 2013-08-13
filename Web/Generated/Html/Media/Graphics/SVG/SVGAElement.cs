using System.Runtime.CompilerServices;

namespace System.Html.Media.Graphics.SVG {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class SVGAElement : SVGGraphicsElement {
		internal SVGAElement() {
		}

		[IntrinsicProperty]
		public string Download {
			get {
				return null;
			}
			set {
			}
		}

		[IntrinsicProperty]
		public SVGAnimatedString Href {
			get {
				return default(SVGAnimatedString);
			}
		}

		[IntrinsicProperty]
		public SVGAnimatedString Target {
			get {
				return default(SVGAnimatedString);
			}
		}
	}
}
