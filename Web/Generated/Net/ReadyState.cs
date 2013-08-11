using System.Runtime.CompilerServices;

namespace System.Net {
	[Imported]
	public enum ReadyState {
		Unsent = 0,
		Opened = 1,
		HeadersReceived = 2,
		Loading = 3,
		Done = 4,
	}
}
