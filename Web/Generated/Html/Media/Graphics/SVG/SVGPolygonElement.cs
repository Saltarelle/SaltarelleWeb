using System.Runtime.CompilerServices;

namespace System.Html.Media.Graphics.SVG {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class SVGPolygonElement : SVGGraphicsElement {
		internal SVGPolygonElement() {
		}

		void AddEventListener(string type, HtmlEventHandlerWithTarget<SVGPolygonElement> listener) {
		}

		void AddEventListener(string type, HtmlEventHandlerWithTarget<SVGPolygonElement> listener, bool capture) {
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

		void RemoveEventListener(string type, HtmlEventHandlerWithTarget<SVGPolygonElement> listener) {
		}

		void RemoveEventListener(string type, HtmlEventHandlerWithTarget<SVGPolygonElement> listener, bool capture) {
		}
	}
}
