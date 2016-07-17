namespace Bridge.Html5.Net.WebRTC
{
	[External, Name("String"), Enum(Emit.StringNameLowerCase)]
	public enum RTCStatsType
	{
		Candidatepair,
		Inboundrtp,
		Localcandidate,
		Outboundrtp,
		Remotecandidate,
		Session,
		Track,
		Transport
	}
}
