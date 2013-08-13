using System.Runtime.CompilerServices;

namespace System.Html {
	[Imported, Serializable]
	public partial class CloseEventInit : EventInit {
		public ushort Code {
			get;
			set;
		}

		public string Reason {
			get;
			set;
		}

		public bool WasClean {
			get;
			set;
		}
	}
}
