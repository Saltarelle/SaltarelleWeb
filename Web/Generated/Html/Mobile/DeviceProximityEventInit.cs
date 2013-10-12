using System.Runtime.CompilerServices;

namespace System.Html.Mobile {
	[Imported, Serializable]
	public partial class DeviceProximityEventInit : EventInit {
		public double Max {
			get;
			set;
		}

		public double Min {
			get;
			set;
		}

		public double Value {
			get;
			set;
		}
	}
}
