// PositionOptions.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
// 

using System.Runtime.CompilerServices;

namespace System.Html.Geolocation {
	[Imported, Serializable]
	public partial class PositionOptions {
		public bool EnableHighAccuracy {
			get { return false; }
			set { }
		}

		public int MaximumAge {
			get { return 0; }
			set { }
		}

		public int Timeout {
			get { return 0; }
			set { }
		}
	}
}
