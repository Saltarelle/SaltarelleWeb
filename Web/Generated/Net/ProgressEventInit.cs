using System.Html;
using System.Runtime.CompilerServices;

namespace System.Net {
	[Imported, Serializable]
	public partial class ProgressEventInit : EventInit {
		public bool LengthComputable {
			get;
			set;
		}

		public ulong Loaded {
			get;
			set;
		}

		public ulong Total {
			get;
			set;
		}
	}
}
