using System.Runtime.CompilerServices;

namespace System.Net.WebSockets {
	[Imported, Serializable]
	public partial class WebSocketElement {
		public bool Encrypted {
			get;
			set;
		}

		public string Hostport {
			get;
			set;
		}

		public int Msgreceived {
			get;
			set;
		}

		public int Msgsent {
			get;
			set;
		}

		public double Receivedsize {
			get;
			set;
		}

		public double Sentsize {
			get;
			set;
		}
	}
}
