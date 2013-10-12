using System.Runtime.CompilerServices;

namespace System.Html.Media.Graphics.SVG {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class SVGZoomEvent : UIEvent {
		internal SVGZoomEvent() {
		}

		[IntrinsicProperty]
		public float NewScale {
			get {
				return 0;
			}
		}

		[IntrinsicProperty]
		public SVGPoint NewTranslate {
			get {
				return default(SVGPoint);
			}
		}

		[IntrinsicProperty]
		public float PreviousScale {
			get {
				return 0;
			}
		}

		[IntrinsicProperty]
		public SVGPoint PreviousTranslate {
			get {
				return default(SVGPoint);
			}
		}
	}
}
