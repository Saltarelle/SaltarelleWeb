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
