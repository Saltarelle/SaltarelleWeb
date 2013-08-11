// UIEventInit.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
// 

using System.Runtime.CompilerServices;

namespace System.Html {
	[Imported, Serializable]
	public partial class UIEventInit : EventInit {
		public int Detail {
			get { return 0; }
			set { }
		}

		public WindowInstance View {
			get { return default(WindowInstance); }
			set { }
		}
	}
}
