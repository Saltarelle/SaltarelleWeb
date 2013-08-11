// RTCPeerConnectionIceEventInit.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
// 

using System.Html;
using System.Runtime.CompilerServices;

namespace System.Net.WebRTC {
	[Imported, Serializable]
	public partial class RTCPeerConnectionIceEventInit : EventInit {
		public RTCIceCandidate Candidate {
			get { return default(RTCIceCandidate); }
			set { }
		}
	}
}
