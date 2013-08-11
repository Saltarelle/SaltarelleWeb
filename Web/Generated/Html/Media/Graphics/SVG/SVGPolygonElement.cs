using System.Runtime.CompilerServices;

namespace System.Html.Media.Graphics.SVG {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class SVGPolygonElement : SVGGraphicsElement {
		internal SVGPolygonElement() {
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
