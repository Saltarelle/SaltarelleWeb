using System.Html;
using System.Html.Media;
using System.Runtime.CompilerServices;

namespace System.Net.WebRTC {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true), ScriptName("mozRTCPeerConnection")]
	public partial class RTCPeerConnection : EventTarget {
		public void AddEventListener(RTCPeerConnectionEvents type, Action listener) {
		}

		public void AddEventListener(RTCPeerConnectionEvents type, Action listener, bool capture) {
		}

		public void AddEventListener(RTCPeerConnectionEvents type, HtmlEventHandler listener) {
		}

		public void AddEventListener(RTCPeerConnectionEvents type, HtmlEventHandler listener, bool capture) {
		}

		public void AddEventListener(RTCPeerConnectionEvents type, HtmlEventHandlerWithTarget<RTCPeerConnection> listener) {
		}

		public void AddEventListener(RTCPeerConnectionEvents type, HtmlEventHandlerWithTarget<RTCPeerConnection> listener, bool capture) {
		}

		public void AddEventListener(RTCPeerConnectionEvents type, IEventListener listener) {
		}

		public void AddEventListener(RTCPeerConnectionEvents type, IEventListener listener, bool capture) {
		}

		public void AddEventListener(string type, HtmlEventHandlerWithTarget<RTCPeerConnection> listener) {
		}

		public void AddEventListener(string type, HtmlEventHandlerWithTarget<RTCPeerConnection> listener, bool capture) {
		}

		public void AddIceCandidate(RTCIceCandidate candidate) {
		}

		public void AddIceCandidate(RTCIceCandidate candidate, Action successCallback) {
		}

		public void AddIceCandidate(RTCIceCandidate candidate, Action successCallback, RTCPeerConnectionErrorCallback failureCallback) {
		}

		public void AddStream(MediaStream stream) {
		}

		public void AddStream(MediaStream stream, MediaConstraints constraints) {
		}

		public void Close() {
		}

		public void CreateAnswer(RTCSessionDescriptionCallback successCallback, RTCPeerConnectionErrorCallback failureCallback) {
		}

		public void CreateAnswer(RTCSessionDescriptionCallback successCallback, RTCPeerConnectionErrorCallback failureCallback, MediaConstraints constraints) {
		}

		public RTCDataChannel CreateDataChannel(string label) {
			return default(RTCDataChannel);
		}

		public RTCDataChannel CreateDataChannel(string label, RTCDataChannelInit dataChannelDict) {
			return default(RTCDataChannel);
		}

		public void CreateOffer(RTCSessionDescriptionCallback successCallback, RTCPeerConnectionErrorCallback failureCallback) {
		}

		public void CreateOffer(RTCSessionDescriptionCallback successCallback, RTCPeerConnectionErrorCallback failureCallback, MediaConstraints constraints) {
		}

		public MediaStream[] GetLocalStreams() {
			return null;
		}

		public MediaStream[] GetRemoteStreams() {
			return null;
		}

		public void GetStats(MediaStreamTrack selector, RTCStatsCallback successCallback, RTCPeerConnectionErrorCallback failureCallback) {
		}

		public MediaStream GetStreamById(string streamId) {
			return default(MediaStream);
		}

		[IntrinsicProperty]
		public RTCIceConnectionState IceConnectionState {
			get {
				return default(RTCIceConnectionState);
			}
		}

		[IntrinsicProperty]
		public RTCIceGatheringState IceGatheringState {
			get {
				return default(RTCIceGatheringState);
			}
		}

		[IntrinsicProperty]
		public RTCSessionDescription LocalDescription {
			get {
				return default(RTCSessionDescription);
			}
		}

		[IntrinsicProperty, ScriptName("onaddstream")]
		public HtmlEventHandler OnAddstream {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onclosedconnection")]
		public HtmlEventHandler OnClosedconnection {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onconnection")]
		public HtmlEventHandler OnConnection {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("ondatachannel")]
		public HtmlEventHandler OnDatachannel {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onicecandidate")]
		public HtmlEventHandler OnIcecandidate {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("oniceconnectionstatechange")]
		public HtmlEventHandler OnIceconnectionstatechange {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onnegotiationneeded")]
		public HtmlEventHandler OnNegotiationneeded {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onremovestream")]
		public HtmlEventHandler OnRemovestream {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onsignalingstatechange")]
		public HtmlEventHandler OnSignalingstatechange {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty]
		public RTCSessionDescription RemoteDescription {
			get {
				return default(RTCSessionDescription);
			}
		}

		public void RemoveEventListener(RTCPeerConnectionEvents type, Action listener) {
		}

		public void RemoveEventListener(RTCPeerConnectionEvents type, Action listener, bool capture) {
		}

		public void RemoveEventListener(RTCPeerConnectionEvents type, HtmlEventHandler listener) {
		}

		public void RemoveEventListener(RTCPeerConnectionEvents type, HtmlEventHandler listener, bool capture) {
		}

		public void RemoveEventListener(RTCPeerConnectionEvents type, HtmlEventHandlerWithTarget<RTCPeerConnection> listener) {
		}

		public void RemoveEventListener(RTCPeerConnectionEvents type, HtmlEventHandlerWithTarget<RTCPeerConnection> listener, bool capture) {
		}

		public void RemoveEventListener(RTCPeerConnectionEvents type, IEventListener listener) {
		}

		public void RemoveEventListener(RTCPeerConnectionEvents type, IEventListener listener, bool capture) {
		}

		public void RemoveEventListener(string type, HtmlEventHandlerWithTarget<RTCPeerConnection> listener) {
		}

		public void RemoveEventListener(string type, HtmlEventHandlerWithTarget<RTCPeerConnection> listener, bool capture) {
		}

		public void RemoveStream(MediaStream stream) {
		}

		public void SetLocalDescription(RTCSessionDescription description) {
		}

		public void SetLocalDescription(RTCSessionDescription description, Action successCallback) {
		}

		public void SetLocalDescription(RTCSessionDescription description, Action successCallback, RTCPeerConnectionErrorCallback failureCallback) {
		}

		public void SetRemoteDescription(RTCSessionDescription description) {
		}

		public void SetRemoteDescription(RTCSessionDescription description, Action successCallback) {
		}

		public void SetRemoteDescription(RTCSessionDescription description, Action successCallback, RTCPeerConnectionErrorCallback failureCallback) {
		}

		[IntrinsicProperty]
		public RTCSignalingState SignalingState {
			get {
				return default(RTCSignalingState);
			}
		}

		public void UpdateIce() {
		}

		public void UpdateIce(RTCConfiguration configuration) {
		}

		public void UpdateIce(RTCConfiguration configuration, MediaConstraints constraints) {
		}
	}
}
