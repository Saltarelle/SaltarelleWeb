using System.Runtime.CompilerServices;

namespace System.Html.Media.Graphics.SVG {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class SVGLinearGradientElement : SVGGradientElement {
		internal SVGLinearGradientElement() {
		}

		void AddEventListener(string type, HtmlEventHandlerWithTarget<SVGLinearGradientElement> listener) {
		}

		void AddEventListener(string type, HtmlEventHandlerWithTarget<SVGLinearGradientElement> listener, bool capture) {
		}

		void RemoveEventListener(string type, HtmlEventHandlerWithTarget<SVGLinearGradientElement> listener) {
		}

		void RemoveEventListener(string type, HtmlEventHandlerWithTarget<SVGLinearGradientElement> listener, bool capture) {
		}

		[IntrinsicProperty]
		public SVGAnimatedLength X1 {
			get {
				return default(SVGAnimatedLength);
			}
		}

		[IntrinsicProperty]
		public SVGAnimatedLength X2 {
			get {
				return default(SVGAnimatedLength);
			}
		}

		[IntrinsicProperty]
		public SVGAnimatedLength Y1 {
			get {
				return default(SVGAnimatedLength);
			}
		}

		[IntrinsicProperty]
		public SVGAnimatedLength Y2 {
			get {
				return default(SVGAnimatedLength);
			}
		}
	}
}
