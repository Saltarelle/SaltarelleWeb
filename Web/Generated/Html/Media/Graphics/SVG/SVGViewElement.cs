// SVGViewElement.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
// 

using System.Runtime.CompilerServices;

namespace System.Html.Media.Graphics.SVG {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class SVGViewElement : SVGElement {
		internal SVGViewElement() {
		}

		[IntrinsicProperty]
		public SVGAnimatedPreserveAspectRatio PreserveAspectRatio {
			get { return default(SVGAnimatedPreserveAspectRatio); }
		}

		[ScriptName("SVG_ZOOMANDPAN_DISABLE")]
		public const ushort SVG_ZOOMANDPAN_DISABLE = 1;

		[ScriptName("SVG_ZOOMANDPAN_MAGNIFY")]
		public const ushort SVG_ZOOMANDPAN_MAGNIFY = 2;

		[ScriptName("SVG_ZOOMANDPAN_UNKNOWN")]
		public const ushort SVG_ZOOMANDPAN_UNKNOWN = 0;

		[IntrinsicProperty]
		public SVGAnimatedRect ViewBox {
			get { return default(SVGAnimatedRect); }
		}

		[IntrinsicProperty]
		public SVGStringList ViewTarget {
			get { return default(SVGStringList); }
		}

		[IntrinsicProperty]
		public SVGZoomAndPanType ZoomAndPan {
			get { return default(SVGZoomAndPanType); }
			set { }
		}
	}
}
