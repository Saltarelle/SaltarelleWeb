using System.Runtime.CompilerServices;

namespace System.Html.Media.Graphics.SVG {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class SVGImageElement : SVGGraphicsElement {
		internal SVGImageElement() {
		}

		void AddEventListener(string type, HtmlEventHandlerWithTarget<SVGImageElement> listener) {
		}

		void AddEventListener(string type, HtmlEventHandlerWithTarget<SVGImageElement> listener, bool capture) {
		}

		[IntrinsicProperty]
		public SVGAnimatedLength Height {
			get {
				return default(SVGAnimatedLength);
			}
		}

		[IntrinsicProperty]
		public SVGAnimatedString Href {
			get {
				return default(SVGAnimatedString);
			}
		}

		[IntrinsicProperty]
		public SVGAnimatedPreserveAspectRatio PreserveAspectRatio {
			get {
				return default(SVGAnimatedPreserveAspectRatio);
			}
		}

		void RemoveEventListener(string type, HtmlEventHandlerWithTarget<SVGImageElement> listener) {
		}

		void RemoveEventListener(string type, HtmlEventHandlerWithTarget<SVGImageElement> listener, bool capture) {
		}

		[IntrinsicProperty]
		public SVGAnimatedLength Width {
			get {
				return default(SVGAnimatedLength);
			}
		}

		[IntrinsicProperty]
		public SVGAnimatedLength X {
			get {
				return default(SVGAnimatedLength);
			}
		}

		[IntrinsicProperty]
		public SVGAnimatedLength Y {
			get {
				return default(SVGAnimatedLength);
			}
		}
	}
}
