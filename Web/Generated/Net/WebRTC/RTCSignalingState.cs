// RTCSignalingState.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
// 

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
		Closed,
	}
}
