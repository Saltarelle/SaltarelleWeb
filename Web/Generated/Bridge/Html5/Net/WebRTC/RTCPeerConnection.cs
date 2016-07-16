using Bridge.Html5.Media;
using System;

namespace Bridge.Html5.Net.WebRTC
{
	[Namespace("false"), External(ObeysTypeSystem = true), Name("mozRTCPeerConnection")]
	public partial class RTCPeerConnection : EventTarget
	{
		public void AddEventListener(RTCPeerConnectionEvents type, Action listener)
		{
		}

		public void AddEventListener(RTCPeerConnectionEvents type, Action listener, bool capture)
		{
		}

		public void AddEventListener(RTCPeerConnectionEvents type, HtmlEventHandler listener)
		{
		}

		public void AddEventListener(RTCPeerConnectionEvents type, HtmlEventHandler listener, bool capture)
		{
		}

		public void AddEventListener(RTCPeerConnectionEvents type, HtmlEventHandlerWithTarget<RTCPeerConnection> listener)
		{
		}

		public void AddEventListener(RTCPeerConnectionEvents type, HtmlEventHandlerWithTarget<RTCPeerConnection> listener, bool capture)
		{
		}

		public void AddEventListener(RTCPeerConnectionEvents type, IEventListener listener)
		{
		}

		public void AddEventListener(RTCPeerConnectionEvents type, IEventListener listener, bool capture)
		{
		}

		public void AddEventListener(string type, HtmlEventHandlerWithTarget<RTCPeerConnection> listener)
		{
		}

		public void AddEventListener(string type, HtmlEventHandlerWithTarget<RTCPeerConnection> listener, bool capture)
		{
		}

		public void AddIceCandidate(RTCIceCandidate candidate)
		{
		}

		public void AddIceCandidate(RTCIceCandidate candidate, Action successCallback)
		{
		}

		public void AddIceCandidate(RTCIceCandidate candidate, Action successCallback, RTCPeerConnectionErrorCallback failureCallback)
		{
		}

		public void AddStream(MediaStream stream)
		{
		}

		public void AddStream(MediaStream stream, MediaConstraints constraints)
		{
		}

		public void Close()
		{
		}

		public void CreateAnswer(RTCSessionDescriptionCallback successCallback, RTCPeerConnectionErrorCallback failureCallback)
		{
		}

		public void CreateAnswer(RTCSessionDescriptionCallback successCallback, RTCPeerConnectionErrorCallback failureCallback, MediaConstraints constraints)
		{
		}

		public RTCDataChannel CreateDataChannel(string label)
		{
			return default(RTCDataChannel);
		}

		public RTCDataChannel CreateDataChannel(string label, RTCDataChannelInit dataChannelDict)
		{
			return default(RTCDataChannel);
		}

		public void CreateOffer(RTCSessionDescriptionCallback successCallback, RTCPeerConnectionErrorCallback failureCallback)
		{
		}

		public void CreateOffer(RTCSessionDescriptionCallback successCallback, RTCPeerConnectionErrorCallback failureCallback, MediaConstraints constraints)
		{
		}

		public void GetIdentityAssertion()
		{
		}

		public void GetIdentityAssertion(RTCPeerConnectionErrorCallback failureCallback)
		{
		}

		public MediaStream[] GetLocalStreams()
		{
			return null;
		}

		public MediaStream[] GetRemoteStreams()
		{
			return null;
		}

		public void GetStats(MediaStreamTrack selector, RTCStatsCallback successCallback, RTCPeerConnectionErrorCallback failureCallback)
		{
		}

		public MediaStream GetStreamById(string streamId)
		{
			return default(MediaStream);
		}

		[FieldProperty]
		public RTCIceConnectionState IceConnectionState
		{
			get {
				return default(RTCIceConnectionState);
			}
		}

		[FieldProperty]
		public RTCIceGatheringState IceGatheringState
		{
			get {
				return default(RTCIceGatheringState);
			}
		}

