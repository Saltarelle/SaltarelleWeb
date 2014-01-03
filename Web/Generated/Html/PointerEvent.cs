using System.Runtime.CompilerServices;

namespace System.Html {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class PointerEvent : MouseEvent {
		internal PointerEvent() {
		}

		public PointerEvent(string type) {
		}

		public PointerEvent(string type, PointerEventInit eventInitDict) {
		}

		[IntrinsicProperty]
		public int Height {
			get {
				return 0;
			}
		}

		[IntrinsicProperty]
		public bool IsPrimary {
			get {
				return false;
			}
		}

		[IntrinsicProperty]
		public int PointerId {
			get {
				return 0;
			}
		}

		[IntrinsicProperty]
		public string PointerType {
			get {
				return null;
			}
		}

		[IntrinsicProperty]
		public float Pressure {
			get {
				return 0;
			}
		}

		[IntrinsicProperty]
		public int TiltX {
			get {
				return 0;
			}
		}

		[IntrinsicProperty]
		public int TiltY {
			get {
				return 0;
			}
		}

		[IntrinsicProperty]
		public int Width {
			get {
				return 0;
			}
		}
	}
}
