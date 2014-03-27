using System.Runtime.CompilerServices;

namespace System.Net.WebRTC {
	public partial class RTCPeerConnection {
		[InlineCode("new ({$System.Html.Window}.RTCPeerConnection || " + "{$System.Html.Window}.webkitRTCPeerConnection || " + "{$System.Html.Window}.mozRTCPeerConnection || " + "{$System.Html.Window}.msRTCPeerConnection || " + "{$System.Html.Window}.oRTCPeerConnection)()")]
		public RTCPeerConnection() {
		}

		[InlineCode("new ({$System.Html.Window}.RTCPeerConnection || " + "{$System.Html.Window}.webkitRTCPeerConnection || " + "{$System.Html.Window}.mozRTCPeerConnection || " + "{$System.Html.Window}.msRTCPeerConnection || " + "{$System.Html.Window}.oRTCPeerConnection)({configuration})")]
		public RTCPeerConnection(RTCConfiguration configuration) {
		}

		[InlineCode("new ({$System.Html.Window}.RTCPeerConnection || " + "{$System.Html.Window}.webkitRTCPeerConnection || " + "{$System.Html.Window}.mozRTCPeerConnection || " + "{$System.Html.Window}.msRTCPeerConnection || " + "{$System.Html.Window}.oRTCPeerConnection)({configuration}, {constraints})")]
		public RTCPeerConnection(RTCConfiguration configuration, object constraints) {
		}
	}
}
