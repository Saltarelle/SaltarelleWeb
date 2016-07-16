using System.Runtime.CompilerServices;

namespace System.Html.Mobile {
	[Imported, Serializable]
	public partial class DeviceOrientationEventInit : EventInit {
		public bool Absolute {
			get;
			set;
		}

		public double Alpha {
			get;
			set;
		}

		public double Beta {
			get;
			set;
		}

		public double Gamma {
			get;
			set;
		}
	}
}