		[FieldProperty]
		public RTCSessionDescription LocalDescription
		{
			get {
				return default(RTCSessionDescription);
			}
		}

		[FieldProperty, Name("onaddstream")]
		public HtmlEventHandler OnAddstream
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onclosedconnection")]
		public HtmlEventHandler OnClosedconnection
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onconnection")]
		public HtmlEventHandler OnConnection
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("ondatachannel")]
		public HtmlEventHandler OnDatachannel
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onicecandidate")]
		public HtmlEventHandler OnIcecandidate
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("oniceconnectionstatechange")]
		public HtmlEventHandler OnIceconnectionstatechange
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onidentityresult")]
		public HtmlEventHandler OnIdentityresult
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onnegotiationneeded")]
		public HtmlEventHandler OnNegotiationneeded
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onpeeridentity")]
		public HtmlEventHandler OnPeeridentity
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onremovestream")]
		public HtmlEventHandler OnRemovestream
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onsignalingstatechange")]
		public HtmlEventHandler OnSignalingstatechange
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty]
		public RTCIdentityAssertion PeerIdentity
		{
			get {
				return default(RTCIdentityAssertion);
			}
		}

		[FieldProperty]
		public RTCSessionDescription RemoteDescription
		{
			get {
				return default(RTCSessionDescription);
			}
		}

		public void RemoveEventListener(RTCPeerConnectionEvents type, Action listener)
		{
		}

		public void RemoveEventListener(RTCPeerConnectionEvents type, Action listener, bool capture)
		{
		}

		public void RemoveEventListener(RTCPeerConnectionEvents type, HtmlEventHandler listener)
		{
		}

		public void RemoveEventListener(RTCPeerConnectionEvents type, HtmlEventHandler listener, bool capture)
		{
		}

		public void RemoveEventListener(RTCPeerConnectionEvents type, HtmlEventHandlerWithTarget<RTCPeerConnection> listener)
		{
		}

		public void RemoveEventListener(RTCPeerConnectionEvents type, HtmlEventHandlerWithTarget<RTCPeerConnection> listener, bool capture)
		{
		}

		public void RemoveEventListener(RTCPeerConnectionEvents type, IEventListener listener)
		{
		}

		public void RemoveEventListener(RTCPeerConnectionEvents type, IEventListener listener, bool capture)
		{
		}

		public void RemoveEventListener(string type, HtmlEventHandlerWithTarget<RTCPeerConnection> listener)
		{
		}

		public void RemoveEventListener(string type, HtmlEventHandlerWithTarget<RTCPeerConnection> listener, bool capture)
		{
		}

		public void RemoveStream(MediaStream stream)
		{
		}

		public void SetIdentityProvider(string provider)
		{
		}

		public void SetIdentityProvider(string provider, string protocol)
		{
		}

		public void SetIdentityProvider(string provider, string protocol, string username)
		{
		}

		public void SetLocalDescription(RTCSessionDescription description)
		{
		}

		public void SetLocalDescription(RTCSessionDescription description, Action successCallback)
		{
		}

		public void SetLocalDescription(RTCSessionDescription description, Action successCallback, RTCPeerConnectionErrorCallback failureCallback)
		{
		}

		public void SetRemoteDescription(RTCSessionDescription description)
		{
		}

		public void SetRemoteDescription(RTCSessionDescription description, Action successCallback)
		{
		}

		public void SetRemoteDescription(RTCSessionDescription description, Action successCallback, RTCPeerConnectionErrorCallback failureCallback)
		{
		}

		[FieldProperty]
		public RTCSignalingState SignalingState
		{
			get {
				return default(RTCSignalingState);
			}
		}

		public void UpdateIce()
		{
		}

		public void UpdateIce(RTCConfiguration configuration)
		{
		}

		public void UpdateIce(RTCConfiguration configuration, MediaConstraints constraints)
		{
		}
	}
}
