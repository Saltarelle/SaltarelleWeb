using System.Runtime.CompilerServices;

namespace System.Html.Media.Graphics.SVG {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class SVGViewElement : SVGElement {
		internal SVGViewElement() {
		}

		public void AddEventListener(string type, HtmlEventHandlerWithTarget<SVGViewElement> listener) {
		}

		public void AddEventListener(string type, HtmlEventHandlerWithTarget<SVGViewElement> listener, bool capture) {
		}

		public void AddEventListener(SVGViewElementEvents type, Action listener) {
		}

		public void AddEventListener(SVGViewElementEvents type, Action listener, bool capture) {
		}

		public void AddEventListener(SVGViewElementEvents type, HtmlEventHandler listener) {
		}

		public void AddEventListener(SVGViewElementEvents type, HtmlEventHandler listener, bool capture) {
		}

		public void AddEventListener(SVGViewElementEvents type, HtmlEventHandlerWithTarget<SVGViewElement> listener) {
		}

		public void AddEventListener(SVGViewElementEvents type, HtmlEventHandlerWithTarget<SVGViewElement> listener, bool capture) {
		}

		public void AddEventListener(SVGViewElementEvents type, IEventListener listener) {
		}

		public void AddEventListener(SVGViewElementEvents type, IEventListener listener, bool capture) {
		}

		[IntrinsicProperty]
		public SVGAnimatedPreserveAspectRatio PreserveAspectRatio {
			get {
				return default(SVGAnimatedPreserveAspectRatio);
			}
		}

		public void RemoveEventListener(string type, HtmlEventHandlerWithTarget<SVGViewElement> listener) {
		}

		public void RemoveEventListener(string type, HtmlEventHandlerWithTarget<SVGViewElement> listener, bool capture) {
		}

		public void RemoveEventListener(SVGViewElementEvents type, Action listener) {
		}

		public void RemoveEventListener(SVGViewElementEvents type, Action listener, bool capture) {
		}

		public void RemoveEventListener(SVGViewElementEvents type, HtmlEventHandler listener) {
		}

		public void RemoveEventListener(SVGViewElementEvents type, HtmlEventHandler listener, bool capture) {
		}

		public void RemoveEventListener(SVGViewElementEvents type, HtmlEventHandlerWithTarget<SVGViewElement> listener) {
		}

		public void RemoveEventListener(SVGViewElementEvents type, HtmlEventHandlerWithTarget<SVGViewElement> listener, bool capture) {
		}

		public void RemoveEventListener(SVGViewElementEvents type, IEventListener listener) {
		}

		public void RemoveEventListener(SVGViewElementEvents type, IEventListener listener, bool capture) {
		}

		[ScriptName("SVG_ZOOMANDPAN_DISABLE")]
		public const ushort SVG_ZOOMANDPAN_DISABLE = 1;

		[ScriptName("SVG_ZOOMANDPAN_MAGNIFY")]
		public const ushort SVG_ZOOMANDPAN_MAGNIFY = 2;

		[ScriptName("SVG_ZOOMANDPAN_UNKNOWN")]
		public const ushort SVG_ZOOMANDPAN_UNKNOWN = 0;

		[IntrinsicProperty]
		public SVGAnimatedRect ViewBox {
			get {
				return default(SVGAnimatedRect);
			}
		}

		[IntrinsicProperty]
		public SVGStringList ViewTarget {
			get {
				return default(SVGStringList);
			}
		}

		[IntrinsicProperty]
		public SVGZoomAndPanType ZoomAndPan {
			get {
				return default(SVGZoomAndPanType);
			}
			set {
			}
		}
	}
}
