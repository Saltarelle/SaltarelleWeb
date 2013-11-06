using System.Runtime.CompilerServices;

namespace System.Net {
	[Imported]
	public enum ReadyState {
		Done = 4,
		HeadersReceived = 2,
		Loading = 3,
		Opened = 1,
		Unsent = 0
	}
}
