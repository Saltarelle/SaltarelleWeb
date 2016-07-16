namespace Bridge.Html5.Net.WebRTC
{
	[External, Enum(Emit.StringNamePreserveCase)]
	public enum RTCStatsType
	{
		Inboundrtp,
		Outboundrtp,
		Session,
		Track,
		Transport,
		Candidatepair,
		Localcandidate,
		Remotecandidate
	}
}
