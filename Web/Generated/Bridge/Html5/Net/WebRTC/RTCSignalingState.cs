namespace Bridge.Html5.Net.WebRTC
{
	[External, NamedValues]
	public enum RTCSignalingState
	{
		Stable,
		[Name("have-local-offer")]
		HaveLocalOffer,
		[Name("have-remote-offer")]
		HaveRemoteOffer,
		[Name("have-local-pranswer")]
		HaveLocalPranswer,
		[Name("have-remote-pranswer")]
		HaveRemotePranswer,
		Closed
	}
}
