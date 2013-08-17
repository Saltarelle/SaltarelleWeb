using System.Runtime.CompilerServices;

namespace System.Html.Media.Graphics.SVG {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class SVGPolylineElement : SVGGraphicsElement {
		internal SVGPolylineElement() {
		}

		void AddEventListener(string type, HtmlEventHandlerWithTarget<SVGPolylineElement> listener) {
		}

		void AddEventListener(string type, HtmlEventHandlerWithTarget<SVGPolylineElement> listener, bool capture) {
		}

		[IntrinsicProperty]
		public SVGPointList AnimatedPoints {
			get {
				return default(SVGPointList);
			}
		}

		[IntrinsicProperty]
		public SVGPointList Points {
			get {
				return default(SVGPointList);
			}
		}

		void RemoveEventListener(string type, HtmlEventHandlerWithTarget<SVGPolylineElement> listener) {
		}

		void RemoveEventListener(string type, HtmlEventHandlerWithTarget<SVGPolylineElement> listener, bool capture) {
		}
	}
}
