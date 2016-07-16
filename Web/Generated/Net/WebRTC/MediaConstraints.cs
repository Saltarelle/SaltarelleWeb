using System.Runtime.CompilerServices;

namespace System.Net.WebRTC {
	[Imported, Serializable]
	public partial class MediaConstraints {
		public object Mandatory {
			get;
			set;
		}

		public MediaConstraintSet[] Optional {
			get;
			set;
		}
	}
}
