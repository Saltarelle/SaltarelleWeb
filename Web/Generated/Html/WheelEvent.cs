using System.Runtime.CompilerServices;

namespace System.Html {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class WheelEvent : MouseEvent {
		internal WheelEvent() {
		}

		public WheelEvent(string type) {
		}

		public WheelEvent(string type, WheelEventInit eventInitDict) {
		}

		[IntrinsicProperty]
		public WheelDeltaMode DeltaMode {
			get { return default(WheelDeltaMode); }
		}

		[IntrinsicProperty]
		public double DeltaX {
			get { return 0; }
		}

		[IntrinsicProperty]
		public double DeltaY {
			get { return 0; }
		}

		[IntrinsicProperty]
		public double DeltaZ {
			get { return 0; }
		}

		[ScriptName("DOM_DELTA_LINE")]
		public const uint DOM_DELTA_LINE = 1;

		[ScriptName("DOM_DELTA_PAGE")]
		public const uint DOM_DELTA_PAGE = 2;

		[ScriptName("DOM_DELTA_PIXEL")]
		public const uint DOM_DELTA_PIXEL = 0;
	}
}
