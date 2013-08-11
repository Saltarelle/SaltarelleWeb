// SVGAnimatedLength.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
// 

using System.Runtime.CompilerServices;

namespace System.Html.Media.Graphics.SVG {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class SVGAnimatedLength {
		internal SVGAnimatedLength() {
		}

		[IntrinsicProperty]
		public SVGLength AnimVal {
			get { return default(SVGLength); }
		}

		[IntrinsicProperty]
		public SVGLength BaseVal {
			get { return default(SVGLength); }
		}
	}
}
