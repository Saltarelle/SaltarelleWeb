using System.Runtime.CompilerServices;

namespace System.Net.WebRTC {
	[Imported, NamedValues]
	public enum RTCStatsType {
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
