using System.Runtime.CompilerServices;

namespace System.Html {
	[Imported, Serializable]
	public partial class EventInit {
		public bool Bubbles {
			get;
			set;
		}

		public bool Cancelable {
			get;
			set;
		}
	}
}
