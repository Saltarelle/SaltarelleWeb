// SVGPolylineElement.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
// 

using System.Runtime.CompilerServices;

namespace System.Html.Media.Graphics.SVG {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class SVGPolylineElement : SVGGraphicsElement {
		internal SVGPolylineElement() {
		}

		[IntrinsicProperty]
		public SVGPointList AnimatedPoints {
			get { return default(SVGPointList); }
		}

		[IntrinsicProperty]
		public SVGPointList Points {
			get { return default(SVGPointList); }
		}
	}
}
