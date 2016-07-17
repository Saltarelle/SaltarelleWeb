namespace Bridge.Html5.Net.WebRTC
{
	[External, Name("String"), Enum(Emit.StringNameLowerCase)]
	public enum RTCSignalingState
	{
		Closed,
		[Name("have-local-offer")]
		HaveLocalOffer,
		[Name("have-local-pranswer")]
		HaveLocalPranswer,
		[Name("have-remote-offer")]
		HaveRemoteOffer,
		[Name("have-remote-pranswer")]
		HaveRemotePranswer,
		Stable
	}
}
