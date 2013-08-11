// SVGAnimatedEnumeration.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
// 

using System.Runtime.CompilerServices;

namespace System.Html.Media.Graphics.SVG {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class SVGAnimatedEnumeration<TEnumeration> where TEnumeration : struct {
		private SVGAnimatedEnumeration() {
		}

		[IntrinsicProperty]
		public TEnumeration AnimVal {
			get { return default(TEnumeration); }
		}

		[IntrinsicProperty]
		public TEnumeration BaseVal {
			get { return default(TEnumeration); }
			set { }
		}
	}
}
