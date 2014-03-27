using System.Runtime.CompilerServices;

namespace System.Net.WebRTC {
	[Imported, NamedValues]
	public enum RTCStatsIceCandidatePairState {
		Frozen,
		Waiting,
		Inprogress,
		Failed,
		Succeeded,
		Cancelled
	}
}
