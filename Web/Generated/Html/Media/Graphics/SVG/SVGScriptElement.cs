using System.Runtime.CompilerServices;

namespace System.Html.Media.Graphics.SVG {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class SVGScriptElement : SVGElement {
		internal SVGScriptElement() {
		}

		void AddEventListener(string type, HtmlEventHandlerWithTarget<SVGScriptElement> listener) {
		}

		void AddEventListener(string type, HtmlEventHandlerWithTarget<SVGScriptElement> listener, bool capture) {
		}

		[IntrinsicProperty]
		public string CrossOrigin {
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

		void RemoveEventListener(string type, HtmlEventHandlerWithTarget<SVGScriptElement> listener) {
		}

		void RemoveEventListener(string type, HtmlEventHandlerWithTarget<SVGScriptElement> listener, bool capture) {
		}

		[IntrinsicProperty]
		public string Type {
			get {
				return null;
			}
			set {
			}
		}
	}
}
