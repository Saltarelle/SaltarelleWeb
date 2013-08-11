// SVGFEGaussianBlurElement.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
// 

using System.Runtime.CompilerServices;

namespace System.Html.Media.Graphics.SVG {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class SVGFEGaussianBlurElement : SVGElement {
		internal SVGFEGaussianBlurElement() {
		}

		[IntrinsicProperty]
		public SVGAnimatedString In1 {
			get { return default(SVGAnimatedString); }
		}

		public void SetStdDeviation(float stdDeviationX, float stdDeviationY) {
		}

		[IntrinsicProperty]
		public SVGAnimatedNumber StdDeviationX {
			get { return default(SVGAnimatedNumber); }
		}

		[IntrinsicProperty]
		public SVGAnimatedNumber StdDeviationY {
			get { return default(SVGAnimatedNumber); }
		}
	}
}
