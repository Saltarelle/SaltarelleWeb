﻿using System.Runtime.CompilerServices;

namespace System.Html {
	[Imported, Serializable]
	public partial class HashChangeEventInit : EventInit {
		public string NewURL {
			get;
			set;
		}

		public string OldURL {
			get;
			set;
		}
	}
}
