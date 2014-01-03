using System.Runtime.CompilerServices;

namespace System.Html {
	[Imported, Serializable]
	public partial class PointerEventInit : MouseEventInit {
		public int Height {
			get;
			set;
		}

		public bool IsPrimary {
			get;
			set;
		}

		public int PointerId {
			get;
			set;
		}

		public string PointerType {
			get;
			set;
		}

		public float Pressure {
			get;
			set;
		}

		public int TiltX {
			get;
			set;
		}

		public int TiltY {
			get;
			set;
		}

		public int Width {
			get;
			set;
		}
	}
}
