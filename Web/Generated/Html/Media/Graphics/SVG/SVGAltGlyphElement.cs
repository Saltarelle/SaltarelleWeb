// SVGAltGlyphElement.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
// 

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
