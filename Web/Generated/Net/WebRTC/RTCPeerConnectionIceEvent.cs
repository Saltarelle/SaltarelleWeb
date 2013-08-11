// RTCPeerConnectionIceEvent.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
// 

using System.Html;
using System.Runtime.CompilerServices;

namespace System.Net.WebRTC {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class RTCPeerConnectionIceEvent : Event {
		internal RTCPeerConnectionIceEvent() {
		}

		public RTCPeerConnectionIceEvent(string type) {
		}

		public RTCPeerConnectionIceEvent(string type, RTCPeerConnectionIceEventInit eventInitDict) {
		}

		[IntrinsicProperty]
		public RTCIceCandidate Candidate {
			get { return default(RTCIceCandidate); }
		}
	}
}
