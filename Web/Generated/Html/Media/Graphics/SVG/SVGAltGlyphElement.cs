using System.Runtime.CompilerServices;

namespace System.Html.Media.Graphics.SVG {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class SVGAltGlyphElement : SVGTextPositioningElement {
		internal SVGAltGlyphElement() {
		}

		[IntrinsicProperty]
		public string Format {
			get { return null; }
			set { }
		}

		[IntrinsicProperty]
		public string GlyphRef {
			get { return null; }
			set { }
		}

		[IntrinsicProperty]
		public SVGAnimatedString Href {
			get { return default(SVGAnimatedString); }
		}
	}
}
