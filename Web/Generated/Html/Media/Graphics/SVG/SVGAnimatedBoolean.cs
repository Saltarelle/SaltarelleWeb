// SVGAnimatedBoolean.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
// 

using System.Runtime.CompilerServices;

namespace System.Html.Media.Graphics.SVG {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class SVGAnimatedBoolean {
		internal SVGAnimatedBoolean() {
		}

		[IntrinsicProperty]
		public bool AnimVal {
			get { return false; }
		}

		[IntrinsicProperty]
		public bool BaseVal {
			get { return false; }
			set { }
		}
	}
}
