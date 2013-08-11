// SVGImageElement.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
// 

using System.Runtime.CompilerServices;

namespace System.Html.Media.Graphics.SVG {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class SVGImageElement : SVGGraphicsElement {
		internal SVGImageElement() {
		}

		[IntrinsicProperty]
		public SVGAnimatedLength Height {
			get { return default(SVGAnimatedLength); }
		}

		[IntrinsicProperty]
		public SVGAnimatedString Href {
			get { return default(SVGAnimatedString); }
		}

		[IntrinsicProperty]
		public SVGAnimatedPreserveAspectRatio PreserveAspectRatio {
			get { return default(SVGAnimatedPreserveAspectRatio); }
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
