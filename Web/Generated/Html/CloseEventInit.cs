using System.Runtime.CompilerServices;

namespace System.Html {
	[Imported, Serializable]
	public partial class CloseEventInit : EventInit {
		public ushort Code {
			get { return 0; }
			set { }
		}

		public string Reason {
			get { return null; }
			set { }
		}

		public bool WasClean {
			get { return false; }
			set { }
		}
	}
}
