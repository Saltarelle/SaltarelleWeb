using System.Runtime.CompilerServices;

namespace System.Html.Media.Graphics.SVG {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class SVGAElement : SVGGraphicsElement {
		internal SVGAElement() {
		}

		void AddEventListener(string type, HtmlEventHandlerWithTarget<SVGAElement> listener) {
		}

		void AddEventListener(string type, HtmlEventHandlerWithTarget<SVGAElement> listener, bool capture) {
		}

		[IntrinsicProperty]
		public string Download {
			get {
				return null;
			}
			set {
			}
		}

		[IntrinsicProperty]
		public SVGAnimatedString Href {
			get {
				return default(SVGAnimatedString);
			}
		}

		void RemoveEventListener(string type, HtmlEventHandlerWithTarget<SVGAElement> listener) {
		}

		void RemoveEventListener(string type, HtmlEventHandlerWithTarget<SVGAElement> listener, bool capture) {
		}

		[IntrinsicProperty]
		public SVGAnimatedString Target {
			get {
				return default(SVGAnimatedString);
			}
		}
	}
}
