// RTCIceCandidate.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
// 

using System.Runtime.CompilerServices;

namespace System.Net.WebRTC {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true), ScriptName("Object")]
	public partial class RTCIceCandidate {
		public RTCIceCandidate() {
		}

		public RTCIceCandidate(RTCIceCandidateInit candidateInitDict) {
		}

		[IntrinsicProperty]
		public string Candidate {
			get { return null; }
			set { }
		}

		[IntrinsicProperty]
		public string SdpMid {
			get { return null; }
			set { }
		}

		[IntrinsicProperty]
		public ushort? SdpMLineIndex {
			get { return null; }
			set { }
		}
	}
}
