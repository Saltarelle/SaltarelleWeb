using System.Runtime.CompilerServices;

namespace System.Net.ServerEvents {
	[Imported, Serializable]
	public partial class EventSourceInit {
		public bool WithCredentials {
			get;
			set;
		}
	}
}
