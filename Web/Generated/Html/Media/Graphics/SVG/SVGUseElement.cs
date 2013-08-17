using System.Runtime.CompilerServices;

namespace System.Html.Media.Graphics.SVG {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class SVGUseElement : SVGGraphicsElement {
		internal SVGUseElement() {
		}

		void AddEventListener(string type, HtmlEventHandlerWithTarget<SVGUseElement> listener) {
		}

		void AddEventListener(string type, HtmlEventHandlerWithTarget<SVGUseElement> listener, bool capture) {
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

		void RemoveEventListener(string type, HtmlEventHandlerWithTarget<SVGUseElement> listener) {
		}

		void RemoveEventListener(string type, HtmlEventHandlerWithTarget<SVGUseElement> listener, bool capture) {
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
