using System.Runtime.CompilerServices;

namespace System.Html.Media.Graphics.SVG {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class SVGSymbolElement : SVGElement {
		internal SVGSymbolElement() {
		}

		void AddEventListener(string type, HtmlEventHandlerWithTarget<SVGSymbolElement> listener) {
		}

		void AddEventListener(string type, HtmlEventHandlerWithTarget<SVGSymbolElement> listener, bool capture) {
		}

		public bool HasExtension(string extension) {
			return false;
		}

		[IntrinsicProperty]
		public SVGAnimatedPreserveAspectRatio PreserveAspectRatio {
			get {
				return default(SVGAnimatedPreserveAspectRatio);
			}
		}

		void RemoveEventListener(string type, HtmlEventHandlerWithTarget<SVGSymbolElement> listener) {
		}

		void RemoveEventListener(string type, HtmlEventHandlerWithTarget<SVGSymbolElement> listener, bool capture) {
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
		public SVGAnimatedRect ViewBox {
			get {
				return default(SVGAnimatedRect);
			}
		}
	}
}
