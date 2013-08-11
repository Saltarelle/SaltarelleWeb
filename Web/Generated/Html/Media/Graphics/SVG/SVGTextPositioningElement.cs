// SVGTextPositioningElement.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
// 

using System.Runtime.CompilerServices;

namespace System.Html.Media.Graphics.SVG {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class SVGTextPositioningElement : SVGTextContentElement {
		internal SVGTextPositioningElement() {
		}

		[IntrinsicProperty]
		public SVGAnimatedLengthList Dx {
			get { return default(SVGAnimatedLengthList); }
		}

		[IntrinsicProperty]
		public SVGAnimatedLengthList Dy {
			get { return default(SVGAnimatedLengthList); }
		}

		[IntrinsicProperty]
		public SVGAnimatedNumberList Rotate {
			get { return default(SVGAnimatedNumberList); }
		}

		[IntrinsicProperty]
		public SVGAnimatedLengthList X {
			get { return default(SVGAnimatedLengthList); }
		}

		[IntrinsicProperty]
		public SVGAnimatedLengthList Y {
			get { return default(SVGAnimatedLengthList); }
		}
	}
}
