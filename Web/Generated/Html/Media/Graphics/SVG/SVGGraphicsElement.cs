using System.Runtime.CompilerServices;

namespace System.Html.Media.Graphics.SVG {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class SVGGraphicsElement : SVGElement {
		internal SVGGraphicsElement() {
		}

		[IntrinsicProperty]
		public SVGElement FarthestViewportElement {
			get {
				return default(SVGElement);
			}
		}

		public SVGRect GetBBox() {
			return default(SVGRect);
		}

		public SVGMatrix GetCTM() {
			return default(SVGMatrix);
		}

		public SVGMatrix GetScreenCTM() {
			return default(SVGMatrix);
		}

		public SVGMatrix GetTransformToElement(SVGGraphicsElement element) {
			return default(SVGMatrix);
		}

		public bool HasExtension(string extension) {
			return false;
		}

		[IntrinsicProperty]
		public SVGElement NearestViewportElement {
			get {
				return default(SVGElement);
			}
		}

		[IntrinsicProperty]
		public SVGStringList RequiredExtensions {
			get {
				return default(SVGStringList);
			}
		}

		[IntrinsicProperty]
		public SVGStringList RequiredFeatures {
			get {
				return default(SVGStringList);
			}
		}

		[IntrinsicProperty]
		public SVGStringList SystemLanguage {
			get {
				return default(SVGStringList);
			}
		}

		[IntrinsicProperty]
		public SVGAnimatedTransformList Transform {
			get {
				return default(SVGAnimatedTransformList);
			}
		}
	}
}
