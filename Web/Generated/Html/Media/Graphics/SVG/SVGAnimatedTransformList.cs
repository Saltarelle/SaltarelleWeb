// SVGAnimatedTransformList.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
// 

using System.Runtime.CompilerServices;

namespace System.Html.Media.Graphics.SVG {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class SVGAnimatedTransformList {
		internal SVGAnimatedTransformList() {
		}

		[IntrinsicProperty]
		public SVGTransformList AnimVal {
			get { return default(SVGTransformList); }
		}

		[IntrinsicProperty]
		public SVGTransformList BaseVal {
			get { return default(SVGTransformList); }
		}
	}
}
