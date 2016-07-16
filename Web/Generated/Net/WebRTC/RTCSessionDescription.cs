using System.Runtime.CompilerServices;

namespace System.Net.WebRTC {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true), ScriptName("mozRTCSessionDescription")]
	public partial class RTCSessionDescription {
		public RTCSessionDescription() {
		}

		public RTCSessionDescription(RTCSessionDescriptionInit descriptionInitDict) {
		}

		[IntrinsicProperty]
		public string Sdp {
			get {
				return null;
			}
			set {
			}
		}

		[IntrinsicProperty]
		public RTCSdpType? Type {
			get {
				return null;
			}
			set {
			}
		}
	}
}
