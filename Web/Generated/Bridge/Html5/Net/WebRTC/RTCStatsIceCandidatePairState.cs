namespace Bridge.Html5.Net.WebRTC
{
	[External, Name("String"), Enum(Emit.StringNameLowerCase)]
	public enum RTCStatsIceCandidatePairState
	{
		Frozen,
		Waiting,
		Inprogress,
		Failed,
		Succeeded,
		Cancelled
	}
}
