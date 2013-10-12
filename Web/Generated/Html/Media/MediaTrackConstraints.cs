using System.Runtime.CompilerServices;

namespace System.Html.Media {
	[Imported, Serializable]
	public partial class MediaTrackConstraints {
		public object Mandatory {
			get;
			set;
		}

		public MediaTrackConstraintSet[] Optional {
			get;
			set;
		}
	}
}
