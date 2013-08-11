// WheelEventInit.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
// 

using System.Runtime.CompilerServices;

namespace System.Html {
	[Imported, Serializable]
	public partial class WheelEventInit : MouseEventInit {
		public uint DeltaMode {
			get { return 0; }
			set { }
		}

		public double DeltaX {
			get { return 0; }
			set { }
		}

		public double DeltaY {
			get { return 0; }
			set { }
		}

		public double DeltaZ {
			get { return 0; }
			set { }
		}
	}
}
