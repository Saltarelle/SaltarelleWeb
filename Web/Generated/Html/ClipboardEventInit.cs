using System.Runtime.CompilerServices;

namespace System.Html {
	[Imported, Serializable]
	public partial class ClipboardEventInit : EventInit {
		public string Data {
			get;
			set;
		}

		public string DataType {
			get;
			set;
		}
	}
}
