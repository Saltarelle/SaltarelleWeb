using System.Runtime.CompilerServices;

namespace System.Net.WebSockets {
	[Imported]
	public enum ReadyState {
		Closed = 3,
		Closing = 2,
		Connecting = 0,
		Open = 1
	}
}
