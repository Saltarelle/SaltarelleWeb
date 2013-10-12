using System.Runtime.CompilerServices;

namespace System.Html {
	[Imported, Serializable]
	public partial class WheelEventInit : MouseEventInit {
		public uint DeltaMode {
			get;
			set;
		}

		public double DeltaX {
			get;
			set;
		}

		public double DeltaY {
			get;
			set;
		}

		public double DeltaZ {
			get;
			set;
		}
	}
}
