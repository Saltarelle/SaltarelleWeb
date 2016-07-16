namespace Bridge.Html5.Net.WebRTC
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class RTCPeerConnectionIceEvent : Event
	{
		internal extern RTCPeerConnectionIceEvent();

		public extern RTCPeerConnectionIceEvent(string type);

		public extern RTCPeerConnectionIceEvent(string type, RTCPeerConnectionIceEventInit eventInitDict);

		[FieldProperty]
		public extern RTCIceCandidate Candidate
		{
			get;
		}
	}
}
