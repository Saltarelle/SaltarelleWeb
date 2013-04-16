using System.Runtime.CompilerServices;

namespace System.Html {
	[Imported]
	public enum MediaElementReadyState {
		HaveNothing     = 0,
		HaveMetadata    = 1,
		HaveCurrentData = 2,
		HaveFutureData  = 3,
		HaveEnoughData  = 4,
	}
}
