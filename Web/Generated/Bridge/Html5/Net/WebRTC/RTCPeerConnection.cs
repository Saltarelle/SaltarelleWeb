using Bridge.Html5.Media;
using System;

namespace Bridge.Html5.Net.WebRTC
{
	[Namespace("false"), External, Name("mozRTCPeerConnection")]
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

		public readonly RTCIceConnectionState IceConnectionState;

		public readonly RTCIceGatheringState IceGatheringState;

		public readonly RTCSessionDescription LocalDescription;

		[Name("onaddstream")]
		public HtmlEventHandler OnAddstream;

		[Name("onclosedconnection")]
		public HtmlEventHandler OnClosedconnection;

		[Name("onconnection")]
		public HtmlEventHandler OnConnection;

		[Name("ondatachannel")]
		public HtmlEventHandler OnDatachannel;

		[Name("onicecandidate")]
		public HtmlEventHandler OnIcecandidate;

		[Name("oniceconnectionstatechange")]
		public HtmlEventHandler OnIceconnectionstatechange;

		[Name("onidentityresult")]
		public HtmlEventHandler OnIdentityresult;

		[Name("onnegotiationneeded")]
		public HtmlEventHandler OnNegotiationneeded;

		[Name("onpeeridentity")]
		public HtmlEventHandler OnPeeridentity;

		[Name("onremovestream")]
		public HtmlEventHandler OnRemovestream;

		[Name("onsignalingstatechange")]
		public HtmlEventHandler OnSignalingstatechange;

		public readonly RTCIdentityAssertion PeerIdentity;

		public readonly RTCSessionDescription RemoteDescription;

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

		public readonly RTCSignalingState SignalingState;

		public extern void UpdateIce();

		public extern void UpdateIce(RTCConfiguration configuration);

		public extern void UpdateIce(RTCConfiguration configuration, MediaConstraints constraints);
	}
}
