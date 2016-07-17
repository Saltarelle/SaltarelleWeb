namespace Bridge.Html5.Net.WebRTC
{
	[External, Name("String"), Enum(Emit.StringNameLowerCase)]
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
