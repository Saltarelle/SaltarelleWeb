using Bridge.Html5.Media;
using System;

namespace Bridge.Html5.Net.WebRTC
{
	[Namespace("false"), External(ObeysTypeSystem = true), Name("mozRTCPeerConnection")]
	public partial class RTCPeerConnection : EventTarget
	{
		public extern void AddEventListener(RTCPeerConnectionEvents type, Action listener);

		public extern void AddEventListener(RTCPeerConnectionEvents type, Action listener, bool capture);

		public extern void AddEventListener(RTCPeerConnectionEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(RTCPeerConnectionEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(RTCPeerConnectionEvents type, HtmlEventHandlerWithTarget<RTCPeerConnection> listener);

		public extern void AddEventListener(RTCPeerConnectionEvents type, HtmlEventHandlerWithTarget<RTCPeerConnection> listener, bool capture);

		public extern void AddEventListener(RTCPeerConnectionEvents type, IEventListener listener);

		public extern void AddEventListener(RTCPeerConnectionEvents type, IEventListener listener, bool capture);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<RTCPeerConnection> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<RTCPeerConnection> listener, bool capture);

		public extern void AddIceCandidate(RTCIceCandidate candidate);

		public extern void AddIceCandidate(RTCIceCandidate candidate, Action successCallback);

		public extern void AddIceCandidate(RTCIceCandidate candidate, Action successCallback, RTCPeerConnectionErrorCallback failureCallback);

		public extern void AddStream(MediaStream stream);

		public extern void AddStream(MediaStream stream, MediaConstraints constraints);

		public extern void Close();

		public extern void CreateAnswer(RTCSessionDescriptionCallback successCallback, RTCPeerConnectionErrorCallback failureCallback);

		public extern void CreateAnswer(RTCSessionDescriptionCallback successCallback, RTCPeerConnectionErrorCallback failureCallback, MediaConstraints constraints);

		public extern RTCDataChannel CreateDataChannel(string label);

		public extern RTCDataChannel CreateDataChannel(string label, RTCDataChannelInit dataChannelDict);

		public extern void CreateOffer(RTCSessionDescriptionCallback successCallback, RTCPeerConnectionErrorCallback failureCallback);

		public extern void CreateOffer(RTCSessionDescriptionCallback successCallback, RTCPeerConnectionErrorCallback failureCallback, MediaConstraints constraints);

		public extern void GetIdentityAssertion();

		public extern void GetIdentityAssertion(RTCPeerConnectionErrorCallback failureCallback);

		public extern MediaStream[] GetLocalStreams();

		public extern MediaStream[] GetRemoteStreams();

		public extern void GetStats(MediaStreamTrack selector, RTCStatsCallback successCallback, RTCPeerConnectionErrorCallback failureCallback);

		public extern MediaStream GetStreamById(string streamId);

		[FieldProperty]
		public extern RTCIceConnectionState IceConnectionState
		{
			get;
		}

		[FieldProperty]
		public extern RTCIceGatheringState IceGatheringState
		{
			get;
		}

		[FieldProperty]
		public extern RTCSessionDescription LocalDescription
		{
			get;
		}

		[FieldProperty, Name("onaddstream")]
		public extern HtmlEventHandler OnAddstream
		{
			get;
			set;
		}

		[FieldProperty, Name("onclosedconnection")]
		public extern HtmlEventHandler OnClosedconnection
		{
			get;
			set;
		}

		[FieldProperty, Name("onconnection")]
		public extern HtmlEventHandler OnConnection
		{
			get;
			set;
		}

		[FieldProperty, Name("ondatachannel")]
		public extern HtmlEventHandler OnDatachannel
		{
			get;
			set;
		}

		[FieldProperty, Name("onicecandidate")]
		public extern HtmlEventHandler OnIcecandidate
		{
			get;
			set;
		}

		[FieldProperty, Name("oniceconnectionstatechange")]
		public extern HtmlEventHandler OnIceconnectionstatechange
		{
			get;
			set;
		}

		[FieldProperty, Name("onidentityresult")]
		public extern HtmlEventHandler OnIdentityresult
		{
			get;
			set;
		}

		[FieldProperty, Name("onnegotiationneeded")]
		public extern HtmlEventHandler OnNegotiationneeded
		{
			get;
			set;
		}

		[FieldProperty, Name("onpeeridentity")]
		public extern HtmlEventHandler OnPeeridentity
		{
			get;
			set;
		}

		[FieldProperty, Name("onremovestream")]
		public extern HtmlEventHandler OnRemovestream
		{
			get;
			set;
		}

		[FieldProperty, Name("onsignalingstatechange")]
		public extern HtmlEventHandler OnSignalingstatechange
		{
			get;
			set;
		}

		[FieldProperty]
		public extern RTCIdentityAssertion PeerIdentity
		{
			get;
		}

		[FieldProperty]
		public extern RTCSessionDescription RemoteDescription
		{
			get;
		}

		public extern void RemoveEventListener(RTCPeerConnectionEvents type, Action listener);

		public extern void RemoveEventListener(RTCPeerConnectionEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(RTCPeerConnectionEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(RTCPeerConnectionEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(RTCPeerConnectionEvents type, HtmlEventHandlerWithTarget<RTCPeerConnection> listener);

		public extern void RemoveEventListener(RTCPeerConnectionEvents type, HtmlEventHandlerWithTarget<RTCPeerConnection> listener, bool capture);

		public extern void RemoveEventListener(RTCPeerConnectionEvents type, IEventListener listener);

		public extern void RemoveEventListener(RTCPeerConnectionEvents type, IEventListener listener, bool capture);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<RTCPeerConnection> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<RTCPeerConnection> listener, bool capture);

		public extern void RemoveStream(MediaStream stream);

		public extern void SetIdentityProvider(string provider);

		public extern void SetIdentityProvider(string provider, string protocol);

		public extern void SetIdentityProvider(string provider, string protocol, string username);

		public extern void SetLocalDescription(RTCSessionDescription description);

		public extern void SetLocalDescription(RTCSessionDescription description, Action successCallback);

		public extern void SetLocalDescription(RTCSessionDescription description, Action successCallback, RTCPeerConnectionErrorCallback failureCallback);

		public extern void SetRemoteDescription(RTCSessionDescription description);

		public extern void SetRemoteDescription(RTCSessionDescription description, Action successCallback);

		public extern void SetRemoteDescription(RTCSessionDescription description, Action successCallback, RTCPeerConnectionErrorCallback failureCallback);

		[FieldProperty]
		public extern RTCSignalingState SignalingState
		{
			get;
		}

		public extern void UpdateIce();

		public extern void UpdateIce(RTCConfiguration configuration);

		public extern void UpdateIce(RTCConfiguration configuration, MediaConstraints constraints);
	}
}
