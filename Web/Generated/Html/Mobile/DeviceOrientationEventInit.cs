// DeviceOrientationEventInit.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
// 

using System.Runtime.CompilerServices;

namespace System.Html.Mobile {
	[Imported, Serializable]
	public partial class DeviceOrientationEventInit : EventInit {
		public bool Absolute {
			get { return false; }
			set { }
		}

		public double Alpha {
			get { return 0; }
			set { }
		}

		public double Beta {
			get { return 0; }
			set { }
		}

		public double Gamma {
			get { return 0; }
			set { }
		}
	}
}
