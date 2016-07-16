using System.Runtime.CompilerServices;

namespace System.Html.Media {
	[Imported]
	public enum MediaElementReadyState {
		HaveCurrentData = 2,
		HaveEnoughData = 4,
		HaveFutureData = 3,
		HaveMetadata = 1,
		HaveNothing = 0
	}
}
