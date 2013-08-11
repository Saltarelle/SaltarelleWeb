using System.Runtime.CompilerServices;

namespace System.Html {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class TouchEvent : UIEvent {
		internal TouchEvent() {
		}

		[IntrinsicProperty]
		public bool AltKey {
			get { return false; }
		}

		[IntrinsicProperty]
		public TouchList ChangedTouches {
			get { return default(TouchList); }
		}

		[IntrinsicProperty]
		public bool CtrlKey {
			get { return false; }
		}

		[IntrinsicProperty]
		public bool MetaKey {
			get { return false; }
		}

		[IntrinsicProperty]
		public bool ShiftKey {
			get { return false; }
		}

		[IntrinsicProperty]
		public TouchList TargetTouches {
			get { return default(TouchList); }
		}

		[IntrinsicProperty]
		public TouchList Touches {
			get { return default(TouchList); }
		}
	}
}
