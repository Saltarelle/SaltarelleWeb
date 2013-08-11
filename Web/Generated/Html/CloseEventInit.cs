// CloseEventInit.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
// 

using System.Runtime.CompilerServices;

namespace System.Html {
	[Imported, Serializable]
	public partial class CloseEventInit : EventInit {
		public ushort Code {
			get { return 0; }
			set { }
		}

		public string Reason {
			get { return null; }
			set { }
		}

		public bool WasClean {
			get { return false; }
			set { }
		}
	}
}
