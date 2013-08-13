using System.Runtime.CompilerServices;

namespace System.Html.Geolocation {
	[Imported, Serializable]
	public partial class PositionOptions {
		public bool EnableHighAccuracy {
			get;
			set;
		}

		public int MaximumAge {
			get;
			set;
		}

		public int Timeout {
			get;
			set;
		}
	}
}
