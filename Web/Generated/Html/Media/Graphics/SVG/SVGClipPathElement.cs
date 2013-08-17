using System.Runtime.CompilerServices;

namespace System.Html.Media.Graphics.SVG {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class SVGClipPathElement : SVGElement {
		internal SVGClipPathElement() {
		}

		void AddEventListener(string type, HtmlEventHandlerWithTarget<SVGClipPathElement> listener) {
		}

		void AddEventListener(string type, HtmlEventHandlerWithTarget<SVGClipPathElement> listener, bool capture) {
		}

		[IntrinsicProperty]
		public SVGAnimatedEnumeration<SVGUnitType> ClipPathUnits {
			get {
				return default(SVGAnimatedEnumeration<SVGUnitType>);
			}
		}

		void RemoveEventListener(string type, HtmlEventHandlerWithTarget<SVGClipPathElement> listener) {
		}

		void RemoveEventListener(string type, HtmlEventHandlerWithTarget<SVGClipPathElement> listener, bool capture) {
		}

		[ScriptName("SVG_UNIT_TYPE_OBJECTBOUNDINGBOX")]
		public const ushort SVG_UNIT_TYPE_OBJECTBOUNDINGBOX = 2;

		[ScriptName("SVG_UNIT_TYPE_UNKNOWN")]
		public const ushort SVG_UNIT_TYPE_UNKNOWN = 0;

		[ScriptName("SVG_UNIT_TYPE_USERSPACEONUSE")]
		public const ushort SVG_UNIT_TYPE_USERSPACEONUSE = 1;

		[IntrinsicProperty]
		public SVGAnimatedTransformList Transform {
			get {
				return default(SVGAnimatedTransformList);
			}
		}
	}
}
