using System.Runtime.CompilerServices;

namespace System.Net.WebRTC {
	[Imported, NamedValues]
	public enum RTCSignalingState {
		Stable,
		[ScriptName("have-local-offer")]
		HaveLocalOffer,
		[ScriptName("have-remote-offer")]
		HaveRemoteOffer,
		[ScriptName("have-local-pranswer")]
		HaveLocalPranswer,
		[ScriptName("have-remote-pranswer")]
		HaveRemotePranswer,
		Closed
	}
}
