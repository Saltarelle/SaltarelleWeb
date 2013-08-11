// SVGFEDistantLightElement.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
// 

using System.Runtime.CompilerServices;

namespace System.Html.Media.Graphics.SVG {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class SVGFEDistantLightElement : SVGElement {
		internal SVGFEDistantLightElement() {
		}

		[IntrinsicProperty]
		public SVGAnimatedNumber Azimuth {
			get { return default(SVGAnimatedNumber); }
		}

		[IntrinsicProperty]
		public SVGAnimatedNumber Elevation {
			get { return default(SVGAnimatedNumber); }
		}
	}
}
