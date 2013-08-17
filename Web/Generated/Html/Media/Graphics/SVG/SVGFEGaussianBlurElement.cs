using System.Runtime.CompilerServices;

namespace System.Html.Media.Graphics.SVG {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class SVGFEGaussianBlurElement : SVGElement {
		internal SVGFEGaussianBlurElement() {
		}

		void AddEventListener(string type, HtmlEventHandlerWithTarget<SVGFEGaussianBlurElement> listener) {
		}

		void AddEventListener(string type, HtmlEventHandlerWithTarget<SVGFEGaussianBlurElement> listener, bool capture) {
		}

		[IntrinsicProperty]
		public SVGAnimatedString In1 {
			get {
				return default(SVGAnimatedString);
			}
		}

		void RemoveEventListener(string type, HtmlEventHandlerWithTarget<SVGFEGaussianBlurElement> listener) {
		}

		void RemoveEventListener(string type, HtmlEventHandlerWithTarget<SVGFEGaussianBlurElement> listener, bool capture) {
		}

		public void SetStdDeviation(float stdDeviationX, float stdDeviationY) {
		}

		[IntrinsicProperty]
		public SVGAnimatedNumber StdDeviationX {
			get {
				return default(SVGAnimatedNumber);
			}
		}

		[IntrinsicProperty]
		public SVGAnimatedNumber StdDeviationY {
			get {
				return default(SVGAnimatedNumber);
			}
		}
	}
}
