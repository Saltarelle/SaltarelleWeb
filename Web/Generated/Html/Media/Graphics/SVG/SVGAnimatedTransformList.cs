using System.Runtime.CompilerServices;

namespace System.Html.Media.Graphics.SVG {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class SVGAnimatedTransformList {
		internal SVGAnimatedTransformList() {
		}

		[IntrinsicProperty]
		public SVGTransformList AnimVal {
			get {
				return default(SVGTransformList);
			}
		}

		[IntrinsicProperty]
		public SVGTransformList BaseVal {
			get {
				return default(SVGTransformList);
			}
		}
	}
}
