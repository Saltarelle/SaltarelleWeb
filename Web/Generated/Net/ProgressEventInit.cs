// ProgressEventInit.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
// 

using System.Html;
using System.Runtime.CompilerServices;

namespace System.Net {
	[Imported, Serializable]
	public partial class ProgressEventInit : EventInit {
		public bool LengthComputable {
			get { return false; }
			set { }
		}

		public ulong Loaded {
			get { return 0; }
			set { }
		}

		public ulong Total {
			get { return 0; }
			set { }
		}
	}
}
