// SVGAnimatedLengthList.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
// 

using System.Runtime.CompilerServices;

namespace System.Html.Media.Graphics.SVG {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class SVGAnimatedLengthList {
		internal SVGAnimatedLengthList() {
		}

		[IntrinsicProperty]
		public SVGLengthList AnimVal {
			get { return default(SVGLengthList); }
		}

		[IntrinsicProperty]
		public SVGLengthList BaseVal {
			get { return default(SVGLengthList); }
		}
	}
}
