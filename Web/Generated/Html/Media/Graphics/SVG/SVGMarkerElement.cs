using System.Runtime.CompilerServices;

namespace System.Html.Media.Graphics.SVG {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class SVGMarkerElement : SVGElement {
		internal SVGMarkerElement() {
		}

		public void AddEventListener(string type, HtmlEventHandlerWithTarget<SVGMarkerElement> listener) {
		}

		public void AddEventListener(string type, HtmlEventHandlerWithTarget<SVGMarkerElement> listener, bool capture) {
		}

		public void AddEventListener(SVGMarkerElementEvents type, Action listener) {
		}

		public void AddEventListener(SVGMarkerElementEvents type, Action listener, bool capture) {
		}

		public void AddEventListener(SVGMarkerElementEvents type, HtmlEventHandler listener) {
		}

		public void AddEventListener(SVGMarkerElementEvents type, HtmlEventHandler listener, bool capture) {
		}

		public void AddEventListener(SVGMarkerElementEvents type, HtmlEventHandlerWithTarget<SVGMarkerElement> listener) {
		}

		public void AddEventListener(SVGMarkerElementEvents type, HtmlEventHandlerWithTarget<SVGMarkerElement> listener, bool capture) {
		}

		public void AddEventListener(SVGMarkerElementEvents type, IEventListener listener) {
		}

		public void AddEventListener(SVGMarkerElementEvents type, IEventListener listener, bool capture) {
		}

		[IntrinsicProperty]
		public SVGAnimatedLength MarkerHeight {
			get {
				return default(SVGAnimatedLength);
			}
		}

		[IntrinsicProperty]
		public SVGAnimatedEnumeration<SVGMarkerUnits> MarkerUnits {
			get {
				return default(SVGAnimatedEnumeration<SVGMarkerUnits>);
			}
		}

		[IntrinsicProperty]
		public SVGAnimatedLength MarkerWidth {
			get {
				return default(SVGAnimatedLength);
			}
		}

		[IntrinsicProperty]
		public SVGAnimatedAngle OrientAngle {
			get {
				return default(SVGAnimatedAngle);
			}
		}

		[IntrinsicProperty]
		public SVGAnimatedEnumeration<SVGMarkerOrient> OrientType {
			get {
				return default(SVGAnimatedEnumeration<SVGMarkerOrient>);
			}
		}

		[IntrinsicProperty]
		public SVGAnimatedPreserveAspectRatio PreserveAspectRatio {
			get {
				return default(SVGAnimatedPreserveAspectRatio);
			}
		}

		[IntrinsicProperty]
		public SVGAnimatedLength RefX {
			get {
				return default(SVGAnimatedLength);
			}
		}

		[IntrinsicProperty]
		public SVGAnimatedLength RefY {
			get {
				return default(SVGAnimatedLength);
			}
		}

		public void RemoveEventListener(string type, HtmlEventHandlerWithTarget<SVGMarkerElement> listener) {
		}

		public void RemoveEventListener(string type, HtmlEventHandlerWithTarget<SVGMarkerElement> listener, bool capture) {
		}

		public void RemoveEventListener(SVGMarkerElementEvents type, Action listener) {
		}

		public void RemoveEventListener(SVGMarkerElementEvents type, Action listener, bool capture) {
		}

		public void RemoveEventListener(SVGMarkerElementEvents type, HtmlEventHandler listener) {
		}

		public void RemoveEventListener(SVGMarkerElementEvents type, HtmlEventHandler listener, bool capture) {
		}

		public void RemoveEventListener(SVGMarkerElementEvents type, HtmlEventHandlerWithTarget<SVGMarkerElement> listener) {
		}

		public void RemoveEventListener(SVGMarkerElementEvents type, HtmlEventHandlerWithTarget<SVGMarkerElement> listener, bool capture) {
		}

		public void RemoveEventListener(SVGMarkerElementEvents type, IEventListener listener) {
		}

		public void RemoveEventListener(SVGMarkerElementEvents type, IEventListener listener, bool capture) {
		}

		public void SetOrientToAngle(SVGAngle angle) {
		}

		public void SetOrientToAuto() {
		}

		[ScriptName("SVG_MARKER_ORIENT_ANGLE")]
		public const ushort SVG_MARKER_ORIENT_ANGLE = 2;

		[ScriptName("SVG_MARKER_ORIENT_AUTO")]
		public const ushort SVG_MARKER_ORIENT_AUTO = 1;

		[ScriptName("SVG_MARKER_ORIENT_UNKNOWN")]
		public const ushort SVG_MARKER_ORIENT_UNKNOWN = 0;

		[ScriptName("SVG_MARKERUNITS_STROKEWIDTH")]
		public const ushort SVG_MARKERUNITS_STROKEWIDTH = 2;

		[ScriptName("SVG_MARKERUNITS_UNKNOWN")]
		public const ushort SVG_MARKERUNITS_UNKNOWN = 0;

		[ScriptName("SVG_MARKERUNITS_USERSPACEONUSE")]
		public const ushort SVG_MARKERUNITS_USERSPACEONUSE = 1;

		[IntrinsicProperty]
		public SVGAnimatedRect ViewBox {
			get {
				return default(SVGAnimatedRect);
			}
		}
	}
}
