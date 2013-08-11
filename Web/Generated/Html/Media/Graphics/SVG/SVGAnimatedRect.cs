// SVGAnimatedRect.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
// 

using System.Runtime.CompilerServices;

namespace System.Html.Media.Graphics.SVG {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class SVGAnimatedRect {
		internal SVGAnimatedRect() {
		}

		[IntrinsicProperty]
		public SVGRect AnimVal {
			get { return default(SVGRect); }
		}

		[IntrinsicProperty]
		public SVGRect BaseVal {
			get { return default(SVGRect); }
		}
	}
}
