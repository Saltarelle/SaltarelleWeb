// SVGPathSegLinetoVerticalAbs.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
// 

using System.Runtime.CompilerServices;

namespace System.Html.Media.Graphics.SVG {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class SVGPathSegLinetoVerticalAbs : SVGPathSeg {
		internal SVGPathSegLinetoVerticalAbs() {
		}

		[IntrinsicProperty]
		public float Y {
			get { return 0; }
			set { }
		}
	}
}
