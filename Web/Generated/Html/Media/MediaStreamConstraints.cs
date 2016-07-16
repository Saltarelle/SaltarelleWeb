using System.Runtime.CompilerServices;

namespace System.Html.Media {
	[Imported, Serializable]
	public partial class MediaStreamConstraints {
		public TypeOption<bool, object> Audio {
			get;
			set;
		}

		public bool Fake {
			get;
			set;
		}

		public bool Picture {
			get;
			set;
		}

		public TypeOption<bool, object> Video {
			get;
			set;
		}
	}
}
